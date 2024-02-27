﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa02_01Sink
{
    internal class CRefriSink : IEventosRefri
    {
        //Esta es la clase de los sink
        //Aquí colocamos los handlers de los eventos definidos en la interfaz

        public void EReservasBajas(int pKilos)
        {
            //Aquí se coloca todo el código necesario para ejecutar cuando suceda el evento

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--> Reservas bajas de alimentos");
            Console.WriteLine("--> Quedan {0} kilos",  pKilos);
            Console.Beep();
        }
    }
}
