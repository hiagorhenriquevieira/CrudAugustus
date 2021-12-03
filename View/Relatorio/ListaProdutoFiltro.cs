using CrudAugustusFashion.Controller.ProdutoController;
using CrudAugustusFashion.Controller.RelatorioFiltroController;
using CrudAugustusFashion.Dao;
using CrudAugustusFashion.Model.Produto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudAugustusFashion.View.Relatorio
{
    public partial class FrmListaProdutoFiltro : Form
    {
        
        private RelatorioVendaController _relatorioVendaController;
        private ProdutoModel _produtoModel;

        public FrmListaProdutoFiltro(RelatorioVendaController relatorioVendaController)
        {
            _relatorioVendaController = relatorioVendaController;
            _produtoModel = new ProdutoModel();
            InitializeComponent();
        }

        private void ListaProdutoFiltro_Load(object sender, EventArgs e)
        {
            dtgVisualizarProduto.DataSource = new ProdutoDao().BuscarListaProduto(txtFiltrarPorProduto.Text, (_produtoModel.Ativo = true));
        }
        public void RetornarProduto()
        {
            _relatorioVendaController.ReceberProduto(_produtoModel);
        }

        private void dtgVisualizarProduto_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var idProduto = Convert.ToInt32(dtgVisualizarProduto.SelectedRows[0].Cells[0].Value);
            var produto = new ProdutoDao().RecuperarDadosProduto(idProduto);
            _produtoModel.IdProduto = produto.IdProduto;
            _produtoModel.Nome = produto.Nome;
            RetornarProduto();
            this.Close();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            dtgVisualizarProduto.DataSource = new ProdutoDao().BuscarListaProduto(txtFiltrarPorProduto.Text, (_produtoModel.Ativo = true));
        }
    }
}
