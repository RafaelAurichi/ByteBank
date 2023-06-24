using System;
using ByteBank.Titular;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using ByteBank.Exceptions;

namespace ByteBank.Contas
{
    public class ContaCorrente
    {
        public static int TotalContasCriadas { get; private set; }

        public ContaCorrente(string numConta, int numAgencia, Cliente titular)
        { 
            Titular = titular;
            NumConta = numConta;
            NumAgencia = numAgencia;
            TotalContasCriadas++;
        }

        public string NumConta { get; private set; }
        public Cliente Titular { get; set; }

        private int _numAgencia;
        public int NumAgencia
        {
            get { return _numAgencia; }

            private set {
                if (value <= 0)
                {
                    //throw new ArgumentException("Agência número 0 não existe.");
                    throw new NumAgenciaInvalidoException("Não existem agências com o número 0 ou menor.");
                }
                else
                {
                    _numAgencia = value;
                }
            }
        }

        private double _saldo;
        public double Saldo
        {
            get { return _saldo; }

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
