using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1405_interfaces
{
    class Program
    {
        static void Main(string[] args)
        {

            Carro car = new Carro();
            Onibus oni = new Onibus();

            Console.WriteLine("Velocidade inicial:" + car.Velocidade);
            car.Acelerar();
            car.Acelerar();
            car.Desacelerar();
            Console.WriteLine("Velocidade Atual:" + car.Velocidade);
            Console.WriteLine("Velocidade inicial do bus:" + oni.Velocidade);
            oni.Acelerar();
            oni.Acelerar();
            oni.Desacelerar();
            Console.WriteLine("Velocidade Atual do bus:" + oni.Velocidade);

            Console.ReadKey();


        }
    }
}
