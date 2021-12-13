
namespace CrudAugustusFashion.View.Relatorio
{
    partial class FrmRelatorioCliente
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
            this.lblRelatorioCliente = new System.Windows.Forms.Label();
            this.labelTotalLiquido = new System.Windows.Forms.Label();
            this.labelTotalDesconto = new System.Windows.Forms.Label();
            this.labelTotalBruto = new System.Windows.Forms.Label();
            this.lblTotalLiquido = new System.Windows.Forms.Label();
            this.lblTotalDesconto = new System.Windows.Forms.Label();
            this.lblTotalBruto = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.cmbOrdemParaFiltro = new System.Windows.Forms.ComboBox();
            this.labelCrescenteDecrescente = new System.Windows.Forms.Label();
            this.labelOrdernarPor = new System.Windows.Forms.Label();
            this.cmbOrdemSelecao = new System.Windows.Forms.ComboBox();
            this.nudLimiteClientes = new System.Windows.Forms.NumericUpDown();
            this.labelLimitadorDeClientes = new System.Windows.Forms.Label();
            this.btnLimparCliente = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnFiltrarCliente = new System.Windows.Forms.Button();
            this.dtpDataFinal = new System.Windows.Forms.DateTimePicker();
            this.btnFiltrarProdutosVendidos = new System.Windows.Forms.Button();
            this.dtpDataInicial = new System.Windows.Forms.DateTimePicker();
            this.lblDataFinal = new System.Windows.Forms.Label();
            this.btnLimparCampos = new System.Windows.Forms.Button();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.lblDataInicial = new System.Windows.Forms.Label();
            this.labelValorParaFiltro = new System.Windows.Forms.Label();
            this.txtValorParaFiltro = new System.Windows.Forms.TextBox();
            this.lblRelatorioVendaProduto = new System.Windows.Forms.Label();
            this.dtgFiltragemDeClientes = new System.Windows.Forms.DataGridView();
            this.btnMenu = new System.Windows.Forms.Button();
            this.lblTotalVendas = new System.Windows.Forms.Label();
            this.labelTotalVendas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFiltrarPor = new System.Windows.Forms.ComboBox();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLimiteClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFiltragemDeClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRelatorioCliente
            // 
            this.lblRelatorioCliente.AutoSize = true;
            this.lblRelatorioCliente.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelatorioCliente.Location = new System.Drawing.Point(16, 87);
            this.lblRelatorioCliente.Name = "lblRelatorioCliente";
            this.lblRelatorioCliente.Size = new System.Drawing.Size(525, 33);
            this.lblRelatorioCliente.TabIndex = 0;
            this.lblRelatorioCliente.Text = "Relatório de Clientes que mais compraram ";
            // 
            // labelTotalLiquido
            // 
            this.labelTotalLiquido.AutoSize = true;
            this.labelTotalLiquido.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalLiquido.Location = new System.Drawing.Point(535, 537);
            this.labelTotalLiquido.Name = "labelTotalLiquido";
            this.labelTotalLiquido.Size = new System.Drawing.Size(117, 23);
            this.labelTotalLiquido.TabIndex = 38;
            this.labelTotalLiquido.Text = "Total Liquido";
            // 
            // labelTotalDesconto
            // 
            this.labelTotalDesconto.AutoSize = true;
            this.labelTotalDesconto.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalDesconto.Location = new System.Drawing.Point(370, 537);
            this.labelTotalDesconto.Name = "labelTotalDesconto";
            this.labelTotalDesconto.Size = new System.Drawing.Size(134, 23);
            this.labelTotalDesconto.TabIndex = 37;
            this.labelTotalDesconto.Text = "Total Desconto";
            // 
            // labelTotalBruto
            // 
            this.labelTotalBruto.AutoSize = true;
            this.labelTotalBruto.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalBruto.Location = new System.Drawing.Point(205, 537);
            this.labelTotalBruto.Name = "labelTotalBruto";
            this.labelTotalBruto.Size = new System.Drawing.Size(102, 23);
            this.labelTotalBruto.TabIndex = 36;
            this.labelTotalBruto.Text = "Total Bruto";
            // 
            // lblTotalLiquido
            // 
            this.lblTotalLiquido.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTotalLiquido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalLiquido.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalLiquido.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotalLiquido.Location = new System.Drawing.Point(539, 561);
            this.lblTotalLiquido.Name = "lblTotalLiquido";
            this.lblTotalLiquido.Size = new System.Drawing.Size(130, 25);
            this.lblTotalLiquido.TabIndex = 33;
            // 
            // lblTotalDesconto
            // 
            this.lblTotalDesconto.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTotalDesconto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalDesconto.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDesconto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotalDesconto.Location = new System.Drawing.Point(374, 560);
            this.lblTotalDesconto.Name = "lblTotalDesconto";
            this.lblTotalDesconto.Size = new System.Drawing.Size(130, 25);
            this.lblTotalDesconto.TabIndex = 32;
            // 
            // lblTotalBruto
            // 
            this.lblTotalBruto.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTotalBruto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalBruto.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBruto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotalBruto.Location = new System.Drawing.Point(209, 561);
            this.lblTotalBruto.Name = "lblTotalBruto";
            this.lblTotalBruto.Size = new System.Drawing.Size(130, 25);
            this.lblTotalBruto.TabIndex = 31;
            // 
            // panelMenu
            // 
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Controls.Add(this.cmbFiltrarPor);
            this.panelMenu.Controls.Add(this.cmbOrdemParaFiltro);
            this.panelMenu.Controls.Add(this.labelCrescenteDecrescente);
            this.panelMenu.Controls.Add(this.labelOrdernarPor);
            this.panelMenu.Controls.Add(this.cmbOrdemSelecao);
            this.panelMenu.Controls.Add(this.nudLimiteClientes);
            this.panelMenu.Controls.Add(this.btnLimparCliente);
            this.panelMenu.Controls.Add(this.labelLimitadorDeClientes);
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
            this.panelMenu.Controls.Add(this.labelValorParaFiltro);
            this.panelMenu.Controls.Add(this.txtValorParaFiltro);
            this.panelMenu.Location = new System.Drawing.Point(639, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(196, 600);
            this.panelMenu.TabIndex = 29;
            this.panelMenu.Visible = false;
            // 
            // cmbOrdemParaFiltro
            // 
            this.cmbOrdemParaFiltro.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cmbOrdemParaFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrdemParaFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbOrdemParaFiltro.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOrdemParaFiltro.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbOrdemParaFiltro.FormattingEnabled = true;
            this.cmbOrdemParaFiltro.Items.AddRange(new object[] {
            "Crescente",
            "Decrescente"});
            this.cmbOrdemParaFiltro.Location = new System.Drawing.Point(14, 367);
            this.cmbOrdemParaFiltro.Name = "cmbOrdemParaFiltro";
            this.cmbOrdemParaFiltro.Size = new System.Drawing.Size(136, 27);
            this.cmbOrdemParaFiltro.TabIndex = 26;
            // 
            // labelCrescenteDecrescente
            // 
            this.labelCrescenteDecrescente.AutoSize = true;
            this.labelCrescenteDecrescente.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCrescenteDecrescente.Location = new System.Drawing.Point(12, 340);
            this.labelCrescenteDecrescente.Name = "labelCrescenteDecrescente";
            this.labelCrescenteDecrescente.Size = new System.Drawing.Size(64, 19);
            this.labelCrescenteDecrescente.TabIndex = 24;
            this.labelCrescenteDecrescente.Text = "Ordem:";
            // 
            // labelOrdernarPor
            // 
            this.labelOrdernarPor.AutoSize = true;
            this.labelOrdernarPor.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrdernarPor.Location = new System.Drawing.Point(12, 278);
            this.labelOrdernarPor.Name = "labelOrdernarPor";
            this.labelOrdernarPor.Size = new System.Drawing.Size(108, 19);
            this.labelOrdernarPor.TabIndex = 21;
            this.labelOrdernarPor.Text = "Ordernar Por:";
            // 
            // cmbOrdemSelecao
            // 
            this.cmbOrdemSelecao.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cmbOrdemSelecao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrdemSelecao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbOrdemSelecao.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOrdemSelecao.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbOrdemSelecao.FormattingEnabled = true;
            this.cmbOrdemSelecao.Items.AddRange(new object[] {
            "Quantidade",
            "Total Desconto",
            "Total Liquido "});
            this.cmbOrdemSelecao.Location = new System.Drawing.Point(16, 305);
            this.cmbOrdemSelecao.Name = "cmbOrdemSelecao";
            this.cmbOrdemSelecao.Size = new System.Drawing.Size(136, 27);
            this.cmbOrdemSelecao.TabIndex = 20;
            // 
            // nudLimiteClientes
            // 
            this.nudLimiteClientes.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudLimiteClientes.Location = new System.Drawing.Point(13, 243);
            this.nudLimiteClientes.Name = "nudLimiteClientes";
            this.nudLimiteClientes.Size = new System.Drawing.Size(136, 27);
            this.nudLimiteClientes.TabIndex = 19;
            // 
            // labelLimitadorDeClientes
            // 
            this.labelLimitadorDeClientes.AutoSize = true;
            this.labelLimitadorDeClientes.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLimitadorDeClientes.Location = new System.Drawing.Point(8, 216);
            this.labelLimitadorDeClientes.Name = "labelLimitadorDeClientes";
            this.labelLimitadorDeClientes.Size = new System.Drawing.Size(131, 19);
            this.labelLimitadorDeClientes.TabIndex = 17;
            this.labelLimitadorDeClientes.Text = "Limite de clientes";
            // 
            // btnLimparCliente
            // 
            this.btnLimparCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimparCliente.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparCliente.Location = new System.Drawing.Point(157, 59);
            this.btnLimparCliente.Name = "btnLimparCliente";
            this.btnLimparCliente.Size = new System.Drawing.Size(33, 28);
            this.btnLimparCliente.TabIndex = 15;
            this.btnLimparCliente.Text = "🧻";
            this.btnLimparCliente.UseVisualStyleBackColor = true;
            this.btnLimparCliente.Click += new System.EventHandler(this.btnLimparCliente_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFechar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(155, 13);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(33, 27);
            this.btnFechar.TabIndex = 14;
            this.btnFechar.Text = "❌";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnFiltrarCliente
            // 
            this.btnFiltrarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.btnFiltrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFiltrarCliente.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarCliente.Location = new System.Drawing.Point(119, 59);
            this.btnFiltrarCliente.Name = "btnFiltrarCliente";
            this.btnFiltrarCliente.Size = new System.Drawing.Size(33, 27);
            this.btnFiltrarCliente.TabIndex = 11;
            this.btnFiltrarCliente.Text = "🔍";
            this.btnFiltrarCliente.UseVisualStyleBackColor = false;
            this.btnFiltrarCliente.Click += new System.EventHandler(this.btnFiltrarCliente_Click);
            // 
            // dtpDataFinal
            // 
            this.dtpDataFinal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFinal.Location = new System.Drawing.Point(14, 507);
            this.dtpDataFinal.Name = "dtpDataFinal";
            this.dtpDataFinal.Size = new System.Drawing.Size(139, 27);
            this.dtpDataFinal.TabIndex = 9;
            // 
            // btnFiltrarProdutosVendidos
            // 
            this.btnFiltrarProdutosVendidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.btnFiltrarProdutosVendidos.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnFiltrarProdutosVendidos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFiltrarProdutosVendidos.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarProdutosVendidos.Location = new System.Drawing.Point(53, 552);
            this.btnFiltrarProdutosVendidos.Name = "btnFiltrarProdutosVendidos";
            this.btnFiltrarProdutosVendidos.Size = new System.Drawing.Size(100, 37);
            this.btnFiltrarProdutosVendidos.TabIndex = 12;
            this.btnFiltrarProdutosVendidos.Text = "Filtrar";
            this.btnFiltrarProdutosVendidos.UseVisualStyleBackColor = false;
            this.btnFiltrarProdutosVendidos.Click += new System.EventHandler(this.btnFiltrarProdutosVendidos_Click);
            // 
            // dtpDataInicial
            // 
            this.dtpDataInicial.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicial.Location = new System.Drawing.Point(15, 443);
            this.dtpDataInicial.Name = "dtpDataInicial";
            this.dtpDataInicial.Size = new System.Drawing.Size(139, 27);
            this.dtpDataInicial.TabIndex = 8;
            this.dtpDataInicial.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            // 
            // lblDataFinal
            // 
            this.lblDataFinal.AutoSize = true;
            this.lblDataFinal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataFinal.Location = new System.Drawing.Point(10, 474);
            this.lblDataFinal.Name = "lblDataFinal";
            this.lblDataFinal.Size = new System.Drawing.Size(79, 19);
            this.lblDataFinal.TabIndex = 4;
            this.lblDataFinal.Text = "Data Final";
            // 
            // btnLimparCampos
            // 
            this.btnLimparCampos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimparCampos.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparCampos.Location = new System.Drawing.Point(14, 552);
            this.btnLimparCampos.Name = "btnLimparCampos";
            this.btnLimparCampos.Size = new System.Drawing.Size(33, 37);
            this.btnLimparCampos.TabIndex = 13;
            this.btnLimparCampos.Text = "🧻";
            this.btnLimparCampos.UseVisualStyleBackColor = true;
            this.btnLimparCampos.Click += new System.EventHandler(this.btnLimparCampos_Click);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(9, 30);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(57, 19);
            this.lblCliente.TabIndex = 2;
            this.lblCliente.Text = "Cliente";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtNomeCliente.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCliente.Location = new System.Drawing.Point(13, 57);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.ReadOnly = true;
            this.txtNomeCliente.Size = new System.Drawing.Size(100, 27);
            this.txtNomeCliente.TabIndex = 7;
            // 
            // lblDataInicial
            // 
            this.lblDataInicial.AutoSize = true;
            this.lblDataInicial.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataInicial.Location = new System.Drawing.Point(11, 410);
            this.lblDataInicial.Name = "lblDataInicial";
            this.lblDataInicial.Size = new System.Drawing.Size(88, 19);
            this.lblDataInicial.TabIndex = 3;
            this.lblDataInicial.Text = "Data Inicial";
            // 
            // labelValorParaFiltro
            // 
            this.labelValorParaFiltro.AutoSize = true;
            this.labelValorParaFiltro.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorParaFiltro.Location = new System.Drawing.Point(8, 154);
            this.labelValorParaFiltro.Name = "labelValorParaFiltro";
            this.labelValorParaFiltro.Size = new System.Drawing.Size(103, 19);
            this.labelValorParaFiltro.TabIndex = 1;
            this.labelValorParaFiltro.Text = "Valor Minimo";
            // 
            // txtValorParaFiltro
            // 
            this.txtValorParaFiltro.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtValorParaFiltro.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorParaFiltro.Location = new System.Drawing.Point(12, 181);
            this.txtValorParaFiltro.Name = "txtValorParaFiltro";
            this.txtValorParaFiltro.Size = new System.Drawing.Size(137, 27);
            this.txtValorParaFiltro.TabIndex = 6;
            this.txtValorParaFiltro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorParaFiltro_KeyPress);
            // 
            // lblRelatorioVendaProduto
            // 
            this.lblRelatorioVendaProduto.AutoSize = true;
            this.lblRelatorioVendaProduto.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelatorioVendaProduto.Location = new System.Drawing.Point(272, -38);
            this.lblRelatorioVendaProduto.Name = "lblRelatorioVendaProduto";
            this.lblRelatorioVendaProduto.Size = new System.Drawing.Size(221, 29);
            this.lblRelatorioVendaProduto.TabIndex = 28;
            this.lblRelatorioVendaProduto.Text = "Relatório de venda ";
            // 
            // dtgFiltragemDeClientes
            // 
            this.dtgFiltragemDeClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgFiltragemDeClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgFiltragemDeClientes.Location = new System.Drawing.Point(22, 131);
            this.dtgFiltragemDeClientes.Name = "dtgFiltragemDeClientes";
            this.dtgFiltragemDeClientes.Size = new System.Drawing.Size(779, 374);
            this.dtgFiltragemDeClientes.TabIndex = 27;
            // 
            // btnMenu
            // 
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMenu.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Location = new System.Drawing.Point(699, 88);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(102, 37);
            this.btnMenu.TabIndex = 30;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // lblTotalVendas
            // 
            this.lblTotalVendas.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTotalVendas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalVendas.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVendas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotalVendas.Location = new System.Drawing.Point(44, 561);
            this.lblTotalVendas.Name = "lblTotalVendas";
            this.lblTotalVendas.Size = new System.Drawing.Size(130, 25);
            this.lblTotalVendas.TabIndex = 34;
            // 
            // labelTotalVendas
            // 
            this.labelTotalVendas.AutoSize = true;
            this.labelTotalVendas.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalVendas.Location = new System.Drawing.Point(40, 537);
            this.labelTotalVendas.Name = "labelTotalVendas";
            this.labelTotalVendas.Size = new System.Drawing.Size(145, 23);
            this.labelTotalVendas.TabIndex = 39;
            this.labelTotalVendas.Text = "Total de Vendas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 28;
            this.label1.Text = "Filtrar Por:";
            // 
            // cmbFiltrarPor
            // 
            this.cmbFiltrarPor.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cmbFiltrarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltrarPor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbFiltrarPor.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFiltrarPor.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbFiltrarPor.FormattingEnabled = true;
            this.cmbFiltrarPor.Items.AddRange(new object[] {
            "Quantidade",
            "Total Desconto",
            "Total Liquido",
            " "});
            this.cmbFiltrarPor.Location = new System.Drawing.Point(13, 119);
            this.cmbFiltrarPor.Name = "cmbFiltrarPor";
            this.cmbFiltrarPor.Size = new System.Drawing.Size(136, 27);
            this.cmbFiltrarPor.TabIndex = 27;
            // 
            // FrmRelatorioCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(837, 607);
            this.Controls.Add(this.labelTotalVendas);
            this.Controls.Add(this.labelTotalDesconto);
            this.Controls.Add(this.labelTotalBruto);
            this.Controls.Add(this.lblTotalVendas);
            this.Controls.Add(this.lblTotalDesconto);
            this.Controls.Add(this.lblTotalBruto);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.lblRelatorioVendaProduto);
            this.Controls.Add(this.dtgFiltragemDeClientes);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.lblRelatorioCliente);
            this.Controls.Add(this.lblTotalLiquido);
            this.Controls.Add(this.labelTotalLiquido);
            this.Name = "FrmRelatorioCliente";
            this.Text = "FrmRelatorioCliente";
            this.Load += new System.EventHandler(this.FrmRelatorioCliente_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLimiteClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFiltragemDeClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRelatorioCliente;
        private System.Windows.Forms.Label labelTotalLiquido;
        private System.Windows.Forms.Label labelTotalDesconto;
        private System.Windows.Forms.Label labelTotalBruto;
        private System.Windows.Forms.Label lblTotalLiquido;
        private System.Windows.Forms.Label lblTotalDesconto;
        private System.Windows.Forms.Label lblTotalBruto;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.DateTimePicker dtpDataFinal;
        private System.Windows.Forms.Button btnFiltrarProdutosVendidos;
        private System.Windows.Forms.DateTimePicker dtpDataInicial;
        private System.Windows.Forms.Label lblDataFinal;
        private System.Windows.Forms.Button btnLimparCampos;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label lblDataInicial;
        private System.Windows.Forms.Label labelValorParaFiltro;
        private System.Windows.Forms.TextBox txtValorParaFiltro;
        private System.Windows.Forms.Label lblRelatorioVendaProduto;
        private System.Windows.Forms.DataGridView dtgFiltragemDeClientes;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label lblTotalVendas;
        private System.Windows.Forms.Label labelTotalVendas;
        private System.Windows.Forms.ComboBox cmbOrdemParaFiltro;
        private System.Windows.Forms.Label labelCrescenteDecrescente;
        private System.Windows.Forms.Label labelOrdernarPor;
        private System.Windows.Forms.ComboBox cmbOrdemSelecao;
        private System.Windows.Forms.NumericUpDown nudLimiteClientes;
        private System.Windows.Forms.Label labelLimitadorDeClientes;
        private System.Windows.Forms.Button btnLimparCliente;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnFiltrarCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFiltrarPor;
    }
}