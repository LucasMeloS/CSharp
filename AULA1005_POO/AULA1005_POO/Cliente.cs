using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AULA1005_POO
{
    class Cliente : Pessoa
    {

        public DateTime DataNascimento { get; set; }

        public Cliente()
        {

        }

        public Cliente(string nome )
       
            {
                Nome = nome;
            }
       

    }
}
