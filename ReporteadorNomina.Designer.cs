
namespace Reporteador_CR
{
    partial class ReporteadorNomina
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.comboBoxTipoNomina = new System.Windows.Forms.ComboBox();
            this.comboBoxPeriodoNomina = new System.Windows.Forms.ComboBox();
            this.comboBoxPeriodoID = new System.Windows.Forms.ComboBox();
            this.comboBoxYear = new System.Windows.Forms.ComboBox();
            this.labelOption4 = new System.Windows.Forms.Label();
            this.labelOption3 = new System.Windows.Forms.Label();
            this.labelOption2 = new System.Windows.Forms.Label();
            this.labelOption1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxSelecionReporte = new System.Windows.Forms.ComboBox();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CrystalReport_NominaAbierta1 = new Reporteador_CR.CrystalReport_NominaAbierta();
            this.dataSetDefault1 = new Reporteador_CR.DataSetDefault();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDefault1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Controls.Add(this.labelError);
            this.panel1.Controls.Add(this.comboBoxTipoNomina);
            this.panel1.Controls.Add(this.comboBoxPeriodoNomina);
            this.panel1.Controls.Add(this.comboBoxPeriodoID);
            this.panel1.Controls.Add(this.comboBoxYear);
            this.panel1.Controls.Add(this.labelOption4);
            this.panel1.Controls.Add(this.labelOption3);
            this.panel1.Controls.Add(this.labelOption2);
            this.panel1.Controls.Add(this.labelOption1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnReporte);
            this.panel1.Controls.Add(this.btnSelect);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbxSelecionReporte);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1484, 911);
            this.panel1.TabIndex = 0;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.Window;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(124, 138);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(95, 35);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // labelError
            // 
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(18, 432);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(209, 131);
            this.labelError.TabIndex = 2;
            this.labelError.Text = "Error";
            this.labelError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxTipoNomina
            // 
            this.comboBoxTipoNomina.FormattingEnabled = true;
            this.comboBoxTipoNomina.Location = new System.Drawing.Point(21, 378);
            this.comboBoxTipoNomina.Name = "comboBoxTipoNomina";
            this.comboBoxTipoNomina.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipoNomina.TabIndex = 18;
            // 
            // comboBoxPeriodoNomina
            // 
            this.comboBoxPeriodoNomina.FormattingEnabled = true;
            this.comboBoxPeriodoNomina.Location = new System.Drawing.Point(21, 335);
            this.comboBoxPeriodoNomina.Name = "comboBoxPeriodoNomina";
            this.comboBoxPeriodoNomina.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPeriodoNomina.TabIndex = 17;
            // 
            // comboBoxPeriodoID
            // 
            this.comboBoxPeriodoID.FormattingEnabled = true;
            this.comboBoxPeriodoID.Location = new System.Drawing.Point(21, 290);
            this.comboBoxPeriodoID.Name = "comboBoxPeriodoID";
            this.comboBoxPeriodoID.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPeriodoID.TabIndex = 16;
            // 
            // comboBoxYear
            // 
            this.comboBoxYear.FormattingEnabled = true;
            this.comboBoxYear.Location = new System.Drawing.Point(21, 235);
            this.comboBoxYear.Name = "comboBoxYear";
            this.comboBoxYear.Size = new System.Drawing.Size(121, 21);
            this.comboBoxYear.TabIndex = 3;
            // 
            // labelOption4
            // 
            this.labelOption4.AutoSize = true;
            this.labelOption4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOption4.Location = new System.Drawing.Point(17, 359);
            this.labelOption4.Name = "labelOption4";
            this.labelOption4.Size = new System.Drawing.Size(44, 16);
            this.labelOption4.TabIndex = 12;
            this.labelOption4.Text = "label3";
            // 
            // labelOption3
            // 
            this.labelOption3.AutoSize = true;
            this.labelOption3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOption3.Location = new System.Drawing.Point(17, 314);
            this.labelOption3.Name = "labelOption3";
            this.labelOption3.Size = new System.Drawing.Size(44, 16);
            this.labelOption3.TabIndex = 10;
            this.labelOption3.Text = "label3";
            // 
            // labelOption2
            // 
            this.labelOption2.AutoSize = true;
            this.labelOption2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOption2.Location = new System.Drawing.Point(17, 268);
            this.labelOption2.Name = "labelOption2";
            this.labelOption2.Size = new System.Drawing.Size(44, 16);
            this.labelOption2.TabIndex = 8;
            this.labelOption2.Text = "label3";
            // 
            // labelOption1
            // 
            this.labelOption1.AutoSize = true;
            this.labelOption1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOption1.Location = new System.Drawing.Point(17, 216);
            this.labelOption1.Name = "labelOption1";
            this.labelOption1.Size = new System.Drawing.Size(44, 16);
            this.labelOption1.TabIndex = 6;
            this.labelOption1.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Seleciona los campos a filtrar:";
            // 
            // btnReporte
            // 
            this.btnReporte.BackColor = System.Drawing.SystemColors.Window;
            this.btnReporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.Location = new System.Drawing.Point(20, 138);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(95, 35);
            this.btnReporte.TabIndex = 3;
            this.btnReporte.Text = "Generar Reporte";
            this.btnReporte.UseVisualStyleBackColor = false;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.SystemColors.Window;
            this.btnSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Location = new System.Drawing.Point(62, 83);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(121, 36);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "Selecionar";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleciona  el reporte que deseas generar: ";
            // 
            // cbxSelecionReporte
            // 
            this.cbxSelecionReporte.BackColor = System.Drawing.SystemColors.Window;
            this.cbxSelecionReporte.FormattingEnabled = true;
            this.cbxSelecionReporte.Location = new System.Drawing.Point(20, 56);
            this.cbxSelecionReporte.Name = "cbxSelecionReporte";
            this.cbxSelecionReporte.Size = new System.Drawing.Size(207, 21);
            this.cbxSelecionReporte.TabIndex = 0;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.AutoSize = true;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.CrystalReport_NominaAbierta1;
            this.crystalReportViewer1.ShowCloseButton = false;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1198, 909);
            this.crystalReportViewer1.TabIndex = 1;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crystalReportViewer1.UseWaitCursor = true;
            // 
            // dataSetDefault1
            // 
            this.dataSetDefault1.DataSetName = "DataSetDefault";
            this.dataSetDefault1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.crystalReportViewer1);
            this.panel2.Location = new System.Drawing.Point(286, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1198, 909);
            this.panel2.TabIndex = 2;
            // 
            // ReporteadorNomina
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1484, 911);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1500, 950);
            this.Name = "ReporteadorNomina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporteador";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDefault1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxSelecionReporte;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label labelOption1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Label labelOption4;
        private System.Windows.Forms.Label labelOption3;
        private System.Windows.Forms.Label labelOption2;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label labelError;
        private CrystalReport_NominaAbierta CrystalReport_NominaAbierta1;
        private System.Windows.Forms.ComboBox comboBoxYear;
        private System.Windows.Forms.ComboBox comboBoxTipoNomina;
        private System.Windows.Forms.ComboBox comboBoxPeriodoNomina;
        private System.Windows.Forms.ComboBox comboBoxPeriodoID;
        private DataSetDefault dataSetDefault1;
        private System.Windows.Forms.Panel panel2;
    }
}

