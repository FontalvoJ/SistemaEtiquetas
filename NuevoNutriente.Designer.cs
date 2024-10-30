namespace sistemaEtiquetasHelados
{
    partial class NuevoNutriente
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
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnNuevoNutri = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNutrienteNuevo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Maroon;
            this.btnRegresar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.Color.Snow;
            this.btnRegresar.Location = new System.Drawing.Point(427, 250);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(175, 56);
            this.btnRegresar.TabIndex = 17;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnNuevoNutri
            // 
            this.btnNuevoNutri.BackColor = System.Drawing.Color.OliveDrab;
            this.btnNuevoNutri.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoNutri.ForeColor = System.Drawing.Color.Snow;
            this.btnNuevoNutri.Location = new System.Drawing.Point(212, 250);
            this.btnNuevoNutri.Name = "btnNuevoNutri";
            this.btnNuevoNutri.Size = new System.Drawing.Size(175, 56);
            this.btnNuevoNutri.TabIndex = 16;
            this.btnNuevoNutri.Text = "Añadir";
            this.btnNuevoNutri.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(279, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 39);
            this.label1.TabIndex = 13;
            this.label1.Text = "Añadir Nutriente";
            // 
            // txtNutrienteNuevo
            // 
            this.txtNutrienteNuevo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtNutrienteNuevo.Location = new System.Drawing.Point(212, 179);
            this.txtNutrienteNuevo.Multiline = true;
            this.txtNutrienteNuevo.Name = "txtNutrienteNuevo";
            this.txtNutrienteNuevo.Size = new System.Drawing.Size(390, 37);
            this.txtNutrienteNuevo.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.label4.Location = new System.Drawing.Point(208, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "Nombre: ";
            // 
            // NuevoNutriente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(819, 387);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnNuevoNutri);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNutrienteNuevo);
            this.Controls.Add(this.label4);
            this.Name = "NuevoNutriente";
            this.Text = "NuevoNutriente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnNuevoNutri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNutrienteNuevo;
        private System.Windows.Forms.Label label4;
    }
}