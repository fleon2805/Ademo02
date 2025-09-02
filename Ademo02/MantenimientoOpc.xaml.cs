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
    /// Lógica de interacción para MantenimientoOpc.xaml
    /// </summary>
    public partial class MantenimientoOpc : Window
    {
        public MantenimientoOpc()
        {
            InitializeComponent();
        }
        private void BtnConductores_Click(object sender, RoutedEventArgs e)
        {
            ConductoresForm ventanaConductores = new ConductoresForm();
            ventanaConductores.Show();
            this.Close();
        }
    }
}
