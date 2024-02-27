using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa02_03SinkMultiplesEventos
{
    internal class CTiendaSink : IEventosRefri
    {
        public void EReservasBajas(int pKilos)
        {
            //Aquí se coloca todo el código necesario para ejecutar cuando suceda el evento
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--> Le enviaremos sus viveres");
            Console.WriteLine("--> Seran {0} kilos", pKilos);
        }

        public void EDescongelado(int pGrados)
        {
            //Handler Vacío
        }
    }
}
