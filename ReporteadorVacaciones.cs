using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Reporteador_CR.DataSets;

namespace Reporteador_CR
{
    public partial class ReporteadorVacaciones : Form
    {
        DataSetVacaciones dataSetVac = new DataSetVacaciones();
        //DataSets para los Crystal Reports
        DataSets.DataSetVacacionesTableAdapters.VacacionesTableAdapter adapterVacaciones = new DataSets.DataSetVacacionesTableAdapters.VacacionesTableAdapter();
        //DataSets para los ComboBoxes
        DataSets.DataSetVacacionesTableAdapters.VacacionesAñoTableAdapter adapterVacacionesAño = new DataSets.DataSetVacacionesTableAdapters.VacacionesAñoTableAdapter();
        DataSets.DataSetVacacionesTableAdapters.VacacionesMesTableAdapter adapterVacacionesMes = new DataSets.DataSetVacacionesTableAdapters.VacacionesMesTableAdapter();
        DataSets.DataSetVacacionesTableAdapters.VacacionesTrabIDTableAdapter adapterVacacionesTrabID = new DataSets.DataSetVacacionesTableAdapters.VacacionesTrabIDTableAdapter();
        DataSets.DataSetVacacionesTableAdapters.VacacionesTipoSolicitudTableAdapter adapterVacacionesTipoSolicitud = new DataSets.DataSetVacacionesTableAdapters.VacacionesTipoSolicitudTableAdapter();
        public ReporteadorVacaciones()
        {
            InitializeComponent();
            labelError.Hide();
            //Limpiar contenido de los ComboBoxes
            cbxAño.Items.Clear();
            cbxMes.Items.Clear();
            cbxTrabajador.Items.Clear();
            cbxTipoSolicitud.Items.Clear();

            //Inicializar el contenido de los ComboBoxes
            try
            {
                //ComboBox Año
                adapterVacacionesAño.Fill(dataSetVac.VacacionesAño);
                for (int i = 0; i < dataSetVac.VacacionesAño.Rows.Count; i++)
                {
                    cbxAño.Items.Add(dataSetVac.VacacionesAño[i].Año);
                }
                //ComboBox Mes
                adapterVacacionesMes.Fill(dataSetVac.VacacionesMes);
                for(int i = 0; i < dataSetVac.VacacionesMes.Rows.Count; i++)
                {
                    cbxMes.Items.Add(dataSetVac.VacacionesMes[i].Mes);
                }

                //ComboBox TrabajadorID
                Dictionary<string, string> cbxData = new Dictionary<string, string>();
                adapterVacacionesTrabID.Fill(dataSetVac.VacacionesTrabID);
                for(int i = 0; i < dataSetVac.VacacionesTrabID.Rows.Count; i++)
                {
                    string id = dataSetVac.VacacionesTrabID[i].TrabID;
                    string name = id + " - " + dataSetVac.VacacionesTrabID[i].TrabID;
                    cbxData.Add(id, name);
                    //OLD
                    //cbxTrabajador.Items.Add(dataSetVac.VacacionesTrabID[i].TrabID);
                }
                cbxTrabajador.DataSource = new BindingSource(cbxData, null);
                cbxTrabajador.DisplayMember = "Value";
                cbxTrabajador.ValueMember = "Key";

                //ComboBox TipoSolicitud
                adapterVacacionesTipoSolicitud.Fill(dataSetVac.VacacionesTipoSolicitud);
                for(int i = 0; i < dataSetVac.VacacionesTipoSolicitud.Rows.Count; i++)
                {
                    cbxTipoSolicitud.Items.Add(dataSetVac.VacacionesTipoSolicitud[i].TipoSolicitud);
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
            //Limpiar ComboBoxes
            cbxAño.ResetText();
            cbxAño.SelectedItem = null;
            cbxMes.ResetText();
            cbxMes.SelectedItem = null;
            cbxTrabajador.ResetText();
            cbxTrabajador.SelectedItem = null;
            cbxTipoSolicitud.ResetText();
            cbxTipoSolicitud.SelectedItem = null;

            //Descargar reporte
            crystalReportViewer1.ReportSource = null;
            crystalReportViewer1.RefreshReport();

            //Limpiar mensaje de error
            labelError.Hide();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            CrystalReports.CrystalReport_Vacaciones crVacaciones = new CrystalReports.CrystalReport_Vacaciones();
            try
            {
                //Variables para generar Reporte
                string dir = @"~\CrystalReports\CrystalReport-Vacaciones.rpt"; ;
                int año = 0;
                int mes = 0;
                string trabID = "";
                string tipoSolicitud = "";

                //Asignar valor de los ComboBox selecionados
                //ComboxBox Año
                if (cbxAño.SelectedItem != null)
                {
                    año = Convert.ToInt32(cbxAño.SelectedItem);
                }
                else
                {
                    año = 0;
                }
                //ComboBox Mes
                if(cbxMes.SelectedItem != null)
                {
                    mes = Convert.ToInt32(cbxMes.SelectedItem);
                }
                else
                {
                    mes = 0;
                }
                //ComboBox TrabID
                if(cbxTrabajador.SelectedItem != null)
                {
                    trabID = ((KeyValuePair<string, string>)cbxTrabajador.SelectedItem).Key;
                }
                else
                {
                    trabID = "0";
                }
                //ComboBox TipoSolicitud
                if(cbxTipoSolicitud.SelectedItem != null)
                {
                    tipoSolicitud = Convert.ToString(cbxTipoSolicitud.SelectedItem);
                }
                else
                {
                    tipoSolicitud = "";
                }
                //Pasar las variables selecionadas de los ComboBox al adaptador de Vacaciones.
                //Ejecuta la query SQL y filta los datos con los campos proporcionados.
                adapterVacaciones.Fill(dataSetVac.Vacaciones,
                    año,
                    mes,
                    trabID,
                    tipoSolicitud
                    );

                //Generar y mostrar el Report CrystalReport
                crVacaciones.Load(dir);
                crVacaciones.SetDataSource(dataSetVac);
                crystalReportViewer1.ReportSource = crVacaciones;
                crystalReportViewer1.RefreshReport();

            }
            catch(Exception ex)
            {
                labelError.Text = ex.Message;
                //labelError.Show();
            }
        }
    }
}
