using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1405_interfaces
{
    class Carro : IMeioTransporte

    {

        public int Velocidade { get; set; }

        public string modelo { get; set;

        //chave para o obj marca
        public int MarcaID { get; set; }

        //propriedade de navegação
        public virtual Marca _Marca { get; set; }

        public List<Roda> Rodas { get; set; }


        public Carro()
        {

            Velocidade = 0;

        }


        public void Acelerar()
        {
            Velocidade += 10;
        }

        public void Desacelerar()
        {
            Velocidade -= 10; ;
        }

        public string ImprimirInfo()
        {
            return "Carro velocidade atual:" + Velocidade;
        }
    }
}
