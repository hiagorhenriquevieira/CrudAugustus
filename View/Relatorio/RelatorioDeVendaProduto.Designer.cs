
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
            ((System.ComponentModel.ISupportInitialize)(this.dtgFiltragemDeVendas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgFiltragemDeVendas
            // 
            this.dtgFiltragemDeVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgFiltragemDeVendas.Location = new System.Drawing.Point(59, 288);
            this.dtgFiltragemDeVendas.Name = "dtgFiltragemDeVendas";
            this.dtgFiltragemDeVendas.Size = new System.Drawing.Size(711, 271);
            this.dtgFiltragemDeVendas.TabIndex = 0;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto.Location = new System.Drawing.Point(132, 75);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(65, 19);
            this.lblProduto.TabIndex = 1;
            this.lblProduto.Text = "Produto";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(132, 154);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(57, 19);
            this.lblCliente.TabIndex = 2;
            this.lblCliente.Text = "Cliente";
            // 
            // lblDataInicial
            // 
            this.lblDataInicial.AutoSize = true;
            this.lblDataInicial.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataInicial.Location = new System.Drawing.Point(536, 75);
            this.lblDataInicial.Name = "lblDataInicial";
            this.lblDataInicial.Size = new System.Drawing.Size(88, 19);
            this.lblDataInicial.TabIndex = 3;
            this.lblDataInicial.Text = "Data Inicial";
            // 
            // lblDataFinal
            // 
            this.lblDataFinal.AutoSize = true;
            this.lblDataFinal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataFinal.Location = new System.Drawing.Point(536, 144);
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
            this.txtNomeProduto.Location = new System.Drawing.Point(136, 104);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(100, 27);
            this.txtNomeProduto.TabIndex = 6;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCliente.Location = new System.Drawing.Point(136, 176);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(100, 27);
            this.txtNomeCliente.TabIndex = 7;
            // 
            // dtpDataInicial
            // 
            this.dtpDataInicial.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicial.Location = new System.Drawing.Point(540, 97);
            this.dtpDataInicial.Name = "dtpDataInicial";
            this.dtpDataInicial.Size = new System.Drawing.Size(136, 27);
            this.dtpDataInicial.TabIndex = 8;
            this.dtpDataInicial.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            // 
            // dtpDataFinal
            // 
            this.dtpDataFinal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFinal.Location = new System.Drawing.Point(540, 173);
            this.dtpDataFinal.Name = "dtpDataFinal";
            this.dtpDataFinal.Size = new System.Drawing.Size(136, 27);
            this.dtpDataFinal.TabIndex = 9;
            // 
            // btnFiltrarProduto
            // 
            this.btnFiltrarProduto.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarProduto.Location = new System.Drawing.Point(242, 104);
            this.btnFiltrarProduto.Name = "btnFiltrarProduto";
            this.btnFiltrarProduto.Size = new System.Drawing.Size(33, 27);
            this.btnFiltrarProduto.TabIndex = 10;
            this.btnFiltrarProduto.Text = "🔍";
            this.btnFiltrarProduto.UseVisualStyleBackColor = true;
            this.btnFiltrarProduto.Click += new System.EventHandler(this.btnFiltrarProduto_Click);
            // 
            // btnFiltrarCliente
            // 
            this.btnFiltrarCliente.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarCliente.Location = new System.Drawing.Point(242, 175);
            this.btnFiltrarCliente.Name = "btnFiltrarCliente";
            this.btnFiltrarCliente.Size = new System.Drawing.Size(33, 27);
            this.btnFiltrarCliente.TabIndex = 11;
            this.btnFiltrarCliente.Text = "🔍";
            this.btnFiltrarCliente.UseVisualStyleBackColor = true;
            this.btnFiltrarCliente.Click += new System.EventHandler(this.btnFiltrarCliente_Click);
            // 
            // btnFiltrarProdutosVendidos
            // 
            this.btnFiltrarProdutosVendidos.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarProdutosVendidos.Location = new System.Drawing.Point(358, 248);
            this.btnFiltrarProdutosVendidos.Name = "btnFiltrarProdutosVendidos";
            this.btnFiltrarProdutosVendidos.Size = new System.Drawing.Size(108, 34);
            this.btnFiltrarProdutosVendidos.TabIndex = 12;
            this.btnFiltrarProdutosVendidos.Text = "Filtrar";
            this.btnFiltrarProdutosVendidos.UseVisualStyleBackColor = true;
            this.btnFiltrarProdutosVendidos.Click += new System.EventHandler(this.btnFiltrarProdutosVendidos_Click);
            // 
            // FrmRelatorioDeVendaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 607);
            this.Controls.Add(this.btnFiltrarProdutosVendidos);
            this.Controls.Add(this.btnFiltrarCliente);
            this.Controls.Add(this.btnFiltrarProduto);
            this.Controls.Add(this.dtpDataFinal);
            this.Controls.Add(this.dtpDataInicial);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.lblRelatorioVendaProduto);
            this.Controls.Add(this.lblDataFinal);
            this.Controls.Add(this.lblDataInicial);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.dtgFiltragemDeVendas);
            this.Name = "FrmRelatorioDeVendaProduto";
            this.Text = "Relatorio de venda";
            ((System.ComponentModel.ISupportInitialize)(this.dtgFiltragemDeVendas)).EndInit();
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
    }
}