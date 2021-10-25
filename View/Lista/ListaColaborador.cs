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
            //dataGridViewColaboradores.DataSource = new ColaboradorDao().ListarColaboradores();
        }

        private void dataGrideViewColaboradores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
