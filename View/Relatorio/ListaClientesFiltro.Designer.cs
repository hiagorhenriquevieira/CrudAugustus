
namespace CrudAugustusFashion.View.Relatorio
{
    partial class FrmListaClientesFiltro
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
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.lblFiltroDeCliente = new System.Windows.Forms.Label();
            this.lblNomeDoCliente = new System.Windows.Forms.Label();
            this.txtFiltrarPorNome = new System.Windows.Forms.TextBox();
            this.dtgVisualizarCliente = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVisualizarCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFiltrar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.Location = new System.Drawing.Point(198, 77);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(47, 29);
            this.btnFiltrar.TabIndex = 9;
            this.btnFiltrar.Text = "🔍";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // lblFiltroDeCliente
            // 
            this.lblFiltroDeCliente.AutoSize = true;
            this.lblFiltroDeCliente.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroDeCliente.Location = new System.Drawing.Point(308, 15);
            this.lblFiltroDeCliente.Name = "lblFiltroDeCliente";
            this.lblFiltroDeCliente.Size = new System.Drawing.Size(0, 29);
            this.lblFiltroDeCliente.TabIndex = 8;
            // 
            // lblNomeDoCliente
            // 
            this.lblNomeDoCliente.AutoSize = true;
            this.lblNomeDoCliente.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeDoCliente.Location = new System.Drawing.Point(20, 55);
            this.lblNomeDoCliente.Name = "lblNomeDoCliente";
            this.lblNomeDoCliente.Size = new System.Drawing.Size(57, 19);
            this.lblNomeDoCliente.TabIndex = 7;
            this.lblNomeDoCliente.Text = "Cliente";
            // 
            // txtFiltrarPorNome
            // 
            this.txtFiltrarPorNome.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltrarPorNome.Location = new System.Drawing.Point(24, 77);
            this.txtFiltrarPorNome.Name = "txtFiltrarPorNome";
            this.txtFiltrarPorNome.Size = new System.Drawing.Size(168, 27);
            this.txtFiltrarPorNome.TabIndex = 6;
            // 
            // dtgVisualizarCliente
            // 
            this.dtgVisualizarCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVisualizarCliente.Location = new System.Drawing.Point(23, 119);
            this.dtgVisualizarCliente.Name = "dtgVisualizarCliente";
            this.dtgVisualizarCliente.ReadOnly = true;
            this.dtgVisualizarCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgVisualizarCliente.Size = new System.Drawing.Size(685, 216);
            this.dtgVisualizarCliente.TabIndex = 5;
            this.dtgVisualizarCliente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgVisualizarCliente_CellDoubleClick);
            // 
            // FrmListaClientesFiltro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 364);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.lblFiltroDeCliente);
            this.Controls.Add(this.lblNomeDoCliente);
            this.Controls.Add(this.txtFiltrarPorNome);
            this.Controls.Add(this.dtgVisualizarCliente);
            this.Name = "FrmListaClientesFiltro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListaClientesFiltro";
            ((System.ComponentModel.ISupportInitialize)(this.dtgVisualizarCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label lblFiltroDeCliente;
        private System.Windows.Forms.Label lblNomeDoCliente;
        private System.Windows.Forms.TextBox txtFiltrarPorNome;
        private System.Windows.Forms.DataGridView dtgVisualizarCliente;
    }
}