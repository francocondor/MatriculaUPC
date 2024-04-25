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
            ((System.ComponentModel.ISupportInitialize)dgListaCursos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 22);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 0;
            label1.Text = "Codigo Curso";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 63);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre Curso";
            // 
            // txtCodigoCurso
            // 
            txtCodigoCurso.Location = new Point(136, 22);
            txtCodigoCurso.Name = "txtCodigoCurso";
            txtCodigoCurso.Size = new Size(184, 23);
            txtCodigoCurso.TabIndex = 2;
            // 
            // txtNombreCurso
            // 
            txtNombreCurso.Location = new Point(136, 63);
            txtNombreCurso.Name = "txtNombreCurso";
            txtNombreCurso.Size = new Size(184, 23);
            txtNombreCurso.TabIndex = 3;
            // 
            // btnAgregarCurso
            // 
            btnAgregarCurso.Location = new Point(28, 108);
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
            dgListaCursos.Location = new Point(28, 162);
            dgListaCursos.Name = "dgListaCursos";
            dgListaCursos.Size = new Size(292, 219);
            dgListaCursos.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgListaCursos);
            Controls.Add(btnAgregarCurso);
            Controls.Add(txtNombreCurso);
            Controls.Add(txtCodigoCurso);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Matricula UPC";
            ((System.ComponentModel.ISupportInitialize)dgListaCursos).EndInit();
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
    }
}
