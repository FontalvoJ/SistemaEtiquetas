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
    public partial class Helados : Form
    {
        public Helados()
        {
            InitializeComponent();

            this.Text = "";
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnNuevoSabor_Click(object sender, EventArgs e)
        {
            NuevoSabor formularioSabor = new NuevoSabor();

            formularioSabor.Show();

            this.Hide();
        }

        private void btnNuevoNutriente_Click(object sender, EventArgs e)
        {
            NuevoNutriente formularioNutriente = new NuevoNutriente();

            formularioNutriente.Show();

            this.Hide();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Panel formularioInicio = new Panel();

            formularioInicio.Show();

            this.Hide();
        }
    }
}
