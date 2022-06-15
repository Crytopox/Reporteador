using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//https://stackoverflow.com/questions/23386078/how-to-remove-conditions-from-where-clause-if-parameters-are-null SQL NULL PARAMS / KEKW
//https://www.tutorialgateway.org/sql-query-to-select-all-if-parameter-is-empty-or-null/ <- Use this first (:

namespace Reporteador_CR
{
    public partial class ReporteadorNomina : Form
    {
        public class ComboBoxItems
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        DataSetDefault dataSet = new DataSetDefault();
        //DataSets para los Crystal Reports
        DataSetDefaultTableAdapters.NominaAbiertaTableAdapter adapterNominaAbierta = new DataSetDefaultTableAdapters.NominaAbiertaTableAdapter();
        //DataSets para ComboBoxes
        DataSetDefaultTableAdapters.NomCalculoAnoTableAdapter adapterNomCalculoAno = new DataSetDefaultTableAdapters.NomCalculoAnoTableAdapter();
        DataSetDefaultTableAdapters.NomCalculoPerIDTableAdapter adapterNomCalculoPerID = new DataSetDefaultTableAdapters.NomCalculoPerIDTableAdapter();
        DataSetDefaultTableAdapters.NomCalculoTipoNomTableAdapter adapterNomCalculoTipoNom = new DataSetDefaultTableAdapters.NomCalculoTipoNomTableAdapter();
        DataSetDefaultTableAdapters.NomCalculoPeriodoTableAdapter adapterNomCalculoPeriodo = new DataSetDefaultTableAdapters.NomCalculoPeriodoTableAdapter();
        public ReporteadorNomina()
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
            //Desplegar el siguente menu de opciones.
            btnReporte.Show();
            btnLimpiar.Show();
            label2.Show();

        #region Nomina-Abierta
            //Nomina Abierta
            //Mostrar las opciones correspondientes para el Reporte
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
                    ComboBoxItems item = new ComboBoxItems();
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
                        item.Text = dataSet.NomCalculoPerID[i].Periodo_ID + " - " + dataSet.NomCalculoPerID[i].Descripcion;
                        item.Value = dataSet.NomCalculoPerID[i].Periodo_ID;
                        comboBoxOption2.Items.Add(item);
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
        #endregion Nomina-Abierta

        #region Nomina-Cerrada

        #endregion Nomina-Cerrada
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            try
            {
                CrystalReport_NominaAbierta crNominaAbierta = new CrystalReport_NominaAbierta();
                string dir = "";

            #region Generar NominaAbierta
                if (cbxSelecionReporte.Text == "Nomina Abierta")
                {
                    dir = @"~\CrystalReport-NominaAbierta.rpt";

                    //Asignar Variables selecionadas de los ComboBox
                    object year             = (comboBoxOption1.SelectedItem);
                    string periodoID        = (comboBoxOption2.SelectedItem as ComboBoxItems).Value.ToString();
                    string periodoNomina    = (comboBoxOption3.SelectedItem as ComboBoxItems).Value.ToString();
                    string tipoNomina       = (comboBoxOption4.SelectedItem as ComboBoxItems).Value.ToString();

                    //Pasar las variables selecionadas de los ComboBox al adaptador de NominaAbierta.
                    //Ejecuta la query SQL y filta los datos con los campos proporcionados.
                    adapterNominaAbierta.Fill(dataSet.NominaAbierta,
                        Convert.ToInt16(year),
                        Convert.ToInt16(periodoID),
                        Convert.ToInt16(periodoNomina),
                        Convert.ToByte(tipoNomina)
                        );

                    //Generar y mostrar el Report CrystalReport
                    crNominaAbierta.Load(dir);
                    crNominaAbierta.SetDataSource(dataSet);
                    crystalReportViewer1.ReportSource = crNominaAbierta;
                    crystalReportViewer1.RefreshReport();
                }
            #endregion Generar NominaAbierta

            #region Generar NominaCerrada
                else if (cbxSelecionReporte.Text == "Nomina Cerrada")
                {

                }
            #endregion Generar NominaCerrada

                else
                {
                    labelError.Text = "Seleciona el tipo de nomina que deseas generar!";
                    labelError.Show();
                }
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
