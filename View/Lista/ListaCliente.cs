using CrudAugustusFashion.Controller;
using CrudAugustusFashion.Dao;
using CrudAugustusFashion.Model.Pedido;
using System;
using System.Windows.Forms;

namespace CrudAugustusFashion.View
{
    public partial class FrmListaCliente : Form
    {
        public FrmListaCliente()
        {
            InitializeComponent();
        }

        private void frmListaCliente_Load(object sender, EventArgs e)
        {
        }

        private void dataGridViewListaClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnExibirCadastroCliente_Click(object sender, EventArgs e)
        {
            int idCliente = Convert.ToInt32(dataGridViewListaClientes.SelectedRows[0].Cells[0].Value);
            
             var cliente = new ClienteDao().RecuperarDadosCliente(idCliente);
            cliente.ValorConsumido = new ClienteDao().RecuperarValorGastoAPrazo(idCliente);

            new AlteracaoClienteController().AbrirAlteracaoCliente(cliente);
            this.Close();
        }

        private void btnFiltrarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewListaClientes.DataSource = new AlteracaoClienteController().
                    BuscarListaCliente((txtFiltrarCliente.Text), (CbAtivarClientes.Checked));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar usuario. Erro: " + ex.Message);
            }
        }
    }
}
