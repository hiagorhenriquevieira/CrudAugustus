
namespace CrudAugustusFashion.View.Cadastro
{
    partial class FrmCadastroProduto
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
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.txtPrecoVenda = new System.Windows.Forms.TextBox();
            this.txtCodigoBarras = new System.Windows.Forms.TextBox();
            this.txtPrecoCusto = new System.Windows.Forms.TextBox();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.txtNomeFabricante = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPorcentagemLucro = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonCadastrarProduto = new System.Windows.Forms.Button();
            this.buttonCalcularPrecoProduto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeProduto.Location = new System.Drawing.Point(331, 227);
            this.txtNomeProduto.MaxLength = 50;
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(363, 29);
            this.txtNomeProduto.TabIndex = 2;
            // 
            // txtPrecoVenda
            // 
            this.txtPrecoVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoVenda.Location = new System.Drawing.Point(427, 534);
            this.txtPrecoVenda.MaxLength = 15;
            this.txtPrecoVenda.Name = "txtPrecoVenda";
            this.txtPrecoVenda.Size = new System.Drawing.Size(165, 29);
            this.txtPrecoVenda.TabIndex = 7;
            this.txtPrecoVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecoVenda_KeyPress);
            this.txtPrecoVenda.Leave += new System.EventHandler(this.txtPrecoVenda_Leave);
            // 
            // txtCodigoBarras
            // 
            this.txtCodigoBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoBarras.Location = new System.Drawing.Point(331, 155);
            this.txtCodigoBarras.MaxLength = 15;
            this.txtCodigoBarras.Name = "txtCodigoBarras";
            this.txtCodigoBarras.Size = new System.Drawing.Size(363, 29);
            this.txtCodigoBarras.TabIndex = 1;
            this.txtCodigoBarras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoBarras_KeyPress);
            // 
            // txtPrecoCusto
            // 
            this.txtPrecoCusto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoCusto.Location = new System.Drawing.Point(331, 440);
            this.txtPrecoCusto.MaxLength = 10;
            this.txtPrecoCusto.Name = "txtPrecoCusto";
            this.txtPrecoCusto.Size = new System.Drawing.Size(165, 29);
            this.txtPrecoCusto.TabIndex = 5;
            this.txtPrecoCusto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecoCusto_KeyPress);
            this.txtPrecoCusto.Leave += new System.EventHandler(this.txtPrecoCusto_Leave);
            // 
            // txtEstoque
            // 
            this.txtEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstoque.Location = new System.Drawing.Point(331, 365);
            this.txtEstoque.MaxLength = 25;
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(363, 29);
            this.txtEstoque.TabIndex = 4;
            this.txtEstoque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEstoque_KeyPress);
            // 
            // txtNomeFabricante
            // 
            this.txtNomeFabricante.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFabricante.Location = new System.Drawing.Point(331, 296);
            this.txtNomeFabricante.MaxLength = 50;
            this.txtNomeFabricante.Name = "txtNomeFabricante";
            this.txtNomeFabricante.Size = new System.Drawing.Size(363, 29);
            this.txtNomeFabricante.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(338, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 37);
            this.label1.TabIndex = 11;
            this.label1.Text = "Cadastro de produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(327, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Código de Barras";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(327, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "Nome do Produto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(423, 507);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "Preço de Venda";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(327, 413);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "Preço de custo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(327, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(211, 24);
            this.label7.TabIndex = 17;
            this.label7.Text = "Estoque (quantidade)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(327, 269);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 24);
            this.label9.TabIndex = 19;
            this.label9.Text = "Fabricante";
            // 
            // txtPorcentagemLucro
            // 
            this.txtPorcentagemLucro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorcentagemLucro.Location = new System.Drawing.Point(529, 440);
            this.txtPorcentagemLucro.MaxLength = 4;
            this.txtPorcentagemLucro.Name = "txtPorcentagemLucro";
            this.txtPorcentagemLucro.Size = new System.Drawing.Size(165, 29);
            this.txtPorcentagemLucro.TabIndex = 6;
            this.txtPorcentagemLucro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPorcentagemLucro_KeyPress);
            this.txtPorcentagemLucro.Leave += new System.EventHandler(this.txtPorcentagemLucro_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(525, 413);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 24);
            this.label10.TabIndex = 20;
            this.label10.Text = "Lucro em %";
            // 
            // buttonCadastrarProduto
            // 
            this.buttonCadastrarProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.buttonCadastrarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCadastrarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCadastrarProduto.Location = new System.Drawing.Point(367, 594);
            this.buttonCadastrarProduto.Name = "buttonCadastrarProduto";
            this.buttonCadastrarProduto.Size = new System.Drawing.Size(276, 51);
            this.buttonCadastrarProduto.TabIndex = 8;
            this.buttonCadastrarProduto.Text = "Cadastrar";
            this.buttonCadastrarProduto.UseVisualStyleBackColor = false;
            this.buttonCadastrarProduto.Click += new System.EventHandler(this.buttonCadastrarProduto_Click);
            // 
            // buttonCalcularPrecoProduto
            // 
            this.buttonCalcularPrecoProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.buttonCalcularPrecoProduto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCalcularPrecoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalcularPrecoProduto.Location = new System.Drawing.Point(427, 475);
            this.buttonCalcularPrecoProduto.Name = "buttonCalcularPrecoProduto";
            this.buttonCalcularPrecoProduto.Size = new System.Drawing.Size(165, 29);
            this.buttonCalcularPrecoProduto.TabIndex = 22;
            this.buttonCalcularPrecoProduto.Text = "Calcular preço ";
            this.buttonCalcularPrecoProduto.UseVisualStyleBackColor = false;
            this.buttonCalcularPrecoProduto.Visible = false;
            this.buttonCalcularPrecoProduto.Click += new System.EventHandler(this.buttonCalcularPrecoProduto_Click);
            // 
            // FrmCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.buttonCalcularPrecoProduto);
            this.Controls.Add(this.buttonCadastrarProduto);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomeFabricante);
            this.Controls.Add(this.txtPorcentagemLucro);
            this.Controls.Add(this.txtEstoque);
            this.Controls.Add(this.txtPrecoCusto);
            this.Controls.Add(this.txtCodigoBarras);
            this.Controls.Add(this.txtPrecoVenda);
            this.Controls.Add(this.txtNomeProduto);
            this.Name = "FrmCadastroProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroProduto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.TextBox txtPrecoVenda;
        private System.Windows.Forms.TextBox txtCodigoBarras;
        private System.Windows.Forms.TextBox txtPrecoCusto;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.TextBox txtNomeFabricante;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPorcentagemLucro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonCadastrarProduto;
        private System.Windows.Forms.Button buttonCalcularPrecoProduto;
    }
}