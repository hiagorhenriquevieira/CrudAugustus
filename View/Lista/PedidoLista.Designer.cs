﻿
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
            this.btnExibirItemListaPedido = new System.Windows.Forms.Button();
            this.txtFiltrarPedido = new System.Windows.Forms.TextBox();
            this.btnFiltrarPedidoProduto = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidoLista)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPedidoLista
            // 
            this.dataGridViewPedidoLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPedidoLista.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewPedidoLista.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewPedidoLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPedidoLista.Location = new System.Drawing.Point(62, 104);
            this.dataGridViewPedidoLista.MultiSelect = false;
            this.dataGridViewPedidoLista.Name = "dataGridViewPedidoLista";
            this.dataGridViewPedidoLista.ReadOnly = true;
            this.dataGridViewPedidoLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPedidoLista.Size = new System.Drawing.Size(761, 214);
            this.dataGridViewPedidoLista.TabIndex = 1;
            this.dataGridViewPedidoLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPedidoLista_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Listagem de pedidos";
            // 
            // btnExibirItemListaPedido
            // 
            this.btnExibirItemListaPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.btnExibirItemListaPedido.FlatAppearance.BorderSize = 0;
            this.btnExibirItemListaPedido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExibirItemListaPedido.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibirItemListaPedido.Location = new System.Drawing.Point(62, 337);
            this.btnExibirItemListaPedido.Name = "btnExibirItemListaPedido";
            this.btnExibirItemListaPedido.Size = new System.Drawing.Size(150, 31);
            this.btnExibirItemListaPedido.TabIndex = 3;
            this.btnExibirItemListaPedido.Text = "Exibir pedido";
            this.btnExibirItemListaPedido.UseVisualStyleBackColor = false;
            this.btnExibirItemListaPedido.Click += new System.EventHandler(this.btnSelecionarItemListaPedido_Click);
            // 
            // txtFiltrarPedido
            // 
            this.txtFiltrarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltrarPedido.Location = new System.Drawing.Point(461, 59);
            this.txtFiltrarPedido.Name = "txtFiltrarPedido";
            this.txtFiltrarPedido.Size = new System.Drawing.Size(204, 26);
            this.txtFiltrarPedido.TabIndex = 21;
            this.txtFiltrarPedido.TextChanged += new System.EventHandler(this.txtFiltrarPedido_TextChanged);
            // 
            // btnFiltrarPedidoProduto
            // 
            this.btnFiltrarPedidoProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.btnFiltrarPedidoProduto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFiltrarPedidoProduto.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarPedidoProduto.Location = new System.Drawing.Point(671, 59);
            this.btnFiltrarPedidoProduto.Name = "btnFiltrarPedidoProduto";
            this.btnFiltrarPedidoProduto.Size = new System.Drawing.Size(152, 26);
            this.btnFiltrarPedidoProduto.TabIndex = 22;
            this.btnFiltrarPedidoProduto.Text = "Filtrar";
            this.btnFiltrarPedidoProduto.UseVisualStyleBackColor = false;
            this.btnFiltrarPedidoProduto.Click += new System.EventHandler(this.btnFiltrarPedidoProduto_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(148)))), ((int)(((byte)(250)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(218, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 31);
            this.button1.TabIndex = 23;
            this.button1.Text = "Alterar Pedido";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // FrmPedidoLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(953, 524);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnFiltrarPedidoProduto);
            this.Controls.Add(this.txtFiltrarPedido);
            this.Controls.Add(this.btnExibirItemListaPedido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewPedidoLista);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmPedidoLista";
            this.Load += new System.EventHandler(this.PedidoLista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidoLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPedidoLista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFiltrarPedido;
        private System.Windows.Forms.Button btnFiltrarPedidoProduto;
        private System.Windows.Forms.Button btnExibirItemListaPedido;
        private System.Windows.Forms.Button button1;
    }
}