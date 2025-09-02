using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Ademo02
{
    public partial class ListadoIngresosRep : Window
    {
        private List<Ingreso> ingresos; // lista original
        private List<Ingreso> ingresosFiltrados;

        public ListadoIngresosRep()
        {
            InitializeComponent();
            CargarDatos();
            CargarListado(ingresos);
        }

        private void CargarDatos()
        {
            ingresos = new List<Ingreso>
            {
                new Ingreso { Fecha = new DateTime(2025, 9, 1, 10, 0, 0), Placa = "ABC-123", Turno = "Mañana", Conductor = "Juan Pérez", Producto = "Cemento", Peso = 1000, Transporte = "Transporte Perú" },
                new Ingreso { Fecha = new DateTime(2025, 9, 1, 14, 30, 0), Placa = "XYZ-456", Turno = "Tarde", Conductor = "Luis Gómez", Producto = "Arena", Peso = 2000, Transporte = "Camiones del Sur" },
                new Ingreso { Fecha = new DateTime(2025, 8, 31, 9, 0, 0), Placa = "LMN-789", Turno = "Mañana", Conductor = "Carlos López", Producto = "Piedra", Peso = 1500, Transporte = "Transportes Rápidos" }
            };

            ingresosFiltrados = new List<Ingreso>(ingresos);
        }

        private void CargarListado(List<Ingreso> lista)
        {
            dgIngresos.ItemsSource = null;
            dgIngresos.ItemsSource = lista;
        }

        private void BtnBuscar_Click(object sender, RoutedEventArgs e)
        {
            DateTime? fechaInicio = dpFechaInicio.SelectedDate;
            DateTime? fechaFin = dpFechaFin.SelectedDate;
            string placa = txtPlaca.Text.Trim().ToLower();
            string conductor = txtConductor.Text.Trim().ToLower();
            string producto = txtProducto.Text.Trim().ToLower();

            ingresosFiltrados = ingresos.Where(i =>
                (!fechaInicio.HasValue || i.Fecha.Date >= fechaInicio.Value.Date) &&
                (!fechaFin.HasValue || i.Fecha.Date <= fechaFin.Value.Date) &&
                (string.IsNullOrEmpty(placa) || i.Placa.ToLower().Contains(placa)) &&
                (string.IsNullOrEmpty(conductor) || i.Conductor.ToLower().Contains(conductor)) &&
                (string.IsNullOrEmpty(producto) || i.Producto.ToLower().Contains(producto))
            ).ToList();

            CargarListado(ingresosFiltrados);
        }
    }

    public class Ingreso
    {
        public DateTime Fecha { get; set; }
        public string Placa { get; set; }
        public string Turno { get; set; }
        public string Conductor { get; set; }
        public string Producto { get; set; }
        public double Peso { get; set; }
        public string Transporte { get; set; }
    }
}
