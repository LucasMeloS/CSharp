﻿using System;
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
            AcelerarBastante(car);
            car.ImprimirInfo();
            Console.WriteLine("Velocidade inicial do bus:" + oni.Velocidade);
            oni.Acelerar();
            oni.Acelerar();
            oni.Desacelerar();
            Console.WriteLine("Velocidade Atual do bus:" + oni.Velocidade);
            AcelerarBastante(oni);
            oni.ImprimirInfo();

            Console.ReadKey();
        }


        static void AcelerarBastante (IMeioTransporte meioTransporte)
        {
            for (int i = 0; i < 20; i++)
            {
                meioTransporte.Acelerar();
            }



        }

       

    }
    }
