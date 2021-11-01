using CrudAugustusFashion.Controller;
using CrudAugustusFashion.Dao;
using CrudAugustusFashion.Model;
using CrudAugustusFashion.View.Alteracao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            try
            {
                dataGridViewListaClientes.DataSource = new ClienteDao().ListarClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao listar clientes. Erro " + ex.Message);
            }
        }

        private void dataGridViewListaClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             
        }

        private void btnExibirCadastroCliente_Click(object sender, EventArgs e)
        {
            int idCliente = Convert.ToInt32(dataGridViewListaClientes.SelectedRows[0].Cells[0].Value);

            var cliente = new ClienteDao().RecuperarDadosCliente(idCliente);

           new AlteracaoClienteController().AbrirAlteracaoCliente(cliente);
            this.Close();
        }
    }
}
