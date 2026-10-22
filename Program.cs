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
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime Entrada = new DateTime(2026, 11, 20);
            DateTime Salida = new DateTime(2026, 11, 25);
            HotelReserva MiReserva = new HotelReserva("Gran Hotel Continental", 302, Entrada, Salida, "Carlos Mendoza", 180000, 'P');
            MiReserva.MostrarDisponibilidad();
            MiReserva.ValidarHabitacion();
            MiReserva.ValidarFechas();
            MiReserva.ValidarMembresia();
            MiReserva.CalcularNoches();
            MiReserva.AplicarDescuento();
            MiReserva.GenerarFactura();
        }
    }
}
