using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bscitgroup.wwwroot.Global
{
	public class GlobalVars
	{
        //Lista de las categorias de cada curso o taller
        List<string> Categorias = new List<string>(new string[] { "Eduación","Hosting" });

        List<string> Paises = new List<string>(new string[] { "Perú" });

        List<string> Ciudades = new List<string>(new string[] { "Lima","Arequipa","Trujillo" });

        List<string> Profesiones = new List<string>(new string[] { "Docente Universitario,Docente Nivel Secundario" });

        List<string> Dias = new List<string>(new string[] {"Lunes", "Martes", "Miercoles", "Jueves", "Viernes",
        "Sábado","Domingo"});

        List<string> TipoServicio = new List<string>(new string[] {"Taller","Curso","Evento"});

        List<string> Modalidad = new List<string>(new string[] { "Presencial", "Online" });

        public GlobalVars()
        {
            //
        }

        //Agregar elementos a las listas
        void AddCategoria (string categoria)
        {
            Categorias.Add(categoria);
        }
        void AddPais(string pais)
        {
            Paises.Add(pais);
        }
        void AddCiudad(string ciudad)
        {
            Ciudades.Add(ciudad);
        }
        void AddProfesion(string profesion)
        {
            Profesiones.Add(profesion);
        }
        void AddTipoServicio(string tiposervicio)
        {
            TipoServicio.Add(tiposervicio);
        }
        void AddModalidad(string modalidad)
        {
            Modalidad.Add(modalidad);
        }

        //Get methods

        List<string> getCategorias()
        {
            return Categorias;
        }
        List<string> getPaises()
        {
            return Paises;
        }
        List<string> getCiudades()
        {
            return Ciudades;
        }
        List<string> getProfesiones()
        {
            return Profesiones;
        }
        List<string> getDias()
        {
            return Dias;
        }
        List<string> getTipoServicio()
        {
            return TipoServicio;
        }
        List<string> getModalidad()
        {
            return Modalidad;
        }

    }
}