using MatriculaUPC.Entidades;
using MatriculaUPC.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatriculaUPC.Servicios
{
    internal class SCurso
    {
        private RCurso repositorioCurso;
        private RAlumno repositorioAlumno;

        public SCurso()
        {
            repositorioCurso = new RCurso();
            repositorioAlumno = new RAlumno();
        }

        public void AgregarCurso(String codigoCurso, String nombreCurso)
        {
            CCurso curso = new CCurso(codigoCurso, nombreCurso);
            repositorioCurso.AgregarCurso(curso);
        }

        public List<CCurso> ObtenerCursos()
        {
            return repositorioCurso.ObtenerCursos();
        }

        public void MatricularAlumno(String codigoCurso, String codigoAlumno)
        {
            CCurso curso = repositorioCurso.ObtenerCursoPorCodigo(codigoCurso);
            CAlumno alumno = repositorioAlumno.ObtenerAlumnoPorCodigo(codigoAlumno);
            if (curso != null && alumno != null)
            {
                curso.EstudiantesMatriculados.Add(alumno);
            }
            
        }
    }
}
