namespace sistemaEtiquetasHelados
{
    partial class Helados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Helados));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNuevoSabor = new System.Windows.Forms.Button();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxSabor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIngredientes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxPrductor = new System.Windows.Forms.ComboBox();
            this.cbxHelado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAgregarNutriente = new System.Windows.Forms.Button();
            this.dgwNutrientes = new System.Windows.Forms.DataGridView();
            this.Nutriente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNuevoNutriente = new System.Windows.Forms.Button();
            this.txtVd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxNutriente = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbxSellos = new System.Windows.Forms.ListBox();
            this.btnSeleccionarSello = new System.Windows.Forms.Button();
            this.btnGuardarHelado = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwNutrientes)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(431, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Crear Ficha de Helado";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.btnNuevoSabor);
            this.groupBox1.Controls.Add(this.txtObservaciones);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbxSabor);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtIngredientes);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbxPrductor);
            this.groupBox1.Controls.Add(this.cbxHelado);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(62, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1146, 302);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Información de Helado";
            // 
            // btnNuevoSabor
            // 
            this.btnNuevoSabor.BackColor = System.Drawing.Color.Olive;
            this.btnNuevoSabor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoSabor.ForeColor = System.Drawing.Color.Snow;
            this.btnNuevoSabor.Location = new System.Drawing.Point(259, 238);
            this.btnNuevoSabor.Name = "btnNuevoSabor";
            this.btnNuevoSabor.Size = new System.Drawing.Size(278, 53);
            this.btnNuevoSabor.TabIndex = 10;
            this.btnNuevoSabor.Text = "Nuevo Sabor";
            this.btnNuevoSabor.UseVisualStyleBackColor = false;
            this.btnNuevoSabor.Click += new System.EventHandler(this.btnNuevoSabor_Click);
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtObservaciones.Location = new System.Drawing.Point(708, 93);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(390, 198);
            this.txtObservaciones.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.label6.Location = new System.Drawing.Point(556, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "Observaciones: ";
            // 
            // cbxSabor
            // 
            this.cbxSabor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbxSabor.FormattingEnabled = true;
            this.cbxSabor.Location = new System.Drawing.Point(147, 201);
            this.cbxSabor.Name = "cbxSabor";
            this.cbxSabor.Size = new System.Drawing.Size(390, 31);
            this.cbxSabor.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.label5.Location = new System.Drawing.Point(73, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Sabor: ";
            // 
            // txtIngredientes
            // 
            this.txtIngredientes.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtIngredientes.Location = new System.Drawing.Point(147, 93);
            this.txtIngredientes.Multiline = true;
            this.txtIngredientes.Name = "txtIngredientes";
            this.txtIngredientes.Size = new System.Drawing.Size(390, 90);
            this.txtIngredientes.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.label4.Location = new System.Drawing.Point(18, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ingredientes: ";
            // 
            // cbxPrductor
            // 
            this.cbxPrductor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbxPrductor.FormattingEnabled = true;
            this.cbxPrductor.Location = new System.Drawing.Point(708, 43);
            this.cbxPrductor.Name = "cbxPrductor";
            this.cbxPrductor.Size = new System.Drawing.Size(390, 31);
            this.cbxPrductor.TabIndex = 3;
            // 
            // cbxHelado
            // 
            this.cbxHelado.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbxHelado.FormattingEnabled = true;
            this.cbxHelado.Location = new System.Drawing.Point(147, 43);
            this.cbxHelado.Name = "cbxHelado";
            this.cbxHelado.Size = new System.Drawing.Size(390, 31);
            this.cbxHelado.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.label3.Location = new System.Drawing.Point(54, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.label2.Location = new System.Drawing.Point(595, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Productor: ";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Controls.Add(this.btnAgregarNutriente);
            this.groupBox2.Controls.Add(this.dgwNutrientes);
            this.groupBox2.Controls.Add(this.btnNuevoNutriente);
            this.groupBox2.Controls.Add(this.txtVd);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtCantidad);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cbxNutriente);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(62, 374);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(566, 354);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información Nutricional";
            // 
            // btnAgregarNutriente
            // 
            this.btnAgregarNutriente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(53)))), ((int)(((byte)(77)))));
            this.btnAgregarNutriente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarNutriente.ForeColor = System.Drawing.Color.SeaShell;
            this.btnAgregarNutriente.Location = new System.Drawing.Point(36, 289);
            this.btnAgregarNutriente.Name = "btnAgregarNutriente";
            this.btnAgregarNutriente.Size = new System.Drawing.Size(217, 58);
            this.btnAgregarNutriente.TabIndex = 12;
            this.btnAgregarNutriente.Text = "Agregar";
            this.btnAgregarNutriente.UseVisualStyleBackColor = false;
            // 
            // dgwNutrientes
            // 
            this.dgwNutrientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwNutrientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nutriente,
            this.Cantidad,
            this.VD});
            this.dgwNutrientes.Location = new System.Drawing.Point(36, 137);
            this.dgwNutrientes.Name = "dgwNutrientes";
            this.dgwNutrientes.RowHeadersWidth = 51;
            this.dgwNutrientes.RowTemplate.Height = 24;
            this.dgwNutrientes.Size = new System.Drawing.Size(501, 144);
            this.dgwNutrientes.TabIndex = 11;
            // 
            // Nutriente
            // 
            this.Nutriente.HeaderText = "Nutriente";
            this.Nutriente.MinimumWidth = 6;
            this.Nutriente.Name = "Nutriente";
            this.Nutriente.Width = 125;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad Por Porcion";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 125;
            // 
            // VD
            // 
            this.VD.HeaderText = "% VD (*)";
            this.VD.MinimumWidth = 6;
            this.VD.Name = "VD";
            this.VD.Width = 125;
            // 
            // btnNuevoNutriente
            // 
            this.btnNuevoNutriente.BackColor = System.Drawing.Color.Olive;
            this.btnNuevoNutriente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoNutriente.ForeColor = System.Drawing.Color.Snow;
            this.btnNuevoNutriente.Location = new System.Drawing.Point(259, 287);
            this.btnNuevoNutriente.Name = "btnNuevoNutriente";
            this.btnNuevoNutriente.Size = new System.Drawing.Size(278, 60);
            this.btnNuevoNutriente.TabIndex = 10;
            this.btnNuevoNutriente.Text = "Nuevo Nutriente";
            this.btnNuevoNutriente.UseVisualStyleBackColor = false;
            this.btnNuevoNutriente.Click += new System.EventHandler(this.btnNuevoNutriente_Click);
            // 
            // txtVd
            // 
            this.txtVd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtVd.Location = new System.Drawing.Point(408, 92);
            this.txtVd.Name = "txtVd";
            this.txtVd.Size = new System.Drawing.Size(129, 32);
            this.txtVd.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.label7.Location = new System.Drawing.Point(331, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 21);
            this.label7.TabIndex = 8;
            this.label7.Text = "% VD (*)";
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtCantidad.Location = new System.Drawing.Point(147, 92);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(163, 32);
            this.txtCantidad.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.label9.Location = new System.Drawing.Point(32, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 52);
            this.label9.TabIndex = 4;
            this.label9.Text = "Cantidad Por Porción ";
            // 
            // cbxNutriente
            // 
            this.cbxNutriente.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbxNutriente.FormattingEnabled = true;
            this.cbxNutriente.Location = new System.Drawing.Point(147, 38);
            this.cbxNutriente.Name = "cbxNutriente";
            this.cbxNutriente.Size = new System.Drawing.Size(390, 31);
            this.cbxNutriente.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.label10.Location = new System.Drawing.Point(32, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 21);
            this.label10.TabIndex = 1;
            this.label10.Text = "Nutriente: ";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Controls.Add(this.lbxSellos);
            this.groupBox3.Controls.Add(this.btnSeleccionarSello);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(642, 374);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(566, 354);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Selección de Sellos";
            // 
            // lbxSellos
            // 
            this.lbxSellos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxSellos.FormattingEnabled = true;
            this.lbxSellos.ItemHeight = 23;
            this.lbxSellos.Location = new System.Drawing.Point(36, 43);
            this.lbxSellos.Name = "lbxSellos";
            this.lbxSellos.Size = new System.Drawing.Size(504, 234);
            this.lbxSellos.TabIndex = 11;
            // 
            // btnSeleccionarSello
            // 
            this.btnSeleccionarSello.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(53)))), ((int)(((byte)(77)))));
            this.btnSeleccionarSello.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarSello.ForeColor = System.Drawing.Color.SeaShell;
            this.btnSeleccionarSello.Location = new System.Drawing.Point(36, 287);
            this.btnSeleccionarSello.Name = "btnSeleccionarSello";
            this.btnSeleccionarSello.Size = new System.Drawing.Size(217, 60);
            this.btnSeleccionarSello.TabIndex = 10;
            this.btnSeleccionarSello.Text = "Seleccionar";
            this.btnSeleccionarSello.UseVisualStyleBackColor = false;
            // 
            // btnGuardarHelado
            // 
            this.btnGuardarHelado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnGuardarHelado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarHelado.ForeColor = System.Drawing.Color.Snow;
            this.btnGuardarHelado.Location = new System.Drawing.Point(265, 734);
            this.btnGuardarHelado.Name = "btnGuardarHelado";
            this.btnGuardarHelado.Size = new System.Drawing.Size(363, 83);
            this.btnGuardarHelado.TabIndex = 12;
            this.btnGuardarHelado.Text = "Guardar Información";
            this.btnGuardarHelado.UseVisualStyleBackColor = false;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Maroon;
            this.btnRegresar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.Color.Snow;
            this.btnRegresar.Location = new System.Drawing.Point(642, 734);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(363, 83);
            this.btnRegresar.TabIndex = 13;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // Helados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1254, 838);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnGuardarHelado);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Helados";
            this.Text = "Helados";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwNutrientes)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIngredientes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxPrductor;
        private System.Windows.Forms.ComboBox cbxHelado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxSabor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnNuevoSabor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnNuevoNutriente;
        private System.Windows.Forms.TextBox txtVd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbxNutriente;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgwNutrientes;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSeleccionarSello;
        private System.Windows.Forms.Button btnAgregarNutriente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nutriente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn VD;
        private System.Windows.Forms.ListBox lbxSellos;
        private System.Windows.Forms.Button btnGuardarHelado;
        private System.Windows.Forms.Button btnRegresar;
    }
}