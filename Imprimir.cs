using sistemaEtiquetasHelados.Models;
using sistemaEtiquetasHelados.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

            this.Text = "Impresión de Etiqueta";
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;


            productoresApi = new Productores_API();
            heladosApi = new Helados_API();
            envasesApi = new Envases_API();

            CargarProductores();
        }

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
            if (cbxProductorEti.SelectedItem is ProductoresM productorSeleccionado)
            {
                int productorId = productorSeleccionado.id;
                await CargarHeladosPorProductor(productorId);
            }
            else
            {
                cbxHeladoEti.DataSource = null;
                cbxEnvaseEti.DataSource = null;
            }
        }


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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los helados: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void cbxHeladoEti_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxHeladoEti.SelectedItem is HeladosM heladoSeleccionado)
            {
                int heladoId = heladoSeleccionado.id;
                await CargarEnvasesPorHelado(heladoId); 
            }
            else
            {
                cbxEnvaseEti.Items.Clear(); 
                
            }
        }


        private async Task CargarEnvasesPorHelado(int heladoId)
        {
            try
            {
                List<EnvasesM> envases = await envasesApi.ObtenerEnvasesPorHelado(heladoId.ToString());

                cbxEnvaseEti.Items.Clear(); 

                if (envases != null && envases.Count > 0)
                {
                    foreach (var envase in envases)
                    {
                        cbxEnvaseEti.Items.Add(envase); 
                    }
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

        }

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

                MessageBox.Show("Etiqueta impresa con éxito. \n" + resultado); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al imprimir la etiqueta: " + ex.Message); 
            }
        }
    }
}
