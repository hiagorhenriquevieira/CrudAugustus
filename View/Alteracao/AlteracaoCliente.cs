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
using CrudAugustusFashion.Controller;
using CrudAugustusFashion.Model;
using CrudAugustusFashion.Extencion;

namespace CrudAugustusFashion.View.Alteracao
{
    public partial class FrmAlteracaoCliente : Form
    {
        public FrmAlteracaoCliente( )
        {
            InitializeComponent();
        }

        private void FrmAlteracaoCliente_Load(object sender, EventArgs e)
        {
            new ClienteDao().ListarClientes();
           

        }
    }
}
