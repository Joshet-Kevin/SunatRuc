
namespace SunatRuc
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.cbDocumento = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtRuc = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRuc = new System.Windows.Forms.Button();
            this.btnRazonSocial = new System.Windows.Forms.Button();
            this.btnDocumento = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consulta RUC";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelContenedor);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1136, 502);
            this.panel1.TabIndex = 1;
            // 
            // panelContenedor
            // 
            this.panelContenedor.Controls.Add(this.cbDocumento);
            this.panelContenedor.Controls.Add(this.btnBuscar);
            this.panelContenedor.Controls.Add(this.txtRuc);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 127);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1136, 375);
            this.panelContenedor.TabIndex = 5;
            // 
            // cbDocumento
            // 
            this.cbDocumento.FormattingEnabled = true;
            this.cbDocumento.Items.AddRange(new object[] {
            "DNI",
            "PASAPORTE",
            "CARNE DE EXTRANJERIA",
            "DIPLOMA DE IDENTIDAD"});
            this.cbDocumento.Location = new System.Drawing.Point(323, 66);
            this.cbDocumento.Name = "cbDocumento";
            this.cbDocumento.Size = new System.Drawing.Size(468, 21);
            this.cbDocumento.TabIndex = 5;
            this.cbDocumento.Visible = false;
            this.cbDocumento.SelectedValueChanged += new System.EventHandler(this.cbDocumento_SelectedValueChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBuscar.Location = new System.Drawing.Point(503, 153);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(89, 30);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Visible = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtRuc
            // 
            this.txtRuc.Location = new System.Drawing.Point(323, 105);
            this.txtRuc.Name = "txtRuc";
            this.txtRuc.Size = new System.Drawing.Size(468, 20);
            this.txtRuc.TabIndex = 3;
            this.txtRuc.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnRuc);
            this.panel3.Controls.Add(this.btnRazonSocial);
            this.panel3.Controls.Add(this.btnDocumento);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 58);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1136, 69);
            this.panel3.TabIndex = 4;
            // 
            // btnRuc
            // 
            this.btnRuc.Location = new System.Drawing.Point(384, 26);
            this.btnRuc.Name = "btnRuc";
            this.btnRuc.Size = new System.Drawing.Size(75, 23);
            this.btnRuc.TabIndex = 1;
            this.btnRuc.Text = "Ruc";
            this.btnRuc.UseVisualStyleBackColor = true;
            this.btnRuc.Click += new System.EventHandler(this.btnRuc_Click);
            // 
            // btnRazonSocial
            // 
            this.btnRazonSocial.Location = new System.Drawing.Point(584, 26);
            this.btnRazonSocial.Name = "btnRazonSocial";
            this.btnRazonSocial.Size = new System.Drawing.Size(141, 23);
            this.btnRazonSocial.TabIndex = 3;
            this.btnRazonSocial.Text = "Por Nomb./Raz.Soc.";
            this.btnRazonSocial.UseVisualStyleBackColor = true;
            this.btnRazonSocial.Click += new System.EventHandler(this.btnRazonSocial_Click);
            // 
            // btnDocumento
            // 
            this.btnDocumento.Location = new System.Drawing.Point(465, 26);
            this.btnDocumento.Name = "btnDocumento";
            this.btnDocumento.Size = new System.Drawing.Size(113, 23);
            this.btnDocumento.TabIndex = 2;
            this.btnDocumento.Text = "Por Documento";
            this.btnDocumento.UseVisualStyleBackColor = true;
            this.btnDocumento.Click += new System.EventHandler(this.btnDocumento_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1136, 58);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(19, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Criterios de Busqueda";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 607);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnRuc;
        private System.Windows.Forms.Button btnRazonSocial;
        private System.Windows.Forms.Button btnDocumento;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbDocumento;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtRuc;
    }
}

