using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemploPOO.Models
{
    public class Professor : Pessoa
    {
        public Professor()
        {

        }
        public Professor(string Nome) : base(Nome)
        {

        }
        public double salario { get; set; }
    }
}