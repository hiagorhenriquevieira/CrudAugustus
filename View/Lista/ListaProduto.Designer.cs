
namespace CrudAugustusFashion.View.Lista
{
    partial class FrmListaProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewListaProduto = new System.Windows.Forms.DataGridView();
            this.labelListagemProdutos = new System.Windows.Forms.Label();
            this.btnExibirCadastroCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewListaProduto
            // 
            this.dataGridViewListaProduto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewListaProduto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewListaProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListaProduto.Location = new System.Drawing.Point(19, 60);
            this.dataGridViewListaProduto.MultiSelect = false;
            this.dataGridViewListaProduto.Name = "dataGridViewListaProduto";
            this.dataGridViewListaProduto.ReadOnly = true;
            this.dataGridViewListaProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewListaProduto.Size = new System.Drawing.Size(754, 257);
            this.dataGridViewListaProduto.TabIndex = 0;
            this.dataGridViewListaProduto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridViewListaProduto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewListaProduto_CellDoubleClick);
            // 
            // labelListagemProdutos
            // 
            this.labelListagemProdutos.AutoSize = true;
            this.labelListagemProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListagemProdutos.Location = new System.Drawing.Point(12, 18);
            this.labelListagemProdutos.Name = "labelListagemProdutos";
            this.labelListagemProdutos.Size = new System.Drawing.Size(314, 39);
            this.labelListagemProdutos.TabIndex = 2;
            this.labelListagemProdutos.Text = "Lista de Produtos:";
            // 
            // btnExibirCadastroCliente
            // 
            this.btnExibirCadastroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibirCadastroCliente.Location = new System.Drawing.Point(165, 350);
            this.btnExibirCadastroCliente.Name = "btnExibirCadastroCliente";
            this.btnExibirCadastroCliente.Size = new System.Drawing.Size(388, 55);
            this.btnExibirCadastroCliente.TabIndex = 22;
            this.btnExibirCadastroCliente.Text = "Exibir Produto";
            this.btnExibirCadastroCliente.UseVisualStyleBackColor = true;
            this.btnExibirCadastroCliente.Click += new System.EventHandler(this.btnExibirCadastroCliente_Click);
            // 
            // FrmListaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExibirCadastroCliente);
            this.Controls.Add(this.labelListagemProdutos);
            this.Controls.Add(this.dataGridViewListaProduto);
            this.Name = "FrmListaProduto";
            this.Text = "Lista Produto";
            this.Load += new System.EventHandler(this.FrmListaProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewListaProduto;
        private System.Windows.Forms.Label labelListagemProdutos;
        private System.Windows.Forms.Button btnExibirCadastroCliente;
    }
}