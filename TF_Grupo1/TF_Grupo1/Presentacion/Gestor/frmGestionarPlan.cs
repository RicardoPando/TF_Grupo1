using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TF_Grupo1.Presentacion.Gestor
{
    public partial class frmGestionarPlan : Form
    {
        public frmGestionarPlan()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            frmPanelGestor FrmPanelGestor = new frmPanelGestor();
            FrmPanelGestor.ShowDialog();
        }

        private void btnCrearNuevo_Click(object sender, EventArgs e)
        {
            frmPanelGestor FrmPanelGestor = new frmPanelGestor();
            FrmPanelGestor.ShowDialog();
        }
    }
}
