using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Formats.Tar;
using System.Linq;
using System.Threading.Tasks;

namespace exemploPOO.Models
{
    public class ContaCorrente
    {
        public ContaCorrente(int numeroConta, decimal saldoInicial)
        {
            NumeroConta = numeroConta;
            saldo = saldoInicial;
        }
        public int NumeroConta { get; set; }
        private decimal saldo;
        public void Sacar(decimal valor)
        {
            if(saldo >= valor)
            {
             saldo -= valor;  
             Console.WriteLine("Saque realizado com sucesso") ;
            }
            else 
            {
                Console.WriteLine("Valor desejado é maior que saldo disponivel");
            }
        }
        public void exibirSaldo()
        {
            Console.WriteLine($"Seu saldo disponivel é: {saldo}");
        }

    }
}