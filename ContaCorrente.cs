using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class ContaCorrente
    {
        public int numAgecia;
        public string numConta;
        public string titular;
        public double saldo;

        public void Depositar(double deposito)
        {
            this.saldo += deposito;
        }

        public bool Sacar(double saque)
        {
            if (this.saldo >= saque) 
            { 
                this.saldo -= saque;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Transferir(double transf, ContaCorrente destino)
        {
            if (this.saldo >= transf)
            {
                this.Sacar(transf);
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
