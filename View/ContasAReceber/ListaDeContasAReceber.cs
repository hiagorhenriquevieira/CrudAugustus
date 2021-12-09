﻿using CrudAugustusFashion.Controller.ContasController;
using System;
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
            }
            catch (Exception excecao)
            {
                MessageBox.Show("Erro ao carregar lista de contas pendentes!" + excecao.Message);
            }
        }

        private void btnPagarConta_Click(object sender, EventArgs e)
        {
            try
            {
                var idVenda = Convert.ToInt32(dataGridViewConsulta.SelectedRows[0].Cells[0].Value);
                new ContasAReceberController().PagarContaAPrazo(idVenda);
                MessageBox.Show("A conta foi paga");
                var lista = _contasAReceberController.ListarComprasAPrazo(txtFiltrarCliente.Text, CbContasPendentes.Checked);
                dataGridViewConsulta.DataSource = lista;
            }
            catch (Exception excecao)
            {
                MessageBox.Show("Erro ao pagar conta." + excecao.Message);
            }
        }
    }
}