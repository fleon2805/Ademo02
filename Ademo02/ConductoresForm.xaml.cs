using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Ademo02
{
    /// <summary>
    /// Lógica de interacción para ConductoresForm.xaml
    /// </summary>
    public partial class ConductoresForm : Window
    {
        public ConductoresForm()
        {
            InitializeComponent();
        }
        private void BtnGrabar_Click(object sender, RoutedEventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string licencia = txtLicencia.Text.Trim();
            string transporte = txtTransporte.Text.Trim();

            
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(licencia) || string.IsNullOrEmpty(transporte))
            {
                MessageBox.Show("Por favor complete todos los campos.", "Aviso", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            
            lblTitulo.Visibility = Visibility.Visible;
            lblDatos.Text = $"Nombre Conductor: {nombre}\nLicencia: {licencia}\nTransporte: {transporte}";

            
            txtNombre.Clear();
            txtLicencia.Clear();
            txtTransporte.Clear();
        }
    }
}
