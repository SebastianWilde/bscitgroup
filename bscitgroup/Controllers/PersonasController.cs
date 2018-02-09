using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using bscitgroup.Models;
using System.Data;
using bscitgroup.ViewModels;

namespace bscitgroup.Controllers
{
    public class PersonasController : Controller
    {
        private readonly bscitgroupContext _context;

        public PersonasController(bscitgroupContext context)
        {
            _context = context;
        }

        // GET: Personas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Persona.
                Include(p => p.Intereses).ToListAsync());
        }

        // GET: Personas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var persona = await _context.Persona
                .SingleOrDefaultAsync(m => m.DNI == id);
            if (persona == null)
            {
                return NotFound();
            }

            return View(persona);
        }

        // GET: Personas/Create
        public IActionResult Create()
        {
            var persona = new Persona();
            persona.Intereses = new List<Categorias>();
            CategoriasPersonas(persona);
            return View();
        }

        // POST: Personas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DNI,Nombre,Apellido,Celular,Telefono,Pais,Ciudad,Profesion,Institucion,Correo")] Persona persona, string[] selectedCategorias)
        {
            try
            {
                if (selectedCategorias != null)
                {
                    persona.Intereses = new List<Categorias>();
                    foreach (var categoria in selectedCategorias)
                    {
                        var categoriaAdd = _context.Categorias.Find(int.Parse(categoria));
                        persona.Intereses.Add(categoriaAdd);
                    }
                }
                if (ModelState.IsValid)
                {
                    _context.Add(persona);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (DataException)
            {
                ModelState.AddModelError("", "No es posible guardar los cambios. Trata de nuevo, y si el problema persiste reinicia tu compu.");
            }
            CategoriasPersonas(persona);
            return View(persona);
        }

        // GET: Personas/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Persona persona = _context.Persona
                .Include(p => p.Intereses)
                .Where(i => i.DNI == id)
                .Single();
            CategoriasPersonas(persona);
            //var persona = await _context.Persona.SingleOrDefaultAsync(m => m.DNI == id);
            if (persona == null)
            {
                return NotFound();
            }
            return View(persona);
        }

        private void CategoriasPersonas(Persona persona)
        {
            var allCategorias = _context.Categorias;
            var categoriasPersonas = new HashSet<int>(persona.Intereses.Select(c => c.ID));
            var viewModel = new List<InteresesPersona>();
            foreach (var categoria in allCategorias)
            {
                viewModel.Add(new InteresesPersona
                {
                    CategoriaID = categoria.ID,
                    Nombre = categoria.Nombre,
                    Asignado = categoriasPersonas.Contains(categoria.ID)
                });
            }
            ViewBag.Categorias = viewModel;
        }

        // POST: Personas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DNI,Nombre,Apellido,Celular,Telefono,Pais,Ciudad,Profesion,Institucion,Correo")] Persona persona, string []selectedCategorias)
        {
            if (id != persona.DNI)
            {
                return NotFound();
            }

            Console.WriteLine("HEllo");
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(persona);
                    await _context.SaveChangesAsync();
                    Persona persona3 = _context.Persona
                    .Include(p => p.Intereses).
                    Where(p => p.DNI == id)
                    .Single();
                    Console.WriteLine("HEllo2");
                    ActualizarCategoriaPerson(selectedCategorias, persona3);
                    _context.SaveChanges();
                }
                 catch (DbUpdateConcurrencyException)
                {
                    if (!PersonaExists(persona.DNI))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            Persona persona2 = _context.Persona
            .Include(p => p.Intereses).
            Where(p => p.DNI == id)
            .Single();
            ActualizarCategoriaPerson(selectedCategorias, persona2);
            return View(persona2);
     
        }
        private void ActualizarCategoriaPerson(string[] selectedCategorias,Persona personaActualizar)
        {
            if (selectedCategorias == null)
            {
                personaActualizar.Intereses = new List<Categorias>();
                return;
            }
            var selectedCategoriasHS = new HashSet<string>(selectedCategorias);
            var personaCategorias = new HashSet<int>
                (personaActualizar.Intereses.Select(c => c.ID));
            foreach (var categorias in _context.Categorias)
            {
                if (selectedCategoriasHS.Contains(categorias.ID.ToString()))
                {
                    if (!personaCategorias.Contains(categorias.ID))
                    {
                        personaActualizar.Intereses.Add(categorias);
                    }
                }
                else
                {
                    if (personaCategorias.Contains(categorias.ID))
                    {
                        personaActualizar.Intereses.Remove(categorias);
                    }
                }
            }
        }
        // GET: Personas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var persona = await _context.Persona
                .SingleOrDefaultAsync(m => m.DNI == id);
            if (persona == null)
            {
                return NotFound();
            }

            return View(persona);
        }

        // POST: Personas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var persona = await _context.Persona.SingleOrDefaultAsync(m => m.DNI == id);
            _context.Persona.Remove(persona);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersonaExists(int id)
        {
            return _context.Persona.Any(e => e.DNI == id);
        }
    }
}
