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
    /// Lógica de interacción para RecursosOpc.xaml
    /// </summary>
    public partial class RecursosOpc : Window
    {
        public RecursosOpc()
        {
            InitializeComponent();
        }
        private void BtnIngresos_Click(object sender, RoutedEventArgs e)
        {
            ListadoIngresosRep ventanaListado = new ListadoIngresosRep();
            ventanaListado.Show();
            this.Close();
        }
    }
}
