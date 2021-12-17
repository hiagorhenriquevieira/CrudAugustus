
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
            this.CbAtivarClientes = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // labelListagemClientes
            // 
            this.labelListagemClientes.AutoSize = true;
            this.labelListagemClientes.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListagemClientes.Location = new System.Drawing.Point(305, 38);
            this.labelListagemClientes.Name = "labelListagemClientes";
            this.labelListagemClientes.Size = new System.Drawing.Size(243, 39);
            this.labelListagemClientes.TabIndex = 1;
            this.labelListagemClientes.Text = "Lista de clientes";
            // 
            // dataGridViewListaClientes
            // 
            this.dataGridViewListaClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewListaClientes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewListaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListaClientes.Location = new System.Drawing.Point(19, 197);
            this.dataGridViewListaClientes.MultiSelect = false;
            this.dataGridViewListaClientes.Name = "dataGridViewListaClientes";
            this.dataGridViewListaClientes.ReadOnly = true;
            this.dataGridViewListaClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewListaClientes.Size = new System.Drawing.Size(913, 358);
            this.dataGridViewListaClientes.TabIndex = 0;
            this.dataGridViewListaClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewListaClientes_CellContentClick);
            // 
            // btnExibirCadastroCliente
            // 
            this.btnExibirCadastroCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.btnExibirCadastroCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExibirCadastroCliente.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibirCadastroCliente.Location = new System.Drawing.Point(19, 577);
            this.btnExibirCadastroCliente.Name = "btnExibirCadastroCliente";
            this.btnExibirCadastroCliente.Size = new System.Drawing.Size(211, 37);
            this.btnExibirCadastroCliente.TabIndex = 21;
            this.btnExibirCadastroCliente.Text = "Exibir cadastro";
            this.btnExibirCadastroCliente.UseVisualStyleBackColor = false;
            this.btnExibirCadastroCliente.Click += new System.EventHandler(this.btnExibirCadastroCliente_Click);
            // 
            // btnFiltrarCliente
            // 
            this.btnFiltrarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.btnFiltrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFiltrarCliente.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarCliente.Location = new System.Drawing.Point(388, 150);
            this.btnFiltrarCliente.Name = "btnFiltrarCliente";
            this.btnFiltrarCliente.Size = new System.Drawing.Size(211, 34);
            this.btnFiltrarCliente.TabIndex = 22;
            this.btnFiltrarCliente.Text = "Filtrar por nome";
            this.btnFiltrarCliente.UseVisualStyleBackColor = false;
            this.btnFiltrarCliente.Click += new System.EventHandler(this.btnFiltrarCliente_Click);
            // 
            // txtFiltrarCliente
            // 
            this.txtFiltrarCliente.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltrarCliente.Location = new System.Drawing.Point(100, 151);
            this.txtFiltrarCliente.Name = "txtFiltrarCliente";
            this.txtFiltrarCliente.Size = new System.Drawing.Size(273, 33);
            this.txtFiltrarCliente.TabIndex = 23;
            // 
            // CbAtivarClientes
            // 
            this.CbAtivarClientes.AutoSize = true;
            this.CbAtivarClientes.Checked = true;
            this.CbAtivarClientes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbAtivarClientes.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbAtivarClientes.Location = new System.Drawing.Point(766, 143);
            this.CbAtivarClientes.Name = "CbAtivarClientes";
            this.CbAtivarClientes.Size = new System.Drawing.Size(166, 29);
            this.CbAtivarClientes.TabIndex = 24;
            this.CbAtivarClientes.Text = "Clientes Ativos";
            this.CbAtivarClientes.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "Nome :";
            // 
            // FrmListaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CbAtivarClientes);
            this.Controls.Add(this.txtFiltrarCliente);
            this.Controls.Add(this.btnFiltrarCliente);
            this.Controls.Add(this.btnExibirCadastroCliente);
            this.Controls.Add(this.labelListagemClientes);
            this.Controls.Add(this.dataGridViewListaClientes);
            this.Name = "FrmListaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.CheckBox CbAtivarClientes;
        private System.Windows.Forms.Label label1;
    }
}