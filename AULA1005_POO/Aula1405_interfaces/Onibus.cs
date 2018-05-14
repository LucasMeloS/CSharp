using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1405_interfaces
{
    class Onibus : IMeioTransporte
    {
        public int Velocidade { get; set; }


        public Onibus()
        {

            Velocidade = 0;

        }


        public void Acelerar()
        {
            Velocidade += 5;
        }

        public void Desacelerar()
        {
            Velocidade -= 5; ;
        }
    }
}



