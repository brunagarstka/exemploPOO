using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Threading.Tasks;

namespace exemploPOO.Models
{
    public class Aluno : Pessoa
    {
        public Aluno()
        {
            
        }
        public Aluno(string Nome) : base(Nome)
        {
            
        } 
        public double Nota { get; set; }
        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos, e sou uma aluno nota: {Nota}");
        }
    }
}