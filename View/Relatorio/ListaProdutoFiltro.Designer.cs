
namespace CrudAugustusFashion.View.Relatorio
{
    partial class FrmListaProdutoFiltro
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
            this.lblNomeDoProduto = new System.Windows.Forms.Label();
            this.txtFiltrarPorProduto = new System.Windows.Forms.TextBox();
            this.dtgVisualizarProduto = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVisualizarProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFiltrar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.Location = new System.Drawing.Point(202, 65);
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
            this.lblFiltroDeCliente.Location = new System.Drawing.Point(312, 3);
            this.lblFiltroDeCliente.Name = "lblFiltroDeCliente";
            this.lblFiltroDeCliente.Size = new System.Drawing.Size(0, 29);
            this.lblFiltroDeCliente.TabIndex = 8;
            // 
            // lblNomeDoProduto
            // 
            this.lblNomeDoProduto.AutoSize = true;
            this.lblNomeDoProduto.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeDoProduto.Location = new System.Drawing.Point(24, 43);
            this.lblNomeDoProduto.Name = "lblNomeDoProduto";
            this.lblNomeDoProduto.Size = new System.Drawing.Size(65, 19);
            this.lblNomeDoProduto.TabIndex = 7;
            this.lblNomeDoProduto.Text = "Produto";
            // 
            // txtFiltrarPorProduto
            // 
            this.txtFiltrarPorProduto.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltrarPorProduto.Location = new System.Drawing.Point(28, 65);
            this.txtFiltrarPorProduto.Name = "txtFiltrarPorProduto";
            this.txtFiltrarPorProduto.Size = new System.Drawing.Size(168, 27);
            this.txtFiltrarPorProduto.TabIndex = 6;
            // 
            // dtgVisualizarProduto
            // 
            this.dtgVisualizarProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVisualizarProduto.Location = new System.Drawing.Point(28, 108);
            this.dtgVisualizarProduto.Name = "dtgVisualizarProduto";
            this.dtgVisualizarProduto.ReadOnly = true;
            this.dtgVisualizarProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgVisualizarProduto.Size = new System.Drawing.Size(685, 216);
            this.dtgVisualizarProduto.TabIndex = 5;
            this.dtgVisualizarProduto.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgVisualizarProduto_CellContentDoubleClick);
            // 
            // FrmListaProdutoFiltro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 364);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.lblFiltroDeCliente);
            this.Controls.Add(this.lblNomeDoProduto);
            this.Controls.Add(this.txtFiltrarPorProduto);
            this.Controls.Add(this.dtgVisualizarProduto);
            this.Name = "FrmListaProdutoFiltro";
            this.Text = "ListaProdutoFiltro";
            this.Load += new System.EventHandler(this.ListaProdutoFiltro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgVisualizarProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label lblFiltroDeCliente;
        private System.Windows.Forms.Label lblNomeDoProduto;
        private System.Windows.Forms.TextBox txtFiltrarPorProduto;
        private System.Windows.Forms.DataGridView dtgVisualizarProduto;
    }
}