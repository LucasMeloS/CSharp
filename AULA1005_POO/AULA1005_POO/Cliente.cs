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

        public string DataqueNasceu
        {
            get
            {
                return DataNascimento.ToShortDateString();
            }
        }

        public Cliente()
        {

        }

        public Cliente(string nome )
       
            {
                Nome = nome;
            }

        //public DateTime hoje { get; set; }

        public string Idade
        {
            get
            {
                return DateTime.Today.Year - DataNascimento.Year;
            }
        }

    }
}
