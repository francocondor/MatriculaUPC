using MatriculaUPC.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatriculaUPC.Repositorio
{
    internal class RCurso
    {
        // repository class

        private List<CCurso> listaCursos;

        public RCurso()
        {
            listaCursos = new List<CCurso>();
        }

        public void AgregarCurso(CCurso curso)
        {
            listaCursos.Add(curso);
        }

        public List<CCurso> ObtenerCursos()
        {
            return listaCursos;
        }
    }
}
