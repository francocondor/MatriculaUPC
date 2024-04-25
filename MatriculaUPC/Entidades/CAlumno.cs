using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatriculaUPC.Entidades
{
    internal class CAlumno
    {
        public String CodigoAlumno { get; set; }
        public String NombreAlumno { get; set; }

        public CAlumno(String codigoAlumno, String nombreAlumndo)
        {
            CodigoAlumno = codigoAlumno;
            NombreAlumno = nombreAlumndo;
        }
    }
}
