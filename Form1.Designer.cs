namespace ControlAsistencia
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
            chkPresente = new CheckBox();
            lstEstudiantes = new ListBox();
            btnGuardar = new Button();
            btnResumen = new Button();
            SuspendLayout();
            // 
            // chkPresente
            // 
            chkPresente.AutoSize = true;
            chkPresente.Location = new Point(248, 62);
            chkPresente.Name = "chkPresente";
            chkPresente.Size = new Size(71, 19);
            chkPresente.TabIndex = 0;
            chkPresente.Text = "Presente";
            chkPresente.UseVisualStyleBackColor = true;
            // 
            // lstEstudiantes
            // 
            lstEstudiantes.FormattingEnabled = true;
            lstEstudiantes.Location = new Point(35, 62);
            lstEstudiantes.Name = "lstEstudiantes";
            lstEstudiantes.Size = new Size(120, 94);
            lstEstudiantes.TabIndex = 1;
            lstEstudiantes.SelectedIndexChanged += lstEstudiantes_SelectedIndexChanged;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(437, 62);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnResumen
            // 
            btnResumen.Location = new Point(597, 71);
            btnResumen.Name = "btnResumen";
            btnResumen.Size = new Size(75, 23);
            btnResumen.TabIndex = 3;
            btnResumen.Text = "Ver Resumen";
            btnResumen.UseVisualStyleBackColor = true;
            btnResumen.Click += btnResumen_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnResumen);
            Controls.Add(btnGuardar);
            Controls.Add(lstEstudiantes);
            Controls.Add(chkPresente);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkPresente;
        private ListBox lstEstudiantes;
        private Button btnGuardar;
        private Button btnResumen;
    }
}
