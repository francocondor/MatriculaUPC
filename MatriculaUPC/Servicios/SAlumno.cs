using MatriculaUPC.Entidades;
using MatriculaUPC.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatriculaUPC.Servicios
{
    internal class SAlumno
    {
        private RAlumno repositorioAlumno;

        public SAlumno()
        {
            repositorioAlumno = new RAlumno();
        }

        public void AgregarAlumno(String codigoAlumno, String nombreAlumno)
        {
            CAlumno alumno = new CAlumno(codigoAlumno, nombreAlumno);
            repositorioAlumno.AgregarAlumno(alumno);
        }

        public List<CAlumno> ObtenerAlumnos()
        {
            return repositorioAlumno.ObtenerAlumnos();
        }
    }
}
