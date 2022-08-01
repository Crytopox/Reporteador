namespace Reporteador_CR
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnReporteadorNomina = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReporteadorVacaciones = new System.Windows.Forms.Button();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReporteadorNomina
            // 
            this.btnReporteadorNomina.BackColor = System.Drawing.Color.SkyBlue;
            this.btnReporteadorNomina.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReporteadorNomina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteadorNomina.Location = new System.Drawing.Point(19, 69);
            this.btnReporteadorNomina.Margin = new System.Windows.Forms.Padding(2);
            this.btnReporteadorNomina.Name = "btnReporteadorNomina";
            this.btnReporteadorNomina.Size = new System.Drawing.Size(178, 54);
            this.btnReporteadorNomina.TabIndex = 0;
            this.btnReporteadorNomina.Text = "Reporteador Nomina";
            this.btnReporteadorNomina.UseVisualStyleBackColor = false;
            this.btnReporteadorNomina.Click += new System.EventHandler(this.btnReporteadorNomina_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelTitulo);
            this.panel1.Controls.Add(this.btnReporteadorNomina);
            this.panel1.Controls.Add(this.btnReporteadorVacaciones);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(447, 168);
            this.panel1.TabIndex = 1;
            // 
            // btnReporteadorVacaciones
            // 
            this.btnReporteadorVacaciones.BackColor = System.Drawing.Color.SkyBlue;
            this.btnReporteadorVacaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReporteadorVacaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteadorVacaciones.Location = new System.Drawing.Point(235, 69);
            this.btnReporteadorVacaciones.Margin = new System.Windows.Forms.Padding(2);
            this.btnReporteadorVacaciones.Name = "btnReporteadorVacaciones";
            this.btnReporteadorVacaciones.Size = new System.Drawing.Size(178, 54);
            this.btnReporteadorVacaciones.TabIndex = 1;
            this.btnReporteadorVacaciones.Text = "Reporteador Vacaciones";
            this.btnReporteadorVacaciones.UseVisualStyleBackColor = false;
            this.btnReporteadorVacaciones.Click += new System.EventHandler(this.btnReporteadorVacaciones_Click);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(91, 15);
            this.labelTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(242, 37);
            this.labelTitulo.TabIndex = 2;
            this.labelTitulo.Text = "Menu Principal";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(447, 168);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MenuPrincipal";
            this.Text = "Menu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReporteadorNomina;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Button btnReporteadorVacaciones;
    }
}