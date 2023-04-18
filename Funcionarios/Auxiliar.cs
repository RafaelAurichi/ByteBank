using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    internal class Auxiliar:Funcionario
    {
        //Construtor
        public Auxiliar(string nome, string cpf, double salario) : base(nome, cpf, salario)
        {

        }

        //Metodos
        public override double Bonificar() => this.Salario = this.Salario + (this.Salario * 0.5);
        public override double GetBonificacao() => this.Salario + (this.Salario * 0.05);
        public override double AumentarSalario() => this.Salario *= 1.1;
    }
}
