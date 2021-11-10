using CrudAugustusFashion.Controller;
using CrudAugustusFashion.Controller.ProdutoController;
using CrudAugustusFashion.View.Alteracao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudAugustusFashion.View
{
    public partial class MdiParentPrincipal : Form
    {
        private int childFormNumber = 0;
        private CadastroColaboradorController _cadastroColaboradorController;
        private CadastroClienteController _cadastroClienteController;
        private CadastroProdutoController _cadastroProdutoController;

        public MdiParentPrincipal()
        {
            InitializeComponent();
            _cadastroColaboradorController = new CadastroColaboradorController();
            _cadastroClienteController = new CadastroClienteController();
            _cadastroProdutoController = new CadastroProdutoController();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Janela " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void MDIParent1_Load(object sender, EventArgs e)
        {

        }

        private void colaboradorToolStripMenuItem_Click(object sender, EventArgs e) => _cadastroColaboradorController.AbrirCadastroColaborador();

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e) => _cadastroClienteController.AbrirCadastroCliente();

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e) => _cadastroClienteController.AbrirListaCliente();

        private void colaboradorToolStripMenuItem1_Click(object sender, EventArgs e) => _cadastroColaboradorController.AbrirListaColaborador();
        private void produtoToolStripMenuItem_Click(object sender, EventArgs e) => _cadastroProdutoController.AbrirCadastroProduto();

        private void cadastrarNovoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        
    }
}
