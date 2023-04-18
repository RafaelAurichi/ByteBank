using System;
using ByteBank.Titular;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ByteBank.Contas
{
    public class ContaCorrente
    {
        public static int TotalContasCriadas { get; private set; }

        public ContaCorrente(string num_conta, int num_agencia)
        {
            this.NumConta = num_conta;
            this.NumAgencia = num_agencia;
            TotalContasCriadas++;
        }

        public string NumConta { get; private set; }
        public Cliente Titular { get; set; }

        private int _numAgencia;
        public int NumAgencia
        {
            get { return this._numAgencia; }
            private set {
                if (value < 0)
                {
                    Console.WriteLine("Error: Não é possível definir um valor negativo para o campo 'conta'.");
                }
                else
                {
                    this._numAgencia = value;
                }
            }
        }

        private double _saldo;
        public double Saldo
        {
            get { return this._saldo; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Error: Não é possível definir um valor negativo para o campo 'saldo'.");
                }
                else
                {
                    this._saldo = value;
                }
            }
        }


        //MÉTODOS---------------------------------------------------
        public void Depositar(double deposito)
        {
            Saldo += deposito;
        }

        public bool Sacar(double saque)
        {
            if (Saldo >= saque)
            {
                Saldo -= saque;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Transferir(double transf, ContaCorrente destino)
        {
            if (Saldo >= transf)
            {
                Sacar(transf);
                destino.Depositar(transf);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
