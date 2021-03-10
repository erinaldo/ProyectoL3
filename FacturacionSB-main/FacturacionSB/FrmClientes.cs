using BLFacturacionSB;
using System;
using System.Windows.Forms;

namespace FacturacionSB
{
    public partial class FrmClientes : Form
    {
        ClientesBL _clientes;


        public FrmClientes()
        {
            InitializeComponent();

            _clientes = new ClientesBL();
            listaClienteBindingSource.DataSource = _clientes.ObtenerClientes();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {
            
            
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void bindingNavigator1_RefreshItems_1(object sender, EventArgs e)
        {

        }

        private void listaClienteDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listaClienteBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void telefonoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void telefonoLabel_Click(object sender, EventArgs e)
        {

        }

        private void emailLabel_Click(object sender, EventArgs e)
        {

        }

        private void emailTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void listaClienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaClienteBindingSource.EndEdit();
            var Cliente = (Cliente)listaClienteBindingSource.Current;

            var resultado = _clientes.GuardarCliente(Cliente);

            if (resultado == true)
            {
                listaClienteBindingSource.ResetBindings(false);
                MessageBox.Show("Cliente Guardado");
            }
            else
            {
                MessageBox.Show("Ocurrio un error al guardar este registro.");
            }
        }

        private void listaClienteBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _clientes.AgregarCliente();
            listaClienteBindingSource.MoveLast();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text != "")
            {
                var id = Convert.ToInt32(idTextBox.Text);
                var resultado = _clientes.EliminarCliente(id);

                if (resultado == true)
                {
                    listaClienteBindingSource.ResetBindings(false);
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al eliminar este registro.");
                }
            }
        }
    }
}
