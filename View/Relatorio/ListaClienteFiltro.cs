using CrudAugustusFashion.Controller;
using CrudAugustusFashion.Controller.RelatorioFiltroController;
using CrudAugustusFashion.Dao;
using CrudAugustusFashion.Model.Cliente;
using System;
using System.Windows.Forms;

namespace CrudAugustusFashion.View.Relatorio
{
    public partial class FrmListaClienteParaFiltro : Form
    {
        private ClienteModel _clienteModel;
        private RelatorioVendaController _relatorioVendaController;

        public FrmListaClienteParaFiltro(RelatorioVendaController relatorioVendaController)
        {
            InitializeComponent();
            _clienteModel = new ClienteModel();           
            _relatorioVendaController = relatorioVendaController;
        }

        public void RetornarCliente()
        {
            _relatorioVendaController.ReceberCliente(_clienteModel);
        }

        private void FrmListaClienteParaFiltro_Load(object sender, EventArgs e)
        {
            dtgVisualizarCliente.DataSource = new AlteracaoClienteController().BuscarListaCliente(txtFiltrarPorNome.Text, (_clienteModel.Ativo = true));
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            dtgVisualizarCliente.DataSource = new AlteracaoClienteController().BuscarListaCliente(txtFiltrarPorNome.Text, (_clienteModel.Ativo = true));
        }

        private void dtgVisualizarCliente_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
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
