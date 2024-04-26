using MatriculaUPC.Entidades;
using MatriculaUPC.Servicios;
using System.ComponentModel;
using System;

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
            List<CCurso> cursos = serviciosCurso.ObtenerCursos();
            BindingList<CCurso> bindingList = new BindingList<CCurso>(cursos);
            dgListaCursos.DataSource = null;
            dgListaCursos.DataSource = bindingList;
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

        private void dgListaCursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            // Comprueba si el índice de la fila es válido
            if (e.RowIndex >= 0)
            {
                //DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                //// Ahora puedes acceder a las celdas de la fila seleccionada
                //string value1 = row.Cells["NombreDeColumna1"].Value.ToString();
                //string value2 = row.Cells["NombreDeColumna2"].Value.ToString();

                //// Muestra los datos
                //MessageBox.Show("Valor 1: " + value1 + ", Valor 2: " + value2);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dgListaCursos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
