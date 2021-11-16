using CrudAugustusFashion.Controller.PedidoController;
using CrudAugustusFashion.View.Lista;
using System.Windows.Forms;

namespace CrudAugustusFashion.View.Cadastro
{
    public partial class FrmCadastroPedido : Form
    {
        public FrmCadastroPedido()
        {
            InitializeComponent();
        }

        private void btnPesquisarProduto_Click(object sender, System.EventArgs e)
        {
            new CadastroPedidoController().AbrirListaParaVenda();
            
        }
    }
}