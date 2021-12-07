using CrudAugustusFashion.Controller;
using CrudAugustusFashion.Controller.RelatorioFiltroController;
using CrudAugustusFashion.Dao;
using CrudAugustusFashion.Model.Cliente;
using System;
using System.Windows.Forms;

namespace CrudAugustusFashion.View.Relatorio
{
    public partial class FrmListaClientesFiltro : Form
    {
        private ClienteModel _clienteModel;
        private ClienteDao _clienteDao;
        private RelatorioClienteController _relatorioClienteController;
        public FrmListaClientesFiltro(RelatorioClienteController relatorioClienteController)
        {
            InitializeComponent();
            _clienteModel = new ClienteModel();
            _relatorioClienteController = relatorioClienteController;
        }

        public void RetornarCliente()
        {
            _relatorioClienteController.ReceberCliente(_clienteModel);
        }

        private void btnFiltrar_Click(object sender, System.EventArgs e)
        {
            dtgVisualizarCliente.DataSource = new AlteracaoClienteController().BuscarListaCliente(txtFiltrarPorNome.Text, (_clienteModel.Ativo = true));
        }

        private void dtgVisualizarCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var idCliente = Convert.ToInt32(dtgVisualizarCliente.SelectedRows[0].Cells[0].Value);
            var cliente = new ClienteDao().RecuperarDadosCliente(idCliente);
            _clienteModel.IdCliente = cliente.IdCliente;
            _clienteModel.NomeCompleto = cliente.NomeCompleto;
            RetornarCliente();
            this.Close();
        }
    }
}
