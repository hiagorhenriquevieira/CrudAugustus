
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
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewListaProduto
            // 
            this.dataGridViewListaProduto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewListaProduto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewListaProduto.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewListaProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListaProduto.Location = new System.Drawing.Point(74, 232);
            this.dataGridViewListaProduto.MultiSelect = false;
            this.dataGridViewListaProduto.Name = "dataGridViewListaProduto";
            this.dataGridViewListaProduto.ReadOnly = true;
            this.dataGridViewListaProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewListaProduto.Size = new System.Drawing.Size(853, 322);
            this.dataGridViewListaProduto.TabIndex = 0;
            this.dataGridViewListaProduto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewListaProduto_CellDoubleClick);
            // 
            // labelListagemProdutos
            // 
            this.labelListagemProdutos.AutoSize = true;
            this.labelListagemProdutos.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListagemProdutos.Location = new System.Drawing.Point(343, 60);
            this.labelListagemProdutos.Name = "labelListagemProdutos";
            this.labelListagemProdutos.Size = new System.Drawing.Size(236, 35);
            this.labelListagemProdutos.TabIndex = 2;
            this.labelListagemProdutos.Text = "Lista de Produtos";
            // 
            // btnExibirCadastroProduto
            // 
            this.btnExibirCadastroProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.btnExibirCadastroProduto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExibirCadastroProduto.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibirCadastroProduto.Location = new System.Drawing.Point(74, 607);
            this.btnExibirCadastroProduto.Name = "btnExibirCadastroProduto";
            this.btnExibirCadastroProduto.Size = new System.Drawing.Size(204, 35);
            this.btnExibirCadastroProduto.TabIndex = 22;
            this.btnExibirCadastroProduto.Text = "Exibir Produto";
            this.btnExibirCadastroProduto.UseVisualStyleBackColor = false;
            this.btnExibirCadastroProduto.Click += new System.EventHandler(this.btnExibirCadastroProduto_Click);
            // 
            // txtFiltrarProduto
            // 
            this.txtFiltrarProduto.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltrarProduto.Location = new System.Drawing.Point(169, 169);
            this.txtFiltrarProduto.Name = "txtFiltrarProduto";
            this.txtFiltrarProduto.Size = new System.Drawing.Size(204, 30);
            this.txtFiltrarProduto.TabIndex = 27;
            // 
            // btnFiltrarProduto
            // 
            this.btnFiltrarProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.btnFiltrarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFiltrarProduto.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarProduto.Location = new System.Drawing.Point(379, 170);
            this.btnFiltrarProduto.Name = "btnFiltrarProduto";
            this.btnFiltrarProduto.Size = new System.Drawing.Size(162, 30);
            this.btnFiltrarProduto.TabIndex = 26;
            this.btnFiltrarProduto.Text = "Filtrar produto";
            this.btnFiltrarProduto.UseVisualStyleBackColor = false;
            this.btnFiltrarProduto.Click += new System.EventHandler(this.btnFiltrarProduto_Click);
            // 
            // checkBoxListaProdutoAtivo
            // 
            this.checkBoxListaProdutoAtivo.AutoSize = true;
            this.checkBoxListaProdutoAtivo.Checked = true;
            this.checkBoxListaProdutoAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxListaProdutoAtivo.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxListaProdutoAtivo.Location = new System.Drawing.Point(691, 166);
            this.checkBoxListaProdutoAtivo.Name = "checkBoxListaProdutoAtivo";
            this.checkBoxListaProdutoAtivo.Size = new System.Drawing.Size(236, 27);
            this.checkBoxListaProdutoAtivo.TabIndex = 30;
            this.checkBoxListaProdutoAtivo.Text = "Somente produtos ativos";
            this.checkBoxListaProdutoAtivo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "Produtos";
            // 
            // FrmListaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxListaProdutoAtivo);
            this.Controls.Add(this.txtFiltrarProduto);
            this.Controls.Add(this.btnFiltrarProduto);
            this.Controls.Add(this.btnExibirCadastroProduto);
            this.Controls.Add(this.labelListagemProdutos);
            this.Controls.Add(this.dataGridViewListaProduto);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FrmListaProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label label1;
    }
}