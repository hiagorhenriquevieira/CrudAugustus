using CrudAugustusFashion.Controller.ContasController;
using CrudAugustusFashion.Model.ContasAReceberModel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CrudAugustusFashion.View.ContasAReceber
{
    public partial class FrmListaDeContasAReceber : Form
    {
        private ContasAReceberController _contasAReceberController;

        public FrmListaDeContasAReceber()
        {
            InitializeComponent();
            _contasAReceberController = new ContasAReceberController();
            
        }

        private void ListaDeContasAReceber_Load(object sender, EventArgs e)
        {

        }

        private void btnFiltrarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                var lista = _contasAReceberController.ListarComprasAPrazo(txtFiltrarCliente.Text, CbContasPendentes.Checked);
                dataGridViewConsulta.DataSource = lista;
                ChecarSeFiltroEstaEmContasPagas(lista);
            }
            catch (Exception excecao)
            {
                MessageBox.Show("Erro ao carregar lista de contas pendentes!" + excecao.Message);
            }
        }
        public bool ChecarSeFiltroEstaEmContasPagas(List<ListaDeContasAReceberModel> lista)
        {
            if (CbContasPendentes.Checked == Convert.ToBoolean(0))
            {
                return btnPagarConta.Visible = false;
            }
            else
                return btnPagarConta.Visible = true;
        }

        public bool ChecarSeTemContaSelecionadaParaPagar(List<ListaDeContasAReceberModel> lista)
        {
            if(lista.Count == 0)
            {
                return false;
            }
            return true;
        }
        private void btnPagarConta_Click(object sender, EventArgs e)
        {
            try
            {
                var count = dataGridViewConsulta.SelectedRows.Count;
                if (count == 0)
                {
                    MessageBox.Show("Nenhuma conta foi selecionada");
                    return; 
                }
                DialogResult OpcaoDoUsuario = new DialogResult();
                OpcaoDoUsuario = MessageBox.Show("Você está prestes a pagar uma conta, deseja continuar? ", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(OpcaoDoUsuario == DialogResult.Yes)
                {

                var idVenda = Convert.ToInt32(dataGridViewConsulta.SelectedRows[0].Cells[0].Value);
                
                new ContasAReceberController().PagarContaAPrazo(idVenda);
                MessageBox.Show("A conta foi paga");
                var lista = _contasAReceberController.ListarComprasAPrazo(txtFiltrarCliente.Text, CbContasPendentes.Checked);
                dataGridViewConsulta.DataSource = lista;
                }
            }
            catch (Exception excecao)
            {
                MessageBox.Show("Erro ao pagar conta." + excecao.Message);
            }
        }
    }
}
