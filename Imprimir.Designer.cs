namespace sistemaEtiquetasHelados
{
    partial class Imprimir
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
            this.btnImprimir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxProductorEti = new System.Windows.Forms.ComboBox();
            this.cbxHeladoEti = new System.Windows.Forms.ComboBox();
            this.cbxEnvaseEti = new System.Windows.Forms.ComboBox();
            this.txtPesoEti = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(53)))), ((int)(((byte)(77)))));
            this.btnImprimir.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnImprimir.Location = new System.Drawing.Point(295, 464);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(235, 85);
            this.btnImprimir.TabIndex = 0;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Productor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(240, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Helado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(241, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Envase";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(241, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Peso";
            // 
            // cbxProductorEti
            // 
            this.cbxProductorEti.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxProductorEti.FormattingEnabled = true;
            this.cbxProductorEti.Location = new System.Drawing.Point(245, 144);
            this.cbxProductorEti.Name = "cbxProductorEti";
            this.cbxProductorEti.Size = new System.Drawing.Size(339, 29);
            this.cbxProductorEti.TabIndex = 5;
            this.cbxProductorEti.SelectedIndexChanged += new System.EventHandler(this.cbxProductorEti_SelectedIndexChanged);
            // 
            // cbxHeladoEti
            // 
            this.cbxHeladoEti.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxHeladoEti.FormattingEnabled = true;
            this.cbxHeladoEti.Location = new System.Drawing.Point(245, 225);
            this.cbxHeladoEti.Name = "cbxHeladoEti";
            this.cbxHeladoEti.Size = new System.Drawing.Size(339, 29);
            this.cbxHeladoEti.TabIndex = 6;
            this.cbxHeladoEti.SelectedIndexChanged += new System.EventHandler(this.cbxHeladoEti_SelectedIndexChanged);
            // 
            // cbxEnvaseEti
            // 
            this.cbxEnvaseEti.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEnvaseEti.FormattingEnabled = true;
            this.cbxEnvaseEti.Location = new System.Drawing.Point(245, 321);
            this.cbxEnvaseEti.Name = "cbxEnvaseEti";
            this.cbxEnvaseEti.Size = new System.Drawing.Size(339, 29);
            this.cbxEnvaseEti.TabIndex = 7;
            this.cbxEnvaseEti.SelectedIndexChanged += new System.EventHandler(this.cbxEnvaseEti_SelectedIndexChanged);
            // 
            // txtPesoEti
            // 
            this.txtPesoEti.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesoEti.Location = new System.Drawing.Point(245, 404);
            this.txtPesoEti.Name = "txtPesoEti";
            this.txtPesoEti.Size = new System.Drawing.Size(339, 30);
            this.txtPesoEti.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(53)))), ((int)(((byte)(77)))));
            this.label5.Location = new System.Drawing.Point(237, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(347, 47);
            this.label5.TabIndex = 9;
            this.label5.Text = "Imprimir Etiqueta";
            // 
            // Imprimir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 596);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPesoEti);
            this.Controls.Add(this.cbxEnvaseEti);
            this.Controls.Add(this.cbxHeladoEti);
            this.Controls.Add(this.cbxProductorEti);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnImprimir);
            this.Name = "Imprimir";
            this.Text = "Imprimir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxProductorEti;
        private System.Windows.Forms.ComboBox cbxHeladoEti;
        private System.Windows.Forms.ComboBox cbxEnvaseEti;
        private System.Windows.Forms.TextBox txtPesoEti;
        private System.Windows.Forms.Label label5;
    }
}