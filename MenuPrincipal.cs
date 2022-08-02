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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnReporteadorNomina_Click(object sender, EventArgs e)
        {
            ReporteadorNomina reporteadorNomina = new ReporteadorNomina();
            reporteadorNomina.Show();
        }

        private void btnReporteadorVacaciones_Click(object sender, EventArgs e)
        {
            ReporteadorVacaciones reporteadorVacaciones = new ReporteadorVacaciones();
            reporteadorVacaciones.Show();
        }
    }
}
