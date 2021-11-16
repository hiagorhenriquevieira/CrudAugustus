
namespace CrudAugustusFashion.View.Lista
{
    partial class FrmPedidoLista
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
            this.dataGridViewPedidoLista = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelecionarItemListaPedido = new System.Windows.Forms.Button();
            this.txtPedidoProduto = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidoLista)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPedidoLista
            // 
            this.dataGridViewPedidoLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewPedidoLista.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewPedidoLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPedidoLista.Location = new System.Drawing.Point(62, 104);
            this.dataGridViewPedidoLista.MultiSelect = false;
            this.dataGridViewPedidoLista.Name = "dataGridViewPedidoLista";
            this.dataGridViewPedidoLista.ReadOnly = true;
            this.dataGridViewPedidoLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPedidoLista.Size = new System.Drawing.Size(761, 214);
            this.dataGridViewPedidoLista.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lista pedido produto";
            // 
            // btnSelecionarItemListaPedido
            // 
            this.btnSelecionarItemListaPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionarItemListaPedido.Location = new System.Drawing.Point(327, 358);
            this.btnSelecionarItemListaPedido.Name = "btnSelecionarItemListaPedido";
            this.btnSelecionarItemListaPedido.Size = new System.Drawing.Size(186, 63);
            this.btnSelecionarItemListaPedido.TabIndex = 3;
            this.btnSelecionarItemListaPedido.Text = "Selecionar produto";
            this.btnSelecionarItemListaPedido.UseVisualStyleBackColor = true;
            this.btnSelecionarItemListaPedido.Click += new System.EventHandler(this.btnSelecionarItemListaPedido_Click);
            // 
            // txtPedidoProduto
            // 
            this.txtPedidoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPedidoProduto.Location = new System.Drawing.Point(542, 58);
            this.txtPedidoProduto.Name = "txtPedidoProduto";
            this.txtPedidoProduto.Size = new System.Drawing.Size(159, 26);
            this.txtPedidoProduto.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(718, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 26);
            this.button1.TabIndex = 22;
            this.button1.Text = "Filtrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmPedidoLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPedidoProduto);
            this.Controls.Add(this.btnSelecionarItemListaPedido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewPedidoLista);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmPedidoLista";
            this.Load += new System.EventHandler(this.PedidoLista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidoLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPedidoLista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelecionarItemListaPedido;
        private System.Windows.Forms.TextBox txtPedidoProduto;
        private System.Windows.Forms.Button button1;
    }
}