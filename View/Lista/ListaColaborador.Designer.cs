
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
            this.CbColaboradoresAtivos = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrideViewColaboradores)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrideViewColaboradores
            // 
            this.dataGrideViewColaboradores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrideViewColaboradores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGrideViewColaboradores.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
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
            this.labelListaColaborador.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListaColaborador.Location = new System.Drawing.Point(12, 47);
            this.labelListaColaborador.Name = "labelListaColaborador";
            this.labelListaColaborador.Size = new System.Drawing.Size(224, 25);
            this.labelListaColaborador.TabIndex = 1;
            this.labelListaColaborador.Text = "Lista de Colaboradores";
            // 
            // btnExibirCadastroColaborador
            // 
            this.btnExibirCadastroColaborador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.btnExibirCadastroColaborador.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExibirCadastroColaborador.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibirCadastroColaborador.Location = new System.Drawing.Point(307, 352);
            this.btnExibirCadastroColaborador.Name = "btnExibirCadastroColaborador";
            this.btnExibirCadastroColaborador.Size = new System.Drawing.Size(164, 36);
            this.btnExibirCadastroColaborador.TabIndex = 2;
            this.btnExibirCadastroColaborador.Text = "Exibir Cadastro";
            this.btnExibirCadastroColaborador.UseVisualStyleBackColor = false;
            this.btnExibirCadastroColaborador.Click += new System.EventHandler(this.btnExibirCadastroColaborador_Click);
            // 
            // txtFiltrarColaborador
            // 
            this.txtFiltrarColaborador.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltrarColaborador.Location = new System.Drawing.Point(242, 45);
            this.txtFiltrarColaborador.Name = "txtFiltrarColaborador";
            this.txtFiltrarColaborador.Size = new System.Drawing.Size(204, 31);
            this.txtFiltrarColaborador.TabIndex = 25;
            // 
            // btnFiltrarColaborador
            // 
            this.btnFiltrarColaborador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.btnFiltrarColaborador.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFiltrarColaborador.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarColaborador.Location = new System.Drawing.Point(452, 45);
            this.btnFiltrarColaborador.Name = "btnFiltrarColaborador";
            this.btnFiltrarColaborador.Size = new System.Drawing.Size(167, 31);
            this.btnFiltrarColaborador.TabIndex = 24;
            this.btnFiltrarColaborador.Text = "Filtrar por nome";
            this.btnFiltrarColaborador.UseVisualStyleBackColor = false;
            this.btnFiltrarColaborador.Click += new System.EventHandler(this.btnFiltrarColaborador_Click);
            // 
            // CbColaboradoresAtivos
            // 
            this.CbColaboradoresAtivos.AutoSize = true;
            this.CbColaboradoresAtivos.Checked = true;
            this.CbColaboradoresAtivos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbColaboradoresAtivos.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbColaboradoresAtivos.Location = new System.Drawing.Point(635, 45);
            this.CbColaboradoresAtivos.Name = "CbColaboradoresAtivos";
            this.CbColaboradoresAtivos.Size = new System.Drawing.Size(226, 29);
            this.CbColaboradoresAtivos.TabIndex = 26;
            this.CbColaboradoresAtivos.Text = "Colaboradores Ativos";
            this.CbColaboradoresAtivos.UseVisualStyleBackColor = true;
            // 
            // FrmListaColaborador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(875, 412);
            this.Controls.Add(this.CbColaboradoresAtivos);
            this.Controls.Add(this.txtFiltrarColaborador);
            this.Controls.Add(this.btnFiltrarColaborador);
            this.Controls.Add(this.btnExibirCadastroColaborador);
            this.Controls.Add(this.labelListaColaborador);
            this.Controls.Add(this.dataGrideViewColaboradores);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
        private System.Windows.Forms.CheckBox CbColaboradoresAtivos;
    }
}