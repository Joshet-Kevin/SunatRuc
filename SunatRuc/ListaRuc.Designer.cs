
namespace SunatRuc
{
    partial class ListaRuc
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
            this.gvListaResultados = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvListaResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // gvListaResultados
            // 
            this.gvListaResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvListaResultados.Location = new System.Drawing.Point(22, 54);
            this.gvListaResultados.Name = "gvListaResultados";
            this.gvListaResultados.Size = new System.Drawing.Size(1053, 453);
            this.gvListaResultados.TabIndex = 0;
            this.gvListaResultados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvListaResultados_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(22, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Consulta Ruc";
            // 
            // ListaRuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 519);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvListaResultados);
            this.Name = "ListaRuc";
            this.Text = "ListaRuc";
            ((System.ComponentModel.ISupportInitialize)(this.gvListaResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvListaResultados;
        private System.Windows.Forms.Label label1;
    }
}