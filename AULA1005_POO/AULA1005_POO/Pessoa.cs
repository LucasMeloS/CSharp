using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AULA1005_POO
{
    class Pessoa
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


        public Pessoa()
        {
                
        }

        public Pessoa(string nome) // construtor 
        {
        Nome = nome;
        }


    }
}
