namespace MatriculaUPC
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtCodigoCurso = new TextBox();
            txtNombreCurso = new TextBox();
            btnAgregarCurso = new Button();
            dgListaCursos = new DataGridView();
            dgListaAlumnos = new DataGridView();
            btnAgregarAlumno = new Button();
            txtNombreAlumno = new TextBox();
            txtCodigoAlumno = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btnInsertarAlumnoEnCurso = new Button();
            ((System.ComponentModel.ISupportInitialize)dgListaCursos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgListaAlumnos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 25);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 0;
            label1.Text = "Codigo Curso";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 66);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre Curso";
            // 
            // txtCodigoCurso
            // 
            txtCodigoCurso.Location = new Point(129, 25);
            txtCodigoCurso.Name = "txtCodigoCurso";
            txtCodigoCurso.Size = new Size(184, 23);
            txtCodigoCurso.TabIndex = 2;
            // 
            // txtNombreCurso
            // 
            txtNombreCurso.Location = new Point(129, 66);
            txtNombreCurso.Name = "txtNombreCurso";
            txtNombreCurso.Size = new Size(184, 23);
            txtNombreCurso.TabIndex = 3;
            // 
            // btnAgregarCurso
            // 
            btnAgregarCurso.Location = new Point(21, 111);
            btnAgregarCurso.Name = "btnAgregarCurso";
            btnAgregarCurso.Size = new Size(151, 23);
            btnAgregarCurso.TabIndex = 4;
            btnAgregarCurso.Text = "Agregar curso";
            btnAgregarCurso.UseVisualStyleBackColor = true;
            btnAgregarCurso.Click += btnAgregarCurso_Click;
            // 
            // dgListaCursos
            // 
            dgListaCursos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgListaCursos.Location = new Point(21, 165);
            dgListaCursos.Name = "dgListaCursos";
            dgListaCursos.Size = new Size(292, 219);
            dgListaCursos.TabIndex = 5;
            dgListaCursos.CellContentClick += dgListaCursos_CellContentClick;
            dgListaCursos.CellDoubleClick += dgListaCursos_CellDoubleClick;
            // 
            // dgListaAlumnos
            // 
            dgListaAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgListaAlumnos.Location = new Point(344, 165);
            dgListaAlumnos.Name = "dgListaAlumnos";
            dgListaAlumnos.Size = new Size(292, 219);
            dgListaAlumnos.TabIndex = 11;
            // 
            // btnAgregarAlumno
            // 
            btnAgregarAlumno.Location = new Point(344, 111);
            btnAgregarAlumno.Name = "btnAgregarAlumno";
            btnAgregarAlumno.Size = new Size(151, 23);
            btnAgregarAlumno.TabIndex = 10;
            btnAgregarAlumno.Text = "Agregar curso";
            btnAgregarAlumno.UseVisualStyleBackColor = true;
            btnAgregarAlumno.Click += btnAgregarAlumno_Click;
            // 
            // txtNombreAlumno
            // 
            txtNombreAlumno.Location = new Point(452, 66);
            txtNombreAlumno.Name = "txtNombreAlumno";
            txtNombreAlumno.Size = new Size(184, 23);
            txtNombreAlumno.TabIndex = 9;
            // 
            // txtCodigoAlumno
            // 
            txtCodigoAlumno.Location = new Point(452, 25);
            txtCodigoAlumno.Name = "txtCodigoAlumno";
            txtCodigoAlumno.Size = new Size(184, 23);
            txtCodigoAlumno.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(344, 66);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 7;
            label3.Text = "Nombre Alumno";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(344, 25);
            label4.Name = "label4";
            label4.Size = new Size(92, 15);
            label4.TabIndex = 6;
            label4.Text = "Codigo Alumno";
            // 
            // btnInsertarAlumnoEnCurso
            // 
            btnInsertarAlumnoEnCurso.Location = new Point(678, 111);
            btnInsertarAlumnoEnCurso.Name = "btnInsertarAlumnoEnCurso";
            btnInsertarAlumnoEnCurso.Size = new Size(237, 23);
            btnInsertarAlumnoEnCurso.TabIndex = 12;
            btnInsertarAlumnoEnCurso.Text = "Insertar Alumno En Curso";
            btnInsertarAlumnoEnCurso.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(976, 450);
            Controls.Add(btnInsertarAlumnoEnCurso);
            Controls.Add(dgListaAlumnos);
            Controls.Add(btnAgregarAlumno);
            Controls.Add(txtNombreAlumno);
            Controls.Add(txtCodigoAlumno);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(dgListaCursos);
            Controls.Add(btnAgregarCurso);
            Controls.Add(txtNombreCurso);
            Controls.Add(txtCodigoCurso);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Matricula UPC";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgListaCursos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgListaAlumnos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtCodigoCurso;
        private TextBox txtNombreCurso;
        private Button btnAgregarCurso;
        private DataGridView dgListaCursos;
        private DataGridView dgListaAlumnos;
        private Button btnAgregarAlumno;
        private TextBox txtNombreAlumno;
        private TextBox txtCodigoAlumno;
        private Label label3;
        private Label label4;
        private Button btnInsertarAlumnoEnCurso;
    }
}
