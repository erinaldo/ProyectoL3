using System;
using System.Windows.Forms;

namespace FacturacionSB
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            Login();

        }

        private void Login()
        {
             var frmLogin = new FrmLogin();
             frmLogin.ShowDialog(); 

        }

        private void loginToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void cotizacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmCotizaciones = new FrmCotizacion();
            frmCotizaciones.MdiParent = this;
            frmCotizaciones.Show();
        }

        private void facturacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmFacturacion = new FrmFacturacion();
            frmFacturacion.MdiParent = this;
            frmFacturacion.Show();
        }

        private void facturasAlCreditoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmFctCredito = new FrmFctCredito();
            frmFctCredito.MdiParent = this;
            frmFctCredito.Show();
        }

        private void facturacionMensualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmFctMensual = new FrmFactMensual();
            frmFctMensual.MdiParent = this;
            frmFctMensual.Show();
        }

        
        private void agregarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void crearCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void crearUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void razonSocialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmEmpresa = new FrmEmpresa();
            frmEmpresa.MdiParent = this;
            frmEmpresa.Show();
        }

        private void agregarClientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var frmClientes = new FrmClientes();
            frmClientes.MdiParent = this;
            frmClientes.Show();
        }

        private void rangoDeFacturacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmCAI = new FrmCAI();
            frmCAI.MdiParent = this;
            frmCAI.Show();
        }

        private void iSVToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
    }

