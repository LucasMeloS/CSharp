using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AULA1005_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cli = new Cliente();
            cli.Nome = "Godofredo";  //set
            string nomeCliente = cli.Nome; //get

            cli.Cpf = "12345678901";  //set
            string cpfCliente = cli.Cpf ; //get

            Console.WriteLine(nomeCliente);
            Console.WriteLine(cpfCliente);

        }
    }
}
