using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AULA1005_POO
{
    class Cliente
    {

        //Atributo

        private string nome;

        //Propriedade

        public string Cpf { get; set; }

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        //Construtor

       // public Cliente(string nome) // construtor 
        //{
            //Nome = nome;
       // }


    }
}
