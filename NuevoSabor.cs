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
    public partial class NuevoSabor : Form
    {
        public NuevoSabor()
        {
            InitializeComponent();

            this.Text = "";
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Helados formularioHelados = new Helados();

            formularioHelados.Show();

            this.Hide();
        }
    }
}
