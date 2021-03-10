using BLFacturacionSB;
using System;
using System.Windows.Forms;

namespace FacturacionSB
{
    public partial class FrmLogin : Form
    {
        SeguridadBL _seguridad;
        public FrmLogin()
        {
            InitializeComponent();

            _seguridad = new SeguridadBL();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string usuario;
            string contrasena;

            usuario = textBox1.Text;
            contrasena = textBox2.Text;

            var resultado = _seguridad.Acceder(usuario, contrasena);



            if(resultado == true)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o contrasdeña invalidos");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
