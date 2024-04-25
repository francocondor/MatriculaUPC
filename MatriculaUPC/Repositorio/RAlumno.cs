using MatriculaUPC.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatriculaUPC.Repositorio
{
    internal class RAlumno
    {
        private List<CAlumno> listaAlumnos; 

        public RAlumno()
        {
            listaAlumnos = new List<CAlumno>();
        }

        public void AgregarAlumno(CAlumno alumno)
        {
            listaAlumnos.Add(alumno);
        }

        public List<CAlumno> ObtenerAlumnos()
        {
            return listaAlumnos;
        }

    }
}
