using System;
using System.Windows.Forms;

namespace Reporteador_CR
{
    public partial class ReporteadorNomina : Form
    {
        public class ComboBoxItems
        {
            public string Text { get; set; }
            public int Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        DataSetDefault dataSet = new DataSetDefault();
        //DataSets para los Crystal Reports
        DataSetDefaultTableAdapters.NominaAbiertaTableAdapter adapterNominaAbierta = new DataSetDefaultTableAdapters.NominaAbiertaTableAdapter();
        DataSetDefaultTableAdapters.NominaCerradaTableAdapter adapterNominaCerrada = new DataSetDefaultTableAdapters.NominaCerradaTableAdapter();
        //DataSets para ComboBoxes
        DataSetDefaultTableAdapters.NomCalculoAnoTableAdapter adapterNomCalculoAno = new DataSetDefaultTableAdapters.NomCalculoAnoTableAdapter();
        DataSetDefaultTableAdapters.NomCalculoPerIDTableAdapter adapterNomCalculoPerID = new DataSetDefaultTableAdapters.NomCalculoPerIDTableAdapter();
        DataSetDefaultTableAdapters.NomCalculoTipoNomTableAdapter adapterNomCalculoTipoNom = new DataSetDefaultTableAdapters.NomCalculoTipoNomTableAdapter();
        DataSetDefaultTableAdapters.NomCalculoPeriodoTableAdapter adapterNomCalculoPeriodo = new DataSetDefaultTableAdapters.NomCalculoPeriodoTableAdapter();
        //
        DataSetDefaultTableAdapters.NomCalculoHAnoTableAdapter adapterNomCalculoHAno = new DataSetDefaultTableAdapters.NomCalculoHAnoTableAdapter();
        DataSetDefaultTableAdapters.NomCalculoHPerIDTableAdapter adapterNomCalculoHPerID = new DataSetDefaultTableAdapters.NomCalculoHPerIDTableAdapter();
        DataSetDefaultTableAdapters.NomCalculoHTipoNomTableAdapter adapterNomCalculoHTipoNom = new DataSetDefaultTableAdapters.NomCalculoHTipoNomTableAdapter();
        DataSetDefaultTableAdapters.NomCalculoHPeriodoTableAdapter adapterNomCalculoHPeriodo = new DataSetDefaultTableAdapters.NomCalculoHPeriodoTableAdapter();
        public ReporteadorNomina()
        {
            InitializeComponent();
            //Crear items para los tipos de Reporte
            cbxSelecionReporte.Items.Add("Nomina Abierta");
            cbxSelecionReporte.Items.Add("Nomina Cerrada");

            //No mostrar los campos de filtrado al iniciar el programa
            labelOption1.Hide();
            comboBoxYear.Hide();
            labelOption2.Hide();
            comboBoxPeriodoID.Hide();
            labelOption3.Hide();
            comboBoxPeriodoNomina.Hide();
            labelOption4.Hide();
            comboBoxTipoNomina.Hide();
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

            //Limpiar los combo box antes de introducir nuevos datos.
            comboBoxYear.Items.Clear();
            comboBoxPeriodoID.Items.Clear();
            comboBoxPeriodoNomina.Items.Clear();
            comboBoxTipoNomina.Items.Clear();

            #region Nomina-Abierta
            //Nomina Abierta
            //Mostrar las opciones correspondientes para el Reporte
            if (cbxSelecionReporte.Text == "Nomina Abierta")
            {
                labelOption1.Text = "Año";
                labelOption1.Show();
                comboBoxYear.Show();

                labelOption2.Text = "Periodo ID";
                labelOption2.Show();
                comboBoxPeriodoID.Show();

                labelOption3.Text = "Periodo Nomina";
                labelOption3.Show();
                comboBoxPeriodoNomina.Show();

                labelOption4.Text = "Tipo Nomina";
                labelOption4.Show();
                comboBoxTipoNomina.Show();

                //Llenar los campos para los combo box
                try
                {
                    ComboBoxItems item = new ComboBoxItems();
                    //Llenar campos para el combo box (Año)
                    adapterNomCalculoAno.Fill(dataSet.NomCalculoAno);
                    for (int i = 0; i < dataSet.NomCalculoAno.Rows.Count; i++)
                    {
                        comboBoxYear.Items.Add(dataSet.NomCalculoAno[i].Ano);
                    }

                    //Llenar campos para el combo box (Periodo ID)
                    adapterNomCalculoPerID.Fill(dataSet.NomCalculoPerID);
                    for (int i = 0; i < dataSet.NomCalculoPerID.Rows.Count; i++)
                    {
                        /*item.Text = dataSet.NomCalculoPerID[i].Periodo_ID.ToString();
                        item.Value = dataSet.NomCalculoPerID[i].Periodo_ID;
                        comboBoxPeriodoID.Items.Add(item);*/
                        comboBoxPeriodoID.Items.Add(dataSet.NomCalculoPerID[i].Periodo_ID);
                    }

                    //Llenar campos para el combo box (Periodo Nomina)
                    adapterNomCalculoPeriodo.Fill(dataSet.NomCalculoPeriodo);
                    for (int i = 0; i < dataSet.NomCalculoPeriodo.Rows.Count; i++)
                    {
                        /*item.Text = dataSet.NomCalculoPeriodo[i].Periodo + " - ASDASDASDAS" ;
                        item.Value = dataSet.NomCalculoPeriodo[i].Periodo;
                        comboBoxPeriodoNomina.Items.Add(item);*/
                        comboBoxPeriodoNomina.Items.Add(dataSet.NomCalculoPeriodo[i].Periodo);
                    }

                    //Llenar campos para el combo box (Tipo Nomina)
                    adapterNomCalculoTipoNom.Fill(dataSet.NomCalculoTipoNom);
                    for (int i = 0; i < dataSet.NomCalculoTipoNom.Rows.Count; i++)
                    {
                        /*item.Text = dataSet.NomCalculoTipoNom[i].TipoNomina_ID + " - ";
                        item.Value = dataSet.NomCalculoTipoNom[i].TipoNomina_ID;
                        comboBoxTipoNomina.Items.Add(item);*/
                        comboBoxTipoNomina.Items.Add(dataSet.NomCalculoTipoNom[i].TipoNomina_ID);
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
            //Nomina Cerrada
            //Mostrar las opciones correspondientes para el Reporte
            if (cbxSelecionReporte.Text == "Nomina Cerrada")
            {
                labelOption1.Text = "Año";
                labelOption1.Show();
                comboBoxYear.Show();

                labelOption2.Text = "Periodo ID";
                labelOption2.Show();
                comboBoxPeriodoID.Show();

                labelOption3.Text = "Periodo Nomina";
                labelOption3.Show();
                comboBoxPeriodoNomina.Show();

                labelOption4.Text = "Tipo Nomina";
                labelOption4.Show();
                comboBoxTipoNomina.Show();

                //Llenar los campos para los combo box
                try
                {
                    ComboBoxItems item = new ComboBoxItems();
                    //Llenar campos para el combo box (Año)
                    adapterNomCalculoHAno.Fill(dataSet.NomCalculoHAno);
                    for (int i = 0; i < dataSet.NomCalculoHAno.Rows.Count; i++)
                    {
                        comboBoxYear.Items.Add(dataSet.NomCalculoHAno[i].Ano);
                    }

                    //Llenar campos para el combo box (Periodo ID)
                    adapterNomCalculoHPerID.Fill(dataSet.NomCalculoHPerID);
                    for (int i = 0; i < dataSet.NomCalculoHPerID.Rows.Count; i++)
                    {
                        /*item.Text = dataSet.NomCalculoPerID[i].Periodo_ID.ToString();
                        item.Value = dataSet.NomCalculoPerID[i].Periodo_ID;
                        comboBoxPeriodoID.Items.Add(item);*/
                        comboBoxPeriodoID.Items.Add(dataSet.NomCalculoHPerID[i].Periodo_ID);
                    }

                    //Llenar campos para el combo box (Periodo Nomina)
                    adapterNomCalculoHPeriodo.Fill(dataSet.NomCalculoHPeriodo);
                    for (int i = 0; i < dataSet.NomCalculoHPeriodo.Rows.Count; i++)
                    {
                        /*item.Text = dataSet.NomCalculoPeriodo[i].Periodo + " - ASDASDASDAS" ;
                        item.Value = dataSet.NomCalculoPeriodo[i].Periodo;
                        comboBoxPeriodoNomina.Items.Add(item);*/
                        comboBoxPeriodoNomina.Items.Add(dataSet.NomCalculoHPeriodo[i].Periodo);
                    }

                    //Llenar campos para el combo box (Tipo Nomina)
                    adapterNomCalculoHTipoNom.Fill(dataSet.NomCalculoHTipoNom);
                    for (int i = 0; i < dataSet.NomCalculoHTipoNom.Rows.Count; i++)
                    {
                        /*item.Text = dataSet.NomCalculoTipoNom[i].TipoNomina_ID + " - ";
                        item.Value = dataSet.NomCalculoTipoNom[i].TipoNomina_ID;
                        comboBoxTipoNomina.Items.Add(item);*/
                        comboBoxTipoNomina.Items.Add(dataSet.NomCalculoHTipoNom[i].TipoNomina_ID);
                    }

                }
                catch (Exception ex)
                {
                    labelError.Text = ex.Message;
                    labelError.Show();
                }
            }
            #endregion Nomina-Cerrada
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            CrystalReport_NominaAbierta crNominaAbierta = new CrystalReport_NominaAbierta();
            CrystalReport_NominaCerrada crNominaCerrada = new CrystalReport_NominaCerrada();
            labelError.Hide();
            try
            {
                string dir = "";
                int year = 0;
                int periodoID = 0;
                int periodoNomina = 0;
                int tipoNomina = 0;
                #region Generar NominaAbierta
                if (cbxSelecionReporte.Text == "Nomina Abierta")
                {
                    dir = @"~\CrystalReport-NominaAbierta.rpt";
                    
                    //Asignar Variables selecionadas de los ComboBox
                    if (comboBoxYear.SelectedItem != null)
                    {
                        year = Convert.ToInt32(comboBoxYear.SelectedItem);
                    }
                    else
                    {
                        year = 0;
                    }

                    if(comboBoxPeriodoID.SelectedItem != null)
                    {
                        //periodoID = Convert.ToInt16((comboBoxPeriodoID.SelectedItem as ComboBoxItems).Value);
                        periodoID = Convert.ToSByte(comboBoxPeriodoID.SelectedItem);
                    }
                    else
                    {
                        periodoID = 0;
                    }

                    if (comboBoxPeriodoNomina.SelectedItem != null)
                    {
                        //periodoNomina = Convert.ToInt32((comboBoxPeriodoNomina.SelectedItem as ComboBoxItems).Value);
                        periodoNomina = Convert.ToInt32(comboBoxPeriodoNomina.SelectedItem);
                    }
                    else
                    {
                        periodoNomina = 0;
                    }

                    if (comboBoxTipoNomina.SelectedItem != null)
                    {
                        //tipoNomina = Convert.ToInt32((comboBoxTipoNomina.SelectedItem as ComboBoxItems).Value);
                        tipoNomina = Convert.ToInt32(comboBoxTipoNomina.SelectedItem);
                    }
                    else
                    {
                        tipoNomina = 0;
                    }
                    //Pasar las variables selecionadas de los ComboBox al adaptador de NominaAbierta.
                    //Ejecuta la query SQL y filta los datos con los campos proporcionados.
                    adapterNominaAbierta.Fill(dataSet.NominaAbierta,
                        Convert.ToInt16(year),
                        Convert.ToByte(periodoID),
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
                    dir = @"~\CrystalReport-NominaCerrada.rpt";

                    //Asignar Variables selecionadas de los ComboBox
                    if (comboBoxYear.SelectedItem != null)
                    {
                        year = Convert.ToInt32(comboBoxYear.SelectedItem);
                    }
                    else
                    {
                        year = 0;
                    }
                    if (comboBoxPeriodoID.SelectedItem != null)
                    {
                        //periodoID = Convert.ToInt16((comboBoxPeriodoID.SelectedItem as ComboBoxItems).Value);
                        periodoID = Convert.ToSByte(comboBoxPeriodoID.SelectedItem);
                    }
                    else
                    {
                        periodoID = 0;
                    }
                    if (comboBoxPeriodoNomina.SelectedItem != null)
                    {
                        //periodoNomina = Convert.ToInt32((comboBoxPeriodoNomina.SelectedItem as ComboBoxItems).Value);
                        periodoNomina = Convert.ToInt32(comboBoxPeriodoNomina.SelectedItem);
                    }
                    else
                    {
                        periodoNomina = 0;
                    }
                    if (comboBoxTipoNomina.SelectedItem != null)
                    {
                        //tipoNomina = Convert.ToInt32((comboBoxTipoNomina.SelectedItem as ComboBoxItems).Value);
                        tipoNomina = Convert.ToInt32(comboBoxTipoNomina.SelectedItem);
                    }
                    else
                    {
                        tipoNomina = 0;
                    }
                    //Pasar las variables selecionadas de los ComboBox al adaptador de NominaAbierta.
                    //Ejecuta la query SQL y filta los datos con los campos proporcionados.
                    adapterNominaCerrada.Fill(dataSet.NominaCerrada,
                        Convert.ToInt16(year),
                        Convert.ToByte(periodoID),
                        Convert.ToInt16(periodoNomina),
                        Convert.ToByte(tipoNomina)
                        );

                    //Generar y mostrar el Report CrystalReport
                    crNominaCerrada.Load(dir);
                    crNominaCerrada.SetDataSource(dataSet);
                    crystalReportViewer1.ReportSource = crNominaCerrada;
                    crystalReportViewer1.RefreshReport();
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
            comboBoxYear.ResetText();
            comboBoxYear.SelectedItem = null;
            comboBoxPeriodoID.ResetText();
            comboBoxPeriodoID.SelectedItem = null;
            comboBoxPeriodoNomina.ResetText();
            comboBoxPeriodoNomina.SelectedItem = null;
            comboBoxTipoNomina.ResetText();
            comboBoxTipoNomina.SelectedItem = null;
            //Descargar el reporte actual del ReportViewer
            crystalReportViewer1.ReportSource = null;
            crystalReportViewer1.RefreshReport();
        }
    }
}
