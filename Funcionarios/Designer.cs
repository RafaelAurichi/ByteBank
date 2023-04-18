using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    internal class Designer:Funcionario
    {
        //Construtor
        public Designer(string nome, string cpf, double salario) : base(nome, cpf, salario)
        {

        }

        //Metodos
        public override double AumentarSalario() => this.Salario *= 1.15;
    }
}
