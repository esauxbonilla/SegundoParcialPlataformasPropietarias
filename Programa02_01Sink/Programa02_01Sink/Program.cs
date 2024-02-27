﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa02_01Sink
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creamos el refri
            CRefri miRefri = new CRefri (50, -20);
            Random rnd = new Random();  

            //Creamos el sink
            //Sink1 tiene el código que se ejecutará cuando suceda el evento
            CRefriSink sink1 = new CRefriSink();

            //Adicionamos el sink al refri
            miRefri.AgregarSink(sink1);

            //El refri hace su trabajo
            while (miRefri.Kilos > 0)
            {
                //El refri trabaja y le sacamos kilos al azar
                miRefri.Trabajar(rnd.Next(1, 5));
            }
        }
    }
}
