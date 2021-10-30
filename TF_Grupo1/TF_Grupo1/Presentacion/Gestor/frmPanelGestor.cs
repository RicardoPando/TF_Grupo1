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
    public partial class frmPanelGestor : Form
    {
        public frmPanelGestor()
        {
            InitializeComponent();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            frmGestionarPlan FrmGestionarPlan = new frmGestionarPlan();
            FrmGestionarPlan.ShowDialog();
            //frmRegistrarClienteForm = new frmRegistrarCliente();
            //frmRegistrarClienteForm.ShowDialog();
        }
    }
}
