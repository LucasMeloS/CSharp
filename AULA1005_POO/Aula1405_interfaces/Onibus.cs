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

        //chave para o obj marca
        public int MarcaID { get; set; }

        //propriedade de navegação
        public virtual Marca _Marca { get; set; }

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

        public string ImprimirInfo()
        {
            return "onibus velocidade atual:" + Velocidade;
        }



    }
}



