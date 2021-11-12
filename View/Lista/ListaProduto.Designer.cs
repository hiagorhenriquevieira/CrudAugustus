
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
            this.btnExibirCadastroProduto = new System.Windows.Forms.Button();
            this.txtFiltrarProduto = new System.Windows.Forms.TextBox();
            this.btnFiltrarProduto = new System.Windows.Forms.Button();
            this.checkBoxListaProdutoAtivo = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewListaProduto
            // 
            this.dataGridViewListaProduto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewListaProduto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewListaProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListaProduto.Location = new System.Drawing.Point(19, 76);
            this.dataGridViewListaProduto.MultiSelect = false;
            this.dataGridViewListaProduto.Name = "dataGridViewListaProduto";
            this.dataGridViewListaProduto.ReadOnly = true;
            this.dataGridViewListaProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewListaProduto.Size = new System.Drawing.Size(833, 257);
            this.dataGridViewListaProduto.TabIndex = 0;
            this.dataGridViewListaProduto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridViewListaProduto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewListaProduto_CellDoubleClick);
            // 
            // labelListagemProdutos
            // 
            this.labelListagemProdutos.AutoSize = true;
            this.labelListagemProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListagemProdutos.Location = new System.Drawing.Point(2, 13);
            this.labelListagemProdutos.Name = "labelListagemProdutos";
            this.labelListagemProdutos.Size = new System.Drawing.Size(314, 39);
            this.labelListagemProdutos.TabIndex = 2;
            this.labelListagemProdutos.Text = "Lista de Produtos:";
            // 
            // btnExibirCadastroProduto
            // 
            this.btnExibirCadastroProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibirCadastroProduto.Location = new System.Drawing.Point(201, 345);
            this.btnExibirCadastroProduto.Name = "btnExibirCadastroProduto";
            this.btnExibirCadastroProduto.Size = new System.Drawing.Size(388, 55);
            this.btnExibirCadastroProduto.TabIndex = 22;
            this.btnExibirCadastroProduto.Text = "Exibir Produto";
            this.btnExibirCadastroProduto.UseVisualStyleBackColor = true;
            this.btnExibirCadastroProduto.Click += new System.EventHandler(this.btnExibirCadastroProduto_Click);
            // 
            // txtFiltrarProduto
            // 
            this.txtFiltrarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltrarProduto.Location = new System.Drawing.Point(309, 21);
            this.txtFiltrarProduto.Name = "txtFiltrarProduto";
            this.txtFiltrarProduto.Size = new System.Drawing.Size(204, 31);
            this.txtFiltrarProduto.TabIndex = 27;
            this.txtFiltrarProduto.TextChanged += new System.EventHandler(this.txtFiltrarProduto_TextChanged);
            // 
            // btnFiltrarProduto
            // 
            this.btnFiltrarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarProduto.Location = new System.Drawing.Point(519, 3);
            this.btnFiltrarProduto.Name = "btnFiltrarProduto";
            this.btnFiltrarProduto.Size = new System.Drawing.Size(101, 67);
            this.btnFiltrarProduto.TabIndex = 26;
            this.btnFiltrarProduto.Text = "Filtrar produto";
            this.btnFiltrarProduto.UseVisualStyleBackColor = true;
            this.btnFiltrarProduto.Click += new System.EventHandler(this.btnFiltrarProduto_Click);
            // 
            // checkBoxListaProdutoAtivo
            // 
            this.checkBoxListaProdutoAtivo.AutoSize = true;
            this.checkBoxListaProdutoAtivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxListaProdutoAtivo.Location = new System.Drawing.Point(655, 23);
            this.checkBoxListaProdutoAtivo.Name = "checkBoxListaProdutoAtivo";
            this.checkBoxListaProdutoAtivo.Size = new System.Drawing.Size(171, 28);
            this.checkBoxListaProdutoAtivo.TabIndex = 30;
            this.checkBoxListaProdutoAtivo.Text = "Produtos ativos";
            this.checkBoxListaProdutoAtivo.UseVisualStyleBackColor = true;
            this.checkBoxListaProdutoAtivo.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // FrmListaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 412);
            this.Controls.Add(this.checkBoxListaProdutoAtivo);
            this.Controls.Add(this.txtFiltrarProduto);
            this.Controls.Add(this.btnFiltrarProduto);
            this.Controls.Add(this.btnExibirCadastroProduto);
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
        private System.Windows.Forms.Button btnExibirCadastroProduto;
        private System.Windows.Forms.TextBox txtFiltrarProduto;
        private System.Windows.Forms.Button btnFiltrarProduto;
        private System.Windows.Forms.CheckBox checkBoxListaProdutoAtivo;
    }
}