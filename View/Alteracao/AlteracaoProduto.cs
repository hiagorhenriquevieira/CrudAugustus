using CrudAugustusFashion.Model.Produto;
using System.Windows.Forms;

namespace CrudAugustusFashion.View.Alteracao
{
    public partial class FrmAlteracaoProduto : Form
    {
        private ProdutoModel _produto;

        public FrmAlteracaoProduto(ProdutoModel produto)
        {
            _produto = produto;
            InitializeComponent();
            PreencherCamposComDadosProduto();
        }

        public void PreencherCamposComDadosProduto()
        {
            txtCodigoBarras.Text = _produto.CodigoDeBarras;
            txtNomeProduto.Text = _produto.Nome;
            txtNomeFabricante.Text = _produto.Fabricante;
            txtEstoque.Text = _produto.QuantidadeEstoque.ToString();
            txtPrecoCusto.Text = _produto.PrecoCusto.ToString();
            txtPrecoVenda.Text = _produto.PrecoVenda.ToString();
            txtPorcentagemLucro.Text = _produto.Lucro.ToString();
        }
    }
}
