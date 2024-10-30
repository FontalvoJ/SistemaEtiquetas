namespace sistemaEtiquetasHelados
{
    partial class NuevoSabor
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSaborNuevo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnNuevoSa = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(294, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "Añadir Sabor";
            // 
            // txtSaborNuevo
            // 
            this.txtSaborNuevo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtSaborNuevo.Location = new System.Drawing.Point(218, 173);
            this.txtSaborNuevo.Multiline = true;
            this.txtSaborNuevo.Name = "txtSaborNuevo";
            this.txtSaborNuevo.Size = new System.Drawing.Size(390, 37);
            this.txtSaborNuevo.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.label4.Location = new System.Drawing.Point(214, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nombre: ";
            // 
            // btnNuevoSa
            // 
            this.btnNuevoSa.BackColor = System.Drawing.Color.OliveDrab;
            this.btnNuevoSa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoSa.ForeColor = System.Drawing.Color.Snow;
            this.btnNuevoSa.Location = new System.Drawing.Point(218, 244);
            this.btnNuevoSa.Name = "btnNuevoSa";
            this.btnNuevoSa.Size = new System.Drawing.Size(175, 56);
            this.btnNuevoSa.TabIndex = 11;
            this.btnNuevoSa.Text = "Añadir";
            this.btnNuevoSa.UseVisualStyleBackColor = false;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Maroon;
            this.btnRegresar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.Color.Snow;
            this.btnRegresar.Location = new System.Drawing.Point(433, 244);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(175, 56);
            this.btnRegresar.TabIndex = 12;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // NuevoSabor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(827, 376);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnNuevoSa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSaborNuevo);
            this.Controls.Add(this.label4);
            this.Name = "NuevoSabor";
            this.Text = "NuevoSabor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSaborNuevo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnNuevoSa;
        private System.Windows.Forms.Button btnRegresar;
    }
}