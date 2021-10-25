
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGrideViewColaboradores)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrideViewColaboradores
            // 
            this.dataGrideViewColaboradores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrideViewColaboradores.Location = new System.Drawing.Point(64, 83);
            this.dataGrideViewColaboradores.Name = "dataGrideViewColaboradores";
            this.dataGrideViewColaboradores.Size = new System.Drawing.Size(650, 248);
            this.dataGrideViewColaboradores.TabIndex = 0;
            this.dataGrideViewColaboradores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrideViewColaboradores_CellContentClick);
            // 
            // labelListaColaborador
            // 
            this.labelListaColaborador.AutoSize = true;
            this.labelListaColaborador.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListaColaborador.Location = new System.Drawing.Point(183, 41);
            this.labelListaColaborador.Name = "labelListaColaborador";
            this.labelListaColaborador.Size = new System.Drawing.Size(396, 39);
            this.labelListaColaborador.TabIndex = 1;
            this.labelListaColaborador.Text = "Lista de Colaboradores";
            // 
            // FrmListaColaborador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}