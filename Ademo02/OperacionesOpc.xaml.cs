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
    /// Lógica de interacción para OperacionesOpc.xaml
    /// </summary>
    public partial class OperacionesOpc : Window
    {
        public OperacionesOpc()
        {
            InitializeComponent();
        }
        private void BtnIngreso_Click(object sender, RoutedEventArgs e)
        {
            IngresoForm ventanaIngreso = new IngresoForm();
            ventanaIngreso.Show();
            this.Close();
        }
    }
}
