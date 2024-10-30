using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaEtiquetasHelados
{
    public partial class Panel : Form
    {
        public Panel()
        {
            InitializeComponent();
            this.Text = ""; 
            this.MaximizeBox = false;
            this.MinimizeBox = true; 
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {

        }

        private void btnImprimirEtiqueta_Click(object sender, EventArgs e)
        {
            Imprimir formularioImprimir = new Imprimir();

            formularioImprimir.Show();

            this.Hide();
        }
    }
}
