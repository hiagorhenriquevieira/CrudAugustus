using CrudAugustusFashion.Controller.PedidoController;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudAugustusFashion.View.Lista
{
    public partial class FrmPedidoLista : Form
    {
        public FrmPedidoLista()
        {
            InitializeComponent();
        }
        private void PedidoLista_Load(object sender, EventArgs e)
        {
            //dataGridViewPedidoLista.DataSource = new CadastroPedidoController().ListarProdutosParaVenda();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridViewPedidoLista.DataSource = new CadastroPedidoController().ListarProdutosParaVenda(txtPedido.Text);
        }
    }
}
