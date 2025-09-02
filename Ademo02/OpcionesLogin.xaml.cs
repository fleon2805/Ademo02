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
    /// Lógica de interacción para OpcionesLogin.xaml
    /// </summary>
    public partial class OpcionesLogin : Window
    {
        public OpcionesLogin()
        {
            InitializeComponent();
        }
        private void BtnOperaciones_Click(object sender, RoutedEventArgs e)
        {
            OperacionesOpc ventanaOperaciones = new OperacionesOpc();
            ventanaOperaciones.Show();
            this.Close();
        }

        private void BtnMantenimiento_Click(object sender, RoutedEventArgs e)
        {
            MantenimientoOpc ventanaMantenimiento = new MantenimientoOpc();
            ventanaMantenimiento.Show();
            this.Close();
        }

        private void BtnRecursos_Click(object sender, RoutedEventArgs e)
        {
            RecursosOpc ventanaRecursos = new RecursosOpc();
            ventanaRecursos.Show();
            this.Close();
        }

    }
}
