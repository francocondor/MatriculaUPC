using MatriculaUPC.Servicios;

namespace MatriculaUPC
{
    public partial class Form1 : Form
    {
        private SCurso serviciosCurso;
        private SAlumno serviciosAlumno;

        public Form1()
        {
            InitializeComponent();
            serviciosCurso = new SCurso();
            ActualizarListaCursos();
            serviciosAlumno = new SAlumno();
            ActualizarListaAlumnos();
        }

        private void btnAgregarCurso_Click(object sender, EventArgs e)
        {
            String codigoCurso = txtCodigoCurso.Text;
            String nombreCurso = txtNombreCurso.Text;

            serviciosCurso.AgregarCurso(codigoCurso, nombreCurso);

            txtCodigoCurso.Clear();
            txtNombreCurso.Clear();

            ActualizarListaCursos();
        }

        private void ActualizarListaCursos()
        {
            dgListaCursos.DataSource = null;
            var cursos = serviciosCurso.ObtenerCursos();
            dgListaCursos.DataSource = cursos;

        }

        private void btnAgregarAlumno_Click(object sender, EventArgs e)
        {
            String codigoAlumno = txtCodigoAlumno.Text;
            String nombreAlumno = txtNombreAlumno.Text;

            serviciosAlumno.AgregarAlumno(codigoAlumno, nombreAlumno);

            txtCodigoAlumno.Clear();
            txtNombreAlumno.Clear();

            ActualizarListaAlumnos();
        }
        private void ActualizarListaAlumnos()
        {
            dgListaAlumnos.DataSource = null;
            var alumnos = serviciosAlumno.ObtenerAlumnos();
            dgListaAlumnos.DataSource = alumnos;
        }
    }
}
