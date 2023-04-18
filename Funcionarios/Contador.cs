using ByteBank.Sistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    internal class Contador:Login 
    {
        //Construtor
        public Contador(string nome, string cpf, double salario, string usuario, string senha) : base(nome, cpf, salario, usuario, senha)
        {

        }

        //Metodos
        public override double AumentarSalario() => this.Salario *= 1.15;
    }
}
