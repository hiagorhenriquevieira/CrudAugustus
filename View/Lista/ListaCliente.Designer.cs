
namespace CrudAugustusFashion.View
{
    partial class FrmListaCliente
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
            this.labelListagemClientes = new System.Windows.Forms.Label();
            this.dataGridViewListaClientes = new System.Windows.Forms.DataGridView();
            this.btnExibirCadastroCliente = new System.Windows.Forms.Button();
            this.btnFiltrarCliente = new System.Windows.Forms.Button();
            this.txtFiltrarCliente = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // labelListagemClientes
            // 
            this.labelListagemClientes.AutoSize = true;
            this.labelListagemClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListagemClientes.Location = new System.Drawing.Point(12, 19);
            this.labelListagemClientes.Name = "labelListagemClientes";
            this.labelListagemClientes.Size = new System.Drawing.Size(304, 39);
            this.labelListagemClientes.TabIndex = 1;
            this.labelListagemClientes.Text = "Lista de clientes :";
            // 
            // dataGridViewListaClientes
            // 
            this.dataGridViewListaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListaClientes.Location = new System.Drawing.Point(12, 77);
            this.dataGridViewListaClientes.Name = "dataGridViewListaClientes";
            this.dataGridViewListaClientes.Size = new System.Drawing.Size(1112, 403);
            this.dataGridViewListaClientes.TabIndex = 0;
            this.dataGridViewListaClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewListaClientes_CellContentClick);
            // 
            // btnExibirCadastroCliente
            // 
            this.btnExibirCadastroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibirCadastroCliente.Location = new System.Drawing.Point(318, 506);
            this.btnExibirCadastroCliente.Name = "btnExibirCadastroCliente";
            this.btnExibirCadastroCliente.Size = new System.Drawing.Size(388, 55);
            this.btnExibirCadastroCliente.TabIndex = 21;
            this.btnExibirCadastroCliente.Text = "Exibir cadastro";
            this.btnExibirCadastroCliente.UseVisualStyleBackColor = true;
            this.btnExibirCadastroCliente.Click += new System.EventHandler(this.btnExibirCadastroCliente_Click);
            // 
            // btnFiltrarCliente
            // 
            this.btnFiltrarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarCliente.Location = new System.Drawing.Point(703, 19);
            this.btnFiltrarCliente.Name = "btnFiltrarCliente";
            this.btnFiltrarCliente.Size = new System.Drawing.Size(211, 31);
            this.btnFiltrarCliente.TabIndex = 22;
            this.btnFiltrarCliente.Text = "Filtrar por nome";
            this.btnFiltrarCliente.UseVisualStyleBackColor = true;
            // 
            // txtFiltrarCliente
            // 
            this.txtFiltrarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltrarCliente.Location = new System.Drawing.Point(920, 19);
            this.txtFiltrarCliente.Name = "txtFiltrarCliente";
            this.txtFiltrarCliente.Size = new System.Drawing.Size(204, 31);
            this.txtFiltrarCliente.TabIndex = 23;
            // 
            // FrmListaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 601);
            this.Controls.Add(this.txtFiltrarCliente);
            this.Controls.Add(this.btnFiltrarCliente);
            this.Controls.Add(this.btnExibirCadastroCliente);
            this.Controls.Add(this.labelListagemClientes);
            this.Controls.Add(this.dataGridViewListaClientes);
            this.Name = "FrmListaCliente";
            this.Text = "Listagem de clientes";
            this.Load += new System.EventHandler(this.frmListaCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelListagemClientes;
        private System.Windows.Forms.DataGridView dataGridViewListaClientes;
        private System.Windows.Forms.Button btnExibirCadastroCliente;
        private System.Windows.Forms.Button btnFiltrarCliente;
        private System.Windows.Forms.TextBox txtFiltrarCliente;
    }
}