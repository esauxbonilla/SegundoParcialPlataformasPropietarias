using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa02_03SinkMultiplesEventos
{
    internal class CRefri
    {
        //Aquí guardamos todos los sinks con los que  se comunicará el refri
        private ArrayList listaSinks = new ArrayList();
        private int kilosAlimentos = 0;
        private int grados = 0;

        public CRefri(int pKilos, int pGrados)
        {
            //Coloca los valores iniciales del refri
            kilosAlimentos = pKilos;
            grados = pGrados;
        }

        //Con este método adicionamos un sink
        public void AgregarSink(IEventosRefri pSink)
        {
            if (pSink != null)
                listaSinks.Add(pSink);
        }
        //Con este método eliminamos un sink
        public void EliminarSink(IEventosRefri pSink)
        {
            if (listaSinks.Contains(pSink))
                listaSinks.Remove(pSink);
        }

        //Propiedades Necesarias
        public int Kilos { get { return kilosAlimentos; } }
        public int Grados { get { return grados; } }

        public void Trabajar(int pConsumo)
        {
            //Actualizamos los kilos del refri 
            kilosAlimentos -= pConsumo;

            //Subimos la temperatura
            grados += 1;

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("{0} kilos, {1} grados", kilosAlimentos, grados);

            //Hay que verificar si se cumple la condición para 
            // invocar los handlers del evento

            //Esta es la condición del evento
            if (kilosAlimentos > 10)
            {
                //Invocamos a los handlers de cada sink
                foreach (IEventosRefri handler in listaSinks)
                {
                    handler.EReservasBajas(kilosAlimentos);
                }
            }
            //Esta es la condición para el evento de descongelado
            if (grados>=0)
            {
                //Invocamos a los handlers de cada sink
                foreach (IEventosRefri handler in listaSinks)
                {
                    handler.EDescongelado(grados);
                }
            }
        }
    }
}
