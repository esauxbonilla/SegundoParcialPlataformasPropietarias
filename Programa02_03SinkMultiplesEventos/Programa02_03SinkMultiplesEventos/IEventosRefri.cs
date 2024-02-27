using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa02_03SinkMultiplesEventos
{
    internal interface IEventosRefri
    {
        //Aquí definimos los eventos que tendrá el refri
        void EReservasBajas(int pKilos);

        //Adicionamos otro evento
        void EDescongelado(int pGrados);
    }
}
