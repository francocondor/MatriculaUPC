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
        private RCurso repositorio;

        public SCurso()
        {
            repositorio = new RCurso();
        }

        public void AgregarCurso(String codigoCurso, String nombreCurso)
        {
            CCurso curso = new CCurso(codigoCurso, nombreCurso);
            repositorio.AgregarCurso(curso);
        }

        public List<CCurso> ObtenerCursos()
        {
            return repositorio.ObtenerCursos();
        }
    }
}
