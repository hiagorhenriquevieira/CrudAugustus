using CrudAugustusFashion.Dao;
using CrudAugustusFashion.Controller;
using CrudAugustusFashion.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CrudAugustusFashion.View
{
    public partial class FrmListaColaborador : Form
    {
        public FrmListaColaborador()
        {
            InitializeComponent();
        }

        private void FrmListaColaborador_Load(object sender, EventArgs e)
        {

        }

        private void btnExibirCadastroColaborador_Click(object sender, EventArgs e)
        {
            var colaboradores = dataGrideViewColaboradores.SelectedRows.Count;
            if (colaboradores == 0)
                return;
            int idColaborador = Convert.ToInt32(dataGrideViewColaboradores.SelectedRows[0].Cells[0].Value);

            var colaborador = new ColaboradorDao().RecuperarDadosColaborador(idColaborador);

            new AlteracaoColaboradorController().AbrirAlteracaoColaboradores(colaborador);
            this.Close();
        }

        private void btnFiltrarColaborador_Click(object sender, EventArgs e)
        {
            try
            {
                dataGrideViewColaboradores.DataSource = new AlteracaoColaboradorController().BuscarListaColaborador((txtFiltrarColaborador.Text), (CbColaboradoresAtivos.Checked));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar colaborador. Erro:" + ex.Message);
            }
        }
    }
}
