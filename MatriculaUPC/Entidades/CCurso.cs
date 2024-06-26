﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatriculaUPC.Entidades
{
    internal class CCurso
    {
        public String CodigoCurso { get; set; }
        public String NombreCurso { get; set; }

        public List<CAlumno> EstudiantesMatriculados { get; set; }

        public CCurso(String codigoCurso, String nombreCurso)
        {
            CodigoCurso = codigoCurso;
            NombreCurso = nombreCurso;
            EstudiantesMatriculados = new List<CAlumno>();
        }

    }
}
