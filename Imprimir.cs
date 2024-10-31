using sistemaEtiquetasHelados.Models;
using sistemaEtiquetasHelados.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaEtiquetasHelados
{
    public partial class Imprimir : Form
    {

        private Productores_API productoresApi;
        private Helados_API heladosApi;
        private Envases_API envasesApi;


        public Imprimir()
        {
            InitializeComponent();

            this.Text = "";
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;


            productoresApi = new Productores_API();
            heladosApi = new Helados_API();
            envasesApi = new Envases_API();

            btnImprimir.Enabled = false;
            CargarProductores();
        }

        // -------------------------- PRODUCTOR  --------------------------
        private async void CargarProductores()
        {
            try
            {
                List<ProductoresM> productores = await productoresApi.ObtenerProductores();
                cbxProductorEti.DataSource = productores;
                cbxProductorEti.DisplayMember = "nombre";
                cbxProductorEti.ValueMember = "id";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los productores: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private async void cbxProductorEti_SelectedIndexChanged(object sender, EventArgs e)
        {

            cbxHeladoEti.DataSource = null;
            cbxEnvaseEti.DataSource = null;

            if (cbxProductorEti.SelectedItem is ProductoresM productorSeleccionado)
            {
                int productorId = productorSeleccionado.id;
                await CargarHeladosPorProductor(productorId);

                cbxHeladoEti.Enabled = true;

            }

            ActualizarEstadoBotonImprimir();
        }

        // -------------------------- HELADOS  --------------------------
        private async Task CargarHeladosPorProductor(int productorId)
        {
            try
            {
                List<HeladosM> helados = await heladosApi.ObtenerHeladosPorProductor(productorId.ToString());

                if (helados == null || helados.Count == 0)
                {
                    cbxHeladoEti.DataSource = null;
                    cbxEnvaseEti.DataSource = null; 
                }
                else
                {
                    cbxHeladoEti.DataSource = helados;
                    cbxHeladoEti.DisplayMember = "nombre";
                    cbxHeladoEti.ValueMember = "id";

                    cbxHeladoEti.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los helados: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void cbxHeladoEti_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxEnvaseEti.DataSource = null;
            cbxEnvaseEti.Items.Clear();

            cbxEnvaseEti.SelectedIndex = -1;

            if (cbxHeladoEti.SelectedItem is HeladosM heladoSeleccionado)
            {
                int heladoId = heladoSeleccionado.id;
                await CargarEnvasesPorHelado(heladoId); 
            }
            else
            {
                cbxEnvaseEti.Items.Clear();

            }

            ActualizarEstadoBotonImprimir();
        }

        // -------------------------- ENVASE  --------------------------
        private async Task CargarEnvasesPorHelado(int heladoId)
        {
            try
            {
                List<EnvasesM> envases = await envasesApi.ObtenerEnvasesPorHelado(heladoId.ToString());

                cbxEnvaseEti.DataSource = null;  
                cbxEnvaseEti.Items.Clear();      
                cbxEnvaseEti.SelectedIndex = -1;

                if (envases != null && envases.Count > 0)
                {
                    cbxEnvaseEti.DataSource = envases;
                    cbxEnvaseEti.DisplayMember = "nombre"; 
                    cbxEnvaseEti.ValueMember = "id"; 
                }
                else
                {
                    MessageBox.Show("No se encontraron envases para este helado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los envases: " + ex.Message);
            }
        
        }
        private void cbxEnvaseEti_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxEnvaseEti.SelectedItem is EnvasesM envaseSeleccionado)
            {
                double volumen = envaseSeleccionado.CalcularVolumen(); 
              
            }

            ActualizarEstadoBotonImprimir();

        }


        // -------------------------- IMPRIMIR ETIQUETA  --------------------------
        private async void btnImprimir_Click(object sender, EventArgs e)
        {

         
            if (!int.TryParse(txtPesoEti.Text, out int peso))
            {
                MessageBox.Show("Por favor, ingrese un peso válido.");
                return;
            }

           
            if (cbxHeladoEti.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un helado.");
                return;
            }
            var helado = (HeladosM)cbxHeladoEti.SelectedItem;
            int heladoId = helado.id;

           
            if (cbxEnvaseEti.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un envase.");
                return;
            }
            var envase = (EnvasesM)cbxEnvaseEti.SelectedItem;
            int envaseId = envase.id;

         
            EtiquetaRequest etiquetaRequest = new EtiquetaRequest
            {
                fecha = DateTime.Now.ToString("MM/dd/yyyy"),
                peso = peso
            };

            try
            {
            
                IEtiqueta etiquetaService = new Etiqueta_API();
                string resultado = await etiquetaService.ImprimirEtiquetaAsync(etiquetaRequest, heladoId, envaseId);

              
                var result = MessageBox.Show("Etiqueta impresa con éxito. \n¿Desea abrir el archivo PDF generado?",
                                             "Impresión Completa",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
           
                    string filePath = resultado.Split(new[] { "en: " }, StringSplitOptions.None).Last();

                  
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = filePath,
                        UseShellExecute = true
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al imprimir la etiqueta: " + ex.Message);
            }
        }


        private void ActualizarEstadoBotonImprimir()
        {
            
            bool camposCompletos = cbxProductorEti.SelectedItem != null &&
                                    cbxHeladoEti.SelectedIndex != -1 &&
                                   cbxEnvaseEti.SelectedItem != null &&
                                   int.TryParse(txtPesoEti.Text, out _); 

            btnImprimir.Enabled = camposCompletos;
        }

        private void txtPesoEti_TextChanged(object sender, EventArgs e)
        {
            ActualizarEstadoBotonImprimir();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Panel formularioInicio = new Panel();

            formularioInicio.Show();

            this.Hide();
        }
    }
}
