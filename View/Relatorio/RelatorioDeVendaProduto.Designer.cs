
namespace CrudAugustusFashion.View.Relatorio
{
    partial class FrmRelatorioDeVendaProduto
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
            this.dtgFiltragemDeVendas = new System.Windows.Forms.DataGridView();
            this.lblProduto = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblDataInicial = new System.Windows.Forms.Label();
            this.lblDataFinal = new System.Windows.Forms.Label();
            this.lblRelatorioVendaProduto = new System.Windows.Forms.Label();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.dtpDataInicial = new System.Windows.Forms.DateTimePicker();
            this.dtpDataFinal = new System.Windows.Forms.DateTimePicker();
            this.btnFiltrarProduto = new System.Windows.Forms.Button();
            this.btnFiltrarCliente = new System.Windows.Forms.Button();
            this.btnFiltrarProdutosVendidos = new System.Windows.Forms.Button();
            this.btnLimparCampos = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnLimparProduto = new System.Windows.Forms.Button();
            this.btnLimparCliente = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.lblTotalBruto = new System.Windows.Forms.Label();
            this.lblTotalDesconto = new System.Windows.Forms.Label();
            this.lblTotalLiquido = new System.Windows.Forms.Label();
            this.lblTotalCusto = new System.Windows.Forms.Label();
            this.lblLucroReais = new System.Windows.Forms.Label();
            this.labelTotalBruto = new System.Windows.Forms.Label();
            this.labelTotalDesconto = new System.Windows.Forms.Label();
            this.labelTotalLiquido = new System.Windows.Forms.Label();
            this.labelTotalCusto = new System.Windows.Forms.Label();
            this.labelLucroReais = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFiltragemDeVendas)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgFiltragemDeVendas
            // 
            this.dtgFiltragemDeVendas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgFiltragemDeVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgFiltragemDeVendas.Location = new System.Drawing.Point(29, 130);
            this.dtgFiltragemDeVendas.Name = "dtgFiltragemDeVendas";
            this.dtgFiltragemDeVendas.Size = new System.Drawing.Size(779, 374);
            this.dtgFiltragemDeVendas.TabIndex = 0;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto.Location = new System.Drawing.Point(10, 142);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(65, 19);
            this.lblProduto.TabIndex = 1;
            this.lblProduto.Text = "Produto";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(10, 74);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(57, 19);
            this.lblCliente.TabIndex = 2;
            this.lblCliente.Text = "Cliente";
            // 
            // lblDataInicial
            // 
            this.lblDataInicial.AutoSize = true;
            this.lblDataInicial.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataInicial.Location = new System.Drawing.Point(10, 212);
            this.lblDataInicial.Name = "lblDataInicial";
            this.lblDataInicial.Size = new System.Drawing.Size(88, 19);
            this.lblDataInicial.TabIndex = 3;
            this.lblDataInicial.Text = "Data Inicial";
            // 
            // lblDataFinal
            // 
            this.lblDataFinal.AutoSize = true;
            this.lblDataFinal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataFinal.Location = new System.Drawing.Point(10, 291);
            this.lblDataFinal.Name = "lblDataFinal";
            this.lblDataFinal.Size = new System.Drawing.Size(79, 19);
            this.lblDataFinal.TabIndex = 4;
            this.lblDataFinal.Text = "Data Final";
            // 
            // lblRelatorioVendaProduto
            // 
            this.lblRelatorioVendaProduto.AutoSize = true;
            this.lblRelatorioVendaProduto.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelatorioVendaProduto.Location = new System.Drawing.Point(305, 25);
            this.lblRelatorioVendaProduto.Name = "lblRelatorioVendaProduto";
            this.lblRelatorioVendaProduto.Size = new System.Drawing.Size(221, 29);
            this.lblRelatorioVendaProduto.TabIndex = 5;
            this.lblRelatorioVendaProduto.Text = "Relatório de venda ";
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeProduto.Location = new System.Drawing.Point(14, 163);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.ReadOnly = true;
            this.txtNomeProduto.Size = new System.Drawing.Size(100, 27);
            this.txtNomeProduto.TabIndex = 6;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCliente.Location = new System.Drawing.Point(14, 97);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.ReadOnly = true;
            this.txtNomeCliente.Size = new System.Drawing.Size(100, 27);
            this.txtNomeCliente.TabIndex = 7;
            // 
            // dtpDataInicial
            // 
            this.dtpDataInicial.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicial.Location = new System.Drawing.Point(14, 241);
            this.dtpDataInicial.Name = "dtpDataInicial";
            this.dtpDataInicial.Size = new System.Drawing.Size(139, 27);
            this.dtpDataInicial.TabIndex = 8;
            this.dtpDataInicial.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            // 
            // dtpDataFinal
            // 
            this.dtpDataFinal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFinal.Location = new System.Drawing.Point(14, 320);
            this.dtpDataFinal.Name = "dtpDataFinal";
            this.dtpDataFinal.Size = new System.Drawing.Size(139, 27);
            this.dtpDataFinal.TabIndex = 9;
            // 
            // btnFiltrarProduto
            // 
            this.btnFiltrarProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.btnFiltrarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFiltrarProduto.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarProduto.Location = new System.Drawing.Point(120, 163);
            this.btnFiltrarProduto.Name = "btnFiltrarProduto";
            this.btnFiltrarProduto.Size = new System.Drawing.Size(33, 27);
            this.btnFiltrarProduto.TabIndex = 10;
            this.btnFiltrarProduto.Text = "🔍";
            this.btnFiltrarProduto.UseVisualStyleBackColor = false;
            this.btnFiltrarProduto.Click += new System.EventHandler(this.btnFiltrarProduto_Click);
            // 
            // btnFiltrarCliente
            // 
            this.btnFiltrarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.btnFiltrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFiltrarCliente.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarCliente.Location = new System.Drawing.Point(120, 96);
            this.btnFiltrarCliente.Name = "btnFiltrarCliente";
            this.btnFiltrarCliente.Size = new System.Drawing.Size(33, 27);
            this.btnFiltrarCliente.TabIndex = 11;
            this.btnFiltrarCliente.Text = "🔍";
            this.btnFiltrarCliente.UseVisualStyleBackColor = false;
            this.btnFiltrarCliente.Click += new System.EventHandler(this.btnFiltrarCliente_Click);
            // 
            // btnFiltrarProdutosVendidos
            // 
            this.btnFiltrarProdutosVendidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.btnFiltrarProdutosVendidos.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnFiltrarProdutosVendidos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFiltrarProdutosVendidos.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarProdutosVendidos.Location = new System.Drawing.Point(53, 397);
            this.btnFiltrarProdutosVendidos.Name = "btnFiltrarProdutosVendidos";
            this.btnFiltrarProdutosVendidos.Size = new System.Drawing.Size(100, 37);
            this.btnFiltrarProdutosVendidos.TabIndex = 12;
            this.btnFiltrarProdutosVendidos.Text = "Filtrar";
            this.btnFiltrarProdutosVendidos.UseVisualStyleBackColor = false;
            this.btnFiltrarProdutosVendidos.Click += new System.EventHandler(this.btnFiltrarProdutosVendidos_Click);
            // 
            // btnLimparCampos
            // 
            this.btnLimparCampos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimparCampos.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparCampos.Location = new System.Drawing.Point(14, 397);
            this.btnLimparCampos.Name = "btnLimparCampos";
            this.btnLimparCampos.Size = new System.Drawing.Size(33, 37);
            this.btnLimparCampos.TabIndex = 13;
            this.btnLimparCampos.Text = "🧻";
            this.btnLimparCampos.UseVisualStyleBackColor = true;
            this.btnLimparCampos.Click += new System.EventHandler(this.btnLimparCampos_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Controls.Add(this.btnLimparProduto);
            this.panelMenu.Controls.Add(this.btnLimparCliente);
            this.panelMenu.Controls.Add(this.btnFechar);
            this.panelMenu.Controls.Add(this.btnFiltrarCliente);
            this.panelMenu.Controls.Add(this.dtpDataFinal);
            this.panelMenu.Controls.Add(this.btnFiltrarProdutosVendidos);
            this.panelMenu.Controls.Add(this.dtpDataInicial);
            this.panelMenu.Controls.Add(this.lblDataFinal);
            this.panelMenu.Controls.Add(this.btnLimparCampos);
            this.panelMenu.Controls.Add(this.lblCliente);
            this.panelMenu.Controls.Add(this.txtNomeCliente);
            this.panelMenu.Controls.Add(this.lblDataInicial);
            this.panelMenu.Controls.Add(this.btnFiltrarProduto);
            this.panelMenu.Controls.Add(this.lblProduto);
            this.panelMenu.Controls.Add(this.txtNomeProduto);
            this.panelMenu.Location = new System.Drawing.Point(640, 1);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(201, 503);
            this.panelMenu.TabIndex = 14;
            this.panelMenu.Visible = false;
            // 
            // btnLimparProduto
            // 
            this.btnLimparProduto.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparProduto.Location = new System.Drawing.Point(155, 161);
            this.btnLimparProduto.Name = "btnLimparProduto";
            this.btnLimparProduto.Size = new System.Drawing.Size(33, 28);
            this.btnLimparProduto.TabIndex = 16;
            this.btnLimparProduto.Text = "🧻";
            this.btnLimparProduto.UseVisualStyleBackColor = true;
            this.btnLimparProduto.Click += new System.EventHandler(this.btnLimparProduto_Click);
            // 
            // btnLimparCliente
            // 
            this.btnLimparCliente.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparCliente.Location = new System.Drawing.Point(155, 95);
            this.btnLimparCliente.Name = "btnLimparCliente";
            this.btnLimparCliente.Size = new System.Drawing.Size(33, 28);
            this.btnLimparCliente.TabIndex = 15;
            this.btnLimparCliente.Text = "🧻";
            this.btnLimparCliente.UseVisualStyleBackColor = true;
            this.btnLimparCliente.Click += new System.EventHandler(this.btnLimparCliente_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(155, 13);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(33, 27);
            this.btnFechar.TabIndex = 14;
            this.btnFechar.Text = "❌";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Location = new System.Drawing.Point(706, 87);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(102, 37);
            this.btnMenu.TabIndex = 14;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // lblTotalBruto
            // 
            this.lblTotalBruto.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTotalBruto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalBruto.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBruto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotalBruto.Location = new System.Drawing.Point(29, 551);
            this.lblTotalBruto.Name = "lblTotalBruto";
            this.lblTotalBruto.Size = new System.Drawing.Size(130, 25);
            this.lblTotalBruto.TabIndex = 17;
            // 
            // lblTotalDesconto
            // 
            this.lblTotalDesconto.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTotalDesconto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalDesconto.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDesconto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotalDesconto.Location = new System.Drawing.Point(191, 550);
            this.lblTotalDesconto.Name = "lblTotalDesconto";
            this.lblTotalDesconto.Size = new System.Drawing.Size(130, 25);
            this.lblTotalDesconto.TabIndex = 18;
            // 
            // lblTotalLiquido
            // 
            this.lblTotalLiquido.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTotalLiquido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalLiquido.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalLiquido.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotalLiquido.Location = new System.Drawing.Point(353, 551);
            this.lblTotalLiquido.Name = "lblTotalLiquido";
            this.lblTotalLiquido.Size = new System.Drawing.Size(130, 25);
            this.lblTotalLiquido.TabIndex = 19;
            // 
            // lblTotalCusto
            // 
            this.lblTotalCusto.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTotalCusto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalCusto.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCusto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotalCusto.Location = new System.Drawing.Point(515, 551);
            this.lblTotalCusto.Name = "lblTotalCusto";
            this.lblTotalCusto.Size = new System.Drawing.Size(130, 25);
            this.lblTotalCusto.TabIndex = 20;
            // 
            // lblLucroReais
            // 
            this.lblLucroReais.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLucroReais.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLucroReais.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLucroReais.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLucroReais.Location = new System.Drawing.Point(677, 550);
            this.lblLucroReais.Name = "lblLucroReais";
            this.lblLucroReais.Size = new System.Drawing.Size(130, 25);
            this.lblLucroReais.TabIndex = 21;
            // 
            // labelTotalBruto
            // 
            this.labelTotalBruto.AutoSize = true;
            this.labelTotalBruto.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalBruto.Location = new System.Drawing.Point(25, 527);
            this.labelTotalBruto.Name = "labelTotalBruto";
            this.labelTotalBruto.Size = new System.Drawing.Size(102, 23);
            this.labelTotalBruto.TabIndex = 22;
            this.labelTotalBruto.Text = "Total Bruto";
            // 
            // labelTotalDesconto
            // 
            this.labelTotalDesconto.AutoSize = true;
            this.labelTotalDesconto.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalDesconto.Location = new System.Drawing.Point(187, 527);
            this.labelTotalDesconto.Name = "labelTotalDesconto";
            this.labelTotalDesconto.Size = new System.Drawing.Size(134, 23);
            this.labelTotalDesconto.TabIndex = 23;
            this.labelTotalDesconto.Text = "Total Desconto";
            // 
            // labelTotalLiquido
            // 
            this.labelTotalLiquido.AutoSize = true;
            this.labelTotalLiquido.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalLiquido.Location = new System.Drawing.Point(349, 527);
            this.labelTotalLiquido.Name = "labelTotalLiquido";
            this.labelTotalLiquido.Size = new System.Drawing.Size(117, 23);
            this.labelTotalLiquido.TabIndex = 24;
            this.labelTotalLiquido.Text = "Total Liquido";
            // 
            // labelTotalCusto
            // 
            this.labelTotalCusto.AutoSize = true;
            this.labelTotalCusto.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalCusto.Location = new System.Drawing.Point(511, 528);
            this.labelTotalCusto.Name = "labelTotalCusto";
            this.labelTotalCusto.Size = new System.Drawing.Size(103, 23);
            this.labelTotalCusto.TabIndex = 25;
            this.labelTotalCusto.Text = "Total Custo";
            // 
            // labelLucroReais
            // 
            this.labelLucroReais.AutoSize = true;
            this.labelLucroReais.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLucroReais.Location = new System.Drawing.Point(673, 527);
            this.labelLucroReais.Name = "labelLucroReais";
            this.labelLucroReais.Size = new System.Drawing.Size(84, 23);
            this.labelLucroReais.TabIndex = 26;
            this.labelLucroReais.Text = "Lucro R$";
            // 
            // FrmRelatorioDeVendaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(837, 607);
            this.Controls.Add(this.labelTotalCusto);
            this.Controls.Add(this.labelTotalLiquido);
            this.Controls.Add(this.labelTotalDesconto);
            this.Controls.Add(this.labelTotalBruto);
            this.Controls.Add(this.lblTotalCusto);
            this.Controls.Add(this.lblTotalLiquido);
            this.Controls.Add(this.lblTotalDesconto);
            this.Controls.Add(this.lblTotalBruto);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.lblRelatorioVendaProduto);
            this.Controls.Add(this.dtgFiltragemDeVendas);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.lblLucroReais);
            this.Controls.Add(this.labelLucroReais);
            this.Name = "FrmRelatorioDeVendaProduto";
            this.Text = "Relatorio de venda";
            this.Load += new System.EventHandler(this.FrmRelatorioDeVendaProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgFiltragemDeVendas)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgFiltragemDeVendas;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblDataInicial;
        private System.Windows.Forms.Label lblDataFinal;
        private System.Windows.Forms.Label lblRelatorioVendaProduto;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.DateTimePicker dtpDataInicial;
        private System.Windows.Forms.DateTimePicker dtpDataFinal;
        private System.Windows.Forms.Button btnFiltrarProduto;
        private System.Windows.Forms.Button btnFiltrarCliente;
        private System.Windows.Forms.Button btnFiltrarProdutosVendidos;
        private System.Windows.Forms.Button btnLimparCampos;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnLimparProduto;
        private System.Windows.Forms.Button btnLimparCliente;
        private System.Windows.Forms.Label lblTotalBruto;
        private System.Windows.Forms.Label lblTotalDesconto;
        private System.Windows.Forms.Label lblTotalLiquido;
        private System.Windows.Forms.Label lblTotalCusto;
        private System.Windows.Forms.Label lblLucroReais;
        private System.Windows.Forms.Label labelTotalBruto;
        private System.Windows.Forms.Label labelTotalDesconto;
        private System.Windows.Forms.Label labelTotalLiquido;
        private System.Windows.Forms.Label labelTotalCusto;
        private System.Windows.Forms.Label labelLucroReais;
    }
}