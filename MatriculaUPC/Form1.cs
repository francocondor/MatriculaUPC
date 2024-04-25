using MatriculaUPC.Servicios;

namespace MatriculaUPC
{
    public partial class Form1 : Form
    {
        private SCurso serviciosCurso;

        public Form1()
        {
            InitializeComponent();
            serviciosCurso = new SCurso();
            ActualizarListaCursos();
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
    }
}
