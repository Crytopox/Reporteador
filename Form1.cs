using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reporteador_CR
{
    public partial class Form1 : Form
    {
        DataSetDefault dataSet = new DataSetDefault();
        DataSetDefaultTableAdapters.NominaAbiertaTableAdapter adapterNominaAbierta = new DataSetDefaultTableAdapters.NominaAbiertaTableAdapter();
        DataSetDefaultTableAdapters.NomCalculoAnoTableAdapter adapterNomCalculoAno = new DataSetDefaultTableAdapters.NomCalculoAnoTableAdapter();
        DataSetDefaultTableAdapters.NomCalculoPerIDTableAdapter adapterNomCalculoPerID = new DataSetDefaultTableAdapters.NomCalculoPerIDTableAdapter();
        DataSetDefaultTableAdapters.NomCalculoTipoNomTableAdapter adapterNomCalculoTipoNom = new DataSetDefaultTableAdapters.NomCalculoTipoNomTableAdapter();
        DataSetDefaultTableAdapters.NomCalculoPeriodoTableAdapter adapterNomCalculoPeriodo = new DataSetDefaultTableAdapters.NomCalculoPeriodoTableAdapter();
        public Form1()
        {
            InitializeComponent();
            //Crear items para los tipos de Reporte
            cbxSelecionReporte.Items.Add("Nomina Abierta");
            cbxSelecionReporte.Items.Add("Nomina Cerrada");

            //No mostrar los campos de filtrado al iniciar el programa
            labelOption1.Hide();
            comboBoxOption1.Hide();
            labelOption2.Hide();
            comboBoxOption2.Hide();
            labelOption3.Hide();
            comboBoxOption3.Hide();
            labelOption4.Hide();
            comboBoxOption4.Hide();
            labelOption5.Hide();
            comboBoxOption5.Hide();
            btnReporte.Hide();
            btnLimpiar.Hide();
            label2.Hide();
            labelError.Hide();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            btnReporte.Show();
            btnLimpiar.Show();
            label2.Show();
            //Mostrar las opciones correspondientes para el Reporte - Nomina Abierta
            if (cbxSelecionReporte.Text == "Nomina Abierta")
            {
                labelOption1.Text = "Año";
                labelOption1.Show();
                comboBoxOption1.Show();

                labelOption2.Text = "Periodo ID";
                labelOption2.Show();
                comboBoxOption2.Show();

                labelOption3.Text = "Periodo Nomina";
                labelOption3.Show();
                comboBoxOption3.Show();

                labelOption4.Text = "Tipo Nomina";
                labelOption4.Show();
                comboBoxOption4.Show();

                //Llenar los campos para los combo box
                try
                {
                    //Llenar campos para el combo box (Año)
                    adapterNomCalculoAno.Fill(dataSet.NomCalculoAno);
                    for (int i = 0; i < dataSet.NomCalculoAno.Rows.Count; i++)
                    {
                        comboBoxOption1.Items.Add(dataSet.NomCalculoAno[i].Ano);
                    }

                    //Llenar campos para el combo box (Periodo ID)
                    adapterNomCalculoPerID.Fill(dataSet.NomCalculoPerID);
                    for (int i = 0; i < dataSet.NomCalculoPerID.Rows.Count; i++)
                    {
                        comboBoxOption2.Items.Add(dataSet.NomCalculoPerID[i].Periodo_ID);
                    }

                    //Llenar campos para el combo box (Periodo Nomina)
                    adapterNomCalculoPeriodo.Fill(dataSet.NomCalculoPeriodo);
                    for (int i = 0; i < dataSet.NomCalculoPeriodo.Rows.Count; i++)
                    {
                        comboBoxOption3.Items.Add(dataSet.NomCalculoPeriodo[i].Periodo);
                    }

                    //Llenar campos para el combo box (Tipo Nomina)
                    adapterNomCalculoTipoNom.Fill(dataSet.NomCalculoTipoNom);
                    for (int i = 0; i < dataSet.NomCalculoTipoNom.Rows.Count; i++)
                    {
                        comboBoxOption4.Items.Add(dataSet.NomCalculoTipoNom[i].TipoNomina_ID);
                    }

                }
                catch (Exception ex)
                {
                    labelError.Text = ex.Message;
                    labelError.Show();
                }


            }
        }

        

        private void btnReporte_Click(object sender, EventArgs e)
        {
            try
            {
                CrystalReport_NominaAbierta crNominaAbierta = new CrystalReport_NominaAbierta();
                string dir = "";

                if (cbxSelecionReporte.Text == "Nomina Abierta")
                {
                    dir = @"~\CrystalReport-NominaAbierta.rpt";
                    //adapterNominaAbierta.Fill(dataSet.NominaAbierta, *, *);
                    /*adapterNominaAbierta.Fill(dataSet.NominaAbierta, 
                        Convert.ToInt16(comboBoxOption1.SelectedItem), 
                        Convert.ToByte(comboBoxOption3.SelectedItem));*/


                }

                crNominaAbierta.Load(dir);
                crNominaAbierta.SetDataSource(dataSet);
                crystalReportViewer1.ReportSource = crNominaAbierta;
                crystalReportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                labelError.Text = ex.Message;
                labelError.Show();
            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            comboBoxOption1.ResetText();
            comboBoxOption2.ResetText();
            comboBoxOption3.ResetText();
            comboBoxOption4.ResetText();
            comboBoxOption5.ResetText();
        }
    }
}
