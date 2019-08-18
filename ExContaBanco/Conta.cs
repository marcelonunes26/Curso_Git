using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExContaBanco
{
    public class Conta
    {
        public string Titular { get; set; }
        public string NumeroConta { get; private set; }
        public double Saldo { get; private set; }

        //Construtor sem o Saldo (Sabendo que nesse caso o saldo vale 0)
        public Conta(string titular, string numeroConta)
        {
            Titular = titular;
            NumeroConta = numeroConta;
        }

        //Construtor completo reaproveitando o construtor acima
        public Conta(string titular, string numeroConta, double depositoInicial): this(numeroConta, titular)
        {            
            Deposito (depositoInicial);
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia + 5.0;
           
        }

        public override string ToString()
        {
            return "Conta " + NumeroConta + 
                " Titular: " + Titular + 
                ", Saldo: R$ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
