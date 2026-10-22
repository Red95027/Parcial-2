using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;
using static System.Math;

namespace Hotel
{
    internal class HotelReserva
    {
        private string NombreHotel = "GENERICO";
        private int NumeroHabitacion = 100;
        private DateTime FechaCheckIn = DateTime.Now;
        private DateTime FechaCheckOut = DateTime.Now.AddDays(1);
        private string NombreCliente = "INVITADO";
        private double PrecioNoche = 150000;
        private char TipoMembresia = 'B';
        double ValorDescontado;
        int Noches;

        public HotelReserva(string nombreHotel, int numeroHabitacion, DateTime fechaCheckIn, DateTime fechaCheckOut, string nombreCliente, double precioNoche, char tipoMembresia)
        {
            NombreHotel = nombreHotel;
            NumeroHabitacion = numeroHabitacion;
            FechaCheckIn = fechaCheckIn;
            FechaCheckOut = fechaCheckOut;
            NombreCliente = nombreCliente;
            PrecioNoche = precioNoche;
            TipoMembresia = tipoMembresia;
        }
        public bool ValidarHabitacion()
        {
            if (NumeroHabitacion >= 100 && NumeroHabitacion < 600)
                return true;
            else
                return false;
        }
        public bool ValidarFechas()
        {
            if (FechaCheckIn < FechaCheckOut)
                return true;
            else
                return false;
        }
        public int ValidarMembresia()
        {
            if (TipoMembresia == 'B' || TipoMembresia == 'P' || TipoMembresia == 'O')
                return 1;
            else
                return 0;
        }
        public int CalcularNoches()
        {
            Noches = (int)(FechaCheckOut.Date - FechaCheckIn.Date).TotalDays;
            return Noches;
        }
        public double AplicarDescuento()
        {
            if (TipoMembresia == 'B')
                ValorDescontado = 0;
            else if (TipoMembresia == 'P')
                ValorDescontado = PrecioNoche * 0.1;
            else if (TipoMembresia == 'O')
                ValorDescontado = PrecioNoche * 0.2;
            else
                WriteLine("Error");
            return ValorDescontado;
        }
        public void MostrarDisponibilidad()
        {
            WriteLine($"Hotel: {NombreHotel}, Habitacion: {NumeroHabitacion}, Disponible de {FechaCheckIn} a {FechaCheckOut}");
        }
        public void GenerarFactura()
        {
            double ValorTotal = (PrecioNoche - ValorDescontado) * Noches;
            WriteLine($"Nombre del cliente: {NombreCliente}, Hotel: {NombreHotel}, Fechas: de {FechaCheckIn} a {FechaCheckOut}, Noches: {Noches}, Precio por noche: {PrecioNoche}, Subtotal: {ValorDescontado}, Total: {ValorTotal}");
        }
    }
}
