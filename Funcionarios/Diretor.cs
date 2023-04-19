using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    internal class Diretor:FuncionarioLogavel
    {
        //Construtor
        public Diretor(string nome, string cpf, double salario, string usuario, string senha) : base (nome, cpf, salario, usuario, senha)
        {

        }

        //Metodos
        public override double Bonificar() => this.Salario = this.Salario + (this.Salario * 0.5);
        public override double GetBonificacao() => this.Salario + (this.Salario * 0.5);
        public override double AumentarSalario() => this.Salario *= 1.15;
    }
}
