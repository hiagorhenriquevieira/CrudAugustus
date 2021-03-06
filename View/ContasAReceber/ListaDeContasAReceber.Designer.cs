
namespace CrudAugustusFashion.View.ContasAReceber
{
    partial class FrmListaDeContasAReceber
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
            this.dataGridViewConsulta = new System.Windows.Forms.DataGridView();
            this.btnPagarConta = new System.Windows.Forms.Button();
            this.CbContasPendentes = new System.Windows.Forms.CheckBox();
            this.txtFiltrarCliente = new System.Windows.Forms.TextBox();
            this.btnFiltrarCliente = new System.Windows.Forms.Button();
            this.labelListagemClientes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewConsulta
            // 
            this.dataGridViewConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewConsulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewConsulta.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConsulta.Location = new System.Drawing.Point(81, 136);
            this.dataGridViewConsulta.Name = "dataGridViewConsulta";
            this.dataGridViewConsulta.ReadOnly = true;
            this.dataGridViewConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewConsulta.Size = new System.Drawing.Size(847, 485);
            this.dataGridViewConsulta.TabIndex = 1;
            // 
            // btnPagarConta
            // 
            this.btnPagarConta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPagarConta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.btnPagarConta.FlatAppearance.BorderSize = 0;
            this.btnPagarConta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPagarConta.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagarConta.Location = new System.Drawing.Point(81, 627);
            this.btnPagarConta.Name = "btnPagarConta";
            this.btnPagarConta.Size = new System.Drawing.Size(150, 31);
            this.btnPagarConta.TabIndex = 71;
            this.btnPagarConta.Text = "Pagar Conta";
            this.btnPagarConta.UseVisualStyleBackColor = false;
            this.btnPagarConta.Click += new System.EventHandler(this.btnPagarConta_Click);
            // 
            // CbContasPendentes
            // 
            this.CbContasPendentes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CbContasPendentes.AutoSize = true;
            this.CbContasPendentes.Checked = true;
            this.CbContasPendentes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbContasPendentes.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbContasPendentes.Location = new System.Drawing.Point(730, 97);
            this.CbContasPendentes.Name = "CbContasPendentes";
            this.CbContasPendentes.Size = new System.Drawing.Size(198, 29);
            this.CbContasPendentes.TabIndex = 76;
            this.CbContasPendentes.Text = "Contas Pendentes";
            this.CbContasPendentes.UseVisualStyleBackColor = true;
            // 
            // txtFiltrarCliente
            // 
            this.txtFiltrarCliente.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltrarCliente.Location = new System.Drawing.Point(81, 97);
            this.txtFiltrarCliente.Name = "txtFiltrarCliente";
            this.txtFiltrarCliente.Size = new System.Drawing.Size(204, 33);
            this.txtFiltrarCliente.TabIndex = 1;
            // 
            // btnFiltrarCliente
            // 
            this.btnFiltrarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.btnFiltrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFiltrarCliente.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarCliente.Location = new System.Drawing.Point(291, 96);
            this.btnFiltrarCliente.Name = "btnFiltrarCliente";
            this.btnFiltrarCliente.Size = new System.Drawing.Size(110, 34);
            this.btnFiltrarCliente.TabIndex = 2;
            this.btnFiltrarCliente.Text = "Filtrar";
            this.btnFiltrarCliente.UseVisualStyleBackColor = false;
            this.btnFiltrarCliente.Click += new System.EventHandler(this.btnFiltrarCliente_Click);
            // 
            // labelListagemClientes
            // 
            this.labelListagemClientes.AutoSize = true;
            this.labelListagemClientes.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListagemClientes.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelListagemClientes.Location = new System.Drawing.Point(76, 65);
            this.labelListagemClientes.Name = "labelListagemClientes";
            this.labelListagemClientes.Size = new System.Drawing.Size(199, 29);
            this.labelListagemClientes.TabIndex = 73;
            this.labelListagemClientes.Text = "Lista de clientes :";
            // 
            // FrmListaDeContasAReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.CbContasPendentes);
            this.Controls.Add(this.txtFiltrarCliente);
            this.Controls.Add(this.btnFiltrarCliente);
            this.Controls.Add(this.labelListagemClientes);
            this.Controls.Add(this.btnPagarConta);
            this.Controls.Add(this.dataGridViewConsulta);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Name = "FrmListaDeContasAReceber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListaDeContasAReceber";
            this.Load += new System.EventHandler(this.ListaDeContasAReceber_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewConsulta;
        private System.Windows.Forms.Button btnPagarConta;
        private System.Windows.Forms.CheckBox CbContasPendentes;
        private System.Windows.Forms.TextBox txtFiltrarCliente;
        private System.Windows.Forms.Button btnFiltrarCliente;
        private System.Windows.Forms.Label labelListagemClientes;
    }
}