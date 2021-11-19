using CrudAugustusFashion.Controller.PedidoController;
using CrudAugustusFashion.Dao;
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
        private ListagemPedidoController _listagemPedido;

        public FrmPedidoLista()
        {
            InitializeComponent();
            _listagemPedido = new ListagemPedidoController();
        }
        private void PedidoLista_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSelecionarItemListaPedido_Click(object sender, EventArgs e)
        {
            
        }

        private void btnFiltrarPedidoProduto_Click(object sender, EventArgs e)
        {
            try
            {
                //_listagemPedido.ListarPedidosRealizados(dataGridViewPedidoLista);
                dataGridViewPedidoLista.DataSource = new VendaDao().ListarPedidosCadastrados();
            }
            catch (Exception excecao)
            {
                MessageBox.Show("Erro ao listar pedidos." + excecao.Message);
            }
        }
    }
}
