
namespace CrudAugustusFashion.View
{
    partial class FrmListaColaborador
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
            this.dataGrideViewColaboradores = new System.Windows.Forms.DataGridView();
            this.labelListaColaborador = new System.Windows.Forms.Label();
            this.btnExibirCadastroColaborador = new System.Windows.Forms.Button();
            this.txtFiltrarColaborador = new System.Windows.Forms.TextBox();
            this.btnFiltrarColaborador = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrideViewColaboradores)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrideViewColaboradores
            // 
            this.dataGrideViewColaboradores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrideViewColaboradores.Location = new System.Drawing.Point(12, 83);
            this.dataGrideViewColaboradores.MultiSelect = false;
            this.dataGrideViewColaboradores.Name = "dataGrideViewColaboradores";
            this.dataGrideViewColaboradores.ReadOnly = true;
            this.dataGrideViewColaboradores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrideViewColaboradores.Size = new System.Drawing.Size(849, 229);
            this.dataGrideViewColaboradores.TabIndex = 0;
            // 
            // labelListaColaborador
            // 
            this.labelListaColaborador.AutoSize = true;
            this.labelListaColaborador.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListaColaborador.Location = new System.Drawing.Point(5, 41);
            this.labelListaColaborador.Name = "labelListaColaborador";
            this.labelListaColaborador.Size = new System.Drawing.Size(396, 39);
            this.labelListaColaborador.TabIndex = 1;
            this.labelListaColaborador.Text = "Lista de Colaboradores";
            // 
            // btnExibirCadastroColaborador
            // 
            this.btnExibirCadastroColaborador.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibirCadastroColaborador.Location = new System.Drawing.Point(231, 349);
            this.btnExibirCadastroColaborador.Name = "btnExibirCadastroColaborador";
            this.btnExibirCadastroColaborador.Size = new System.Drawing.Size(286, 54);
            this.btnExibirCadastroColaborador.TabIndex = 2;
            this.btnExibirCadastroColaborador.Text = "Exibir Cadastro";
            this.btnExibirCadastroColaborador.UseVisualStyleBackColor = true;
            this.btnExibirCadastroColaborador.Click += new System.EventHandler(this.btnExibirCadastroColaborador_Click);
            // 
            // txtFiltrarColaborador
            // 
            this.txtFiltrarColaborador.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltrarColaborador.Location = new System.Drawing.Point(440, 46);
            this.txtFiltrarColaborador.Name = "txtFiltrarColaborador";
            this.txtFiltrarColaborador.Size = new System.Drawing.Size(204, 31);
            this.txtFiltrarColaborador.TabIndex = 25;
            // 
            // btnFiltrarColaborador
            // 
            this.btnFiltrarColaborador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarColaborador.Location = new System.Drawing.Point(650, 46);
            this.btnFiltrarColaborador.Name = "btnFiltrarColaborador";
            this.btnFiltrarColaborador.Size = new System.Drawing.Size(211, 31);
            this.btnFiltrarColaborador.TabIndex = 24;
            this.btnFiltrarColaborador.Text = "Filtrar por nome";
            this.btnFiltrarColaborador.UseVisualStyleBackColor = true;
            this.btnFiltrarColaborador.Click += new System.EventHandler(this.btnFiltrarColaborador_Click);
            // 
            // FrmListaColaborador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 412);
            this.Controls.Add(this.txtFiltrarColaborador);
            this.Controls.Add(this.btnFiltrarColaborador);
            this.Controls.Add(this.btnExibirCadastroColaborador);
            this.Controls.Add(this.labelListaColaborador);
            this.Controls.Add(this.dataGrideViewColaboradores);
            this.Name = "FrmListaColaborador";
            this.Load += new System.EventHandler(this.FrmListaColaborador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrideViewColaboradores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrideViewColaboradores;
        private System.Windows.Forms.Label labelListaColaborador;
        private System.Windows.Forms.Button btnExibirCadastroColaborador;
        private System.Windows.Forms.TextBox txtFiltrarColaborador;
        private System.Windows.Forms.Button btnFiltrarColaborador;
    }
}