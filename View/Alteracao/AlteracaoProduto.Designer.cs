
namespace CrudAugustusFashion.View.Alteracao
{
    partial class FrmAlteracaoProduto
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
            this.buttonCalcularPrecoProduto = new System.Windows.Forms.Button();
            this.buttonCadastrarProduto = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeFabricante = new System.Windows.Forms.TextBox();
            this.txtPorcentagemLucro = new System.Windows.Forms.TextBox();
            this.txtPrecoCusto = new System.Windows.Forms.TextBox();
            this.txtCodigoBarras = new System.Windows.Forms.TextBox();
            this.txtPrecoVenda = new System.Windows.Forms.TextBox();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtIdProduto = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAdicionarEstoque = new System.Windows.Forms.Button();
            this.btnSubtrairEstoque = new System.Windows.Forms.Button();
            this.numericEstoque = new System.Windows.Forms.NumericUpDown();
            this.numericEstoqueAdicional = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEstoqueAdicional)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCalcularPrecoProduto
            // 
            this.buttonCalcularPrecoProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.buttonCalcularPrecoProduto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCalcularPrecoProduto.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalcularPrecoProduto.Location = new System.Drawing.Point(343, 461);
            this.buttonCalcularPrecoProduto.Name = "buttonCalcularPrecoProduto";
            this.buttonCalcularPrecoProduto.Size = new System.Drawing.Size(195, 35);
            this.buttonCalcularPrecoProduto.TabIndex = 8;
            this.buttonCalcularPrecoProduto.Text = "Calcular preço ";
            this.buttonCalcularPrecoProduto.UseVisualStyleBackColor = false;
            this.buttonCalcularPrecoProduto.Click += new System.EventHandler(this.buttonCalcularPrecoProduto_Click);
            // 
            // buttonCadastrarProduto
            // 
            this.buttonCadastrarProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.buttonCadastrarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCadastrarProduto.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCadastrarProduto.Location = new System.Drawing.Point(81, 575);
            this.buttonCadastrarProduto.Name = "buttonCadastrarProduto";
            this.buttonCadastrarProduto.Size = new System.Drawing.Size(195, 36);
            this.buttonCadastrarProduto.TabIndex = 10;
            this.buttonCadastrarProduto.Text = "Salvar alteração";
            this.buttonCadastrarProduto.UseVisualStyleBackColor = false;
            this.buttonCadastrarProduto.Click += new System.EventHandler(this.buttonCadastrarProduto_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(461, 373);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 25);
            this.label10.TabIndex = 37;
            this.label10.Text = "Lucro em %";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(263, 213);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 25);
            this.label9.TabIndex = 36;
            this.label9.Text = "Fabricante";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(263, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 25);
            this.label7.TabIndex = 35;
            this.label7.Text = "Estoque ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(259, 373);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 25);
            this.label6.TabIndex = 34;
            this.label6.Text = "Preço de custo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(350, 499);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 25);
            this.label5.TabIndex = 33;
            this.label5.Text = "Preço de Venda";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(263, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 25);
            this.label4.TabIndex = 32;
            this.label4.Text = "Nome do Produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(263, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 25);
            this.label3.TabIndex = 31;
            this.label3.Text = "Código de Barras";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 25);
            this.label1.TabIndex = 30;
            this.label1.Text = "Alteração de produto";
            // 
            // txtNomeFabricante
            // 
            this.txtNomeFabricante.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFabricante.Location = new System.Drawing.Point(263, 240);
            this.txtNomeFabricante.Name = "txtNomeFabricante";
            this.txtNomeFabricante.Size = new System.Drawing.Size(363, 33);
            this.txtNomeFabricante.TabIndex = 3;
            // 
            // txtPorcentagemLucro
            // 
            this.txtPorcentagemLucro.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorcentagemLucro.Location = new System.Drawing.Point(465, 400);
            this.txtPorcentagemLucro.Name = "txtPorcentagemLucro";
            this.txtPorcentagemLucro.Size = new System.Drawing.Size(165, 33);
            this.txtPorcentagemLucro.TabIndex = 7;
            this.txtPorcentagemLucro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPorcentagemLucro_KeyPress);
            // 
            // txtPrecoCusto
            // 
            this.txtPrecoCusto.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoCusto.Location = new System.Drawing.Point(263, 400);
            this.txtPrecoCusto.Name = "txtPrecoCusto";
            this.txtPrecoCusto.Size = new System.Drawing.Size(165, 33);
            this.txtPrecoCusto.TabIndex = 6;
            this.txtPrecoCusto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecoCusto_KeyPress);
            // 
            // txtCodigoBarras
            // 
            this.txtCodigoBarras.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoBarras.Location = new System.Drawing.Point(263, 99);
            this.txtCodigoBarras.Name = "txtCodigoBarras";
            this.txtCodigoBarras.Size = new System.Drawing.Size(363, 33);
            this.txtCodigoBarras.TabIndex = 1;
            // 
            // txtPrecoVenda
            // 
            this.txtPrecoVenda.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoVenda.Location = new System.Drawing.Point(354, 526);
            this.txtPrecoVenda.Name = "txtPrecoVenda";
            this.txtPrecoVenda.Size = new System.Drawing.Size(165, 33);
            this.txtPrecoVenda.TabIndex = 9;
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeProduto.Location = new System.Drawing.Point(263, 171);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(363, 33);
            this.txtNomeProduto.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(137)))), ((int)(((byte)(239)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(588, 575);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 36);
            this.button1.TabIndex = 12;
            this.button1.Text = "Desativar produto";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtIdProduto
            // 
            this.txtIdProduto.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdProduto.Location = new System.Drawing.Point(481, 6);
            this.txtIdProduto.Name = "txtIdProduto";
            this.txtIdProduto.Size = new System.Drawing.Size(38, 33);
            this.txtIdProduto.TabIndex = 43;
            this.txtIdProduto.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(588, 509);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(195, 35);
            this.button2.TabIndex = 11;
            this.button2.Text = "Ativar produto";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAdicionarEstoque
            // 
            this.btnAdicionarEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.btnAdicionarEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdicionarEstoque.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarEstoque.Location = new System.Drawing.Point(551, 328);
            this.btnAdicionarEstoque.Name = "btnAdicionarEstoque";
            this.btnAdicionarEstoque.Size = new System.Drawing.Size(75, 35);
            this.btnAdicionarEstoque.TabIndex = 45;
            this.btnAdicionarEstoque.Text = "Adicionar";
            this.btnAdicionarEstoque.UseVisualStyleBackColor = false;
            this.btnAdicionarEstoque.Click += new System.EventHandler(this.btnAdicionarEstoque_Click);
            // 
            // btnSubtrairEstoque
            // 
            this.btnSubtrairEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(137)))), ((int)(((byte)(239)))));
            this.btnSubtrairEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubtrairEstoque.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtrairEstoque.Location = new System.Drawing.Point(470, 328);
            this.btnSubtrairEstoque.Name = "btnSubtrairEstoque";
            this.btnSubtrairEstoque.Size = new System.Drawing.Size(75, 35);
            this.btnSubtrairEstoque.TabIndex = 46;
            this.btnSubtrairEstoque.Text = "Subtrair";
            this.btnSubtrairEstoque.UseVisualStyleBackColor = false;
            this.btnSubtrairEstoque.Click += new System.EventHandler(this.btnSubtrairEstoque_Click);
            // 
            // numericEstoque
            // 
            this.numericEstoque.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericEstoque.Location = new System.Drawing.Point(263, 319);
            this.numericEstoque.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericEstoque.Name = "numericEstoque";
            this.numericEstoque.Size = new System.Drawing.Size(138, 33);
            this.numericEstoque.TabIndex = 5;
            // 
            // numericEstoqueAdicional
            // 
            this.numericEstoqueAdicional.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericEstoqueAdicional.Location = new System.Drawing.Point(470, 289);
            this.numericEstoqueAdicional.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.numericEstoqueAdicional.Name = "numericEstoqueAdicional";
            this.numericEstoqueAdicional.Size = new System.Drawing.Size(156, 33);
            this.numericEstoqueAdicional.TabIndex = 4;
            // 
            // FrmAlteracaoProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(876, 623);
            this.Controls.Add(this.numericEstoqueAdicional);
            this.Controls.Add(this.numericEstoque);
            this.Controls.Add(this.btnSubtrairEstoque);
            this.Controls.Add(this.btnAdicionarEstoque);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtIdProduto);
            this.Controls.Add(this.button1);
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
            this.Controls.Add(this.txtPrecoCusto);
            this.Controls.Add(this.txtCodigoBarras);
            this.Controls.Add(this.txtPrecoVenda);
            this.Controls.Add(this.txtNomeProduto);
            this.Name = "FrmAlteracaoProduto";
            this.Text = "AlteracaoProduto";
            this.Load += new System.EventHandler(this.FrmAlteracaoProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEstoqueAdicional)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCalcularPrecoProduto;
        private System.Windows.Forms.Button buttonCadastrarProduto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeFabricante;
        private System.Windows.Forms.TextBox txtPorcentagemLucro;
        private System.Windows.Forms.TextBox txtPrecoCusto;
        private System.Windows.Forms.TextBox txtCodigoBarras;
        private System.Windows.Forms.TextBox txtPrecoVenda;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtIdProduto;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAdicionarEstoque;
        private System.Windows.Forms.Button btnSubtrairEstoque;
        private System.Windows.Forms.NumericUpDown numericEstoque;
        private System.Windows.Forms.NumericUpDown numericEstoqueAdicional;
    }
}