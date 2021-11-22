using CrudAugustusFashion.Model.Venda;
using System;
using System.Windows.Forms;

namespace CrudAugustusFashion.View.Lista
{
    public partial class FrmListaVenda : Form
    {
        private VendaConsulta _vendaConsulta;

        public FrmListaVenda()
        {
            InitializeComponent();
            _vendaConsulta = new VendaConsulta();
        }

        private void ListaVenda_Load(object sender, EventArgs e)
        {
            PreencherCamposComDadosDaVenda();
        }

        public void PreencherCamposComDadosDaVenda()
        {
            lblNomeCliente.Text = _vendaConsulta.NomeCliente.ToString();
            lblNomeFornecedor.Text = _vendaConsulta.NomeColaborador.ToString();     
        }

        private void btnExibirItemListaPedido_Click(object sender, EventArgs e)
        {
            
        }

        
    }
}
