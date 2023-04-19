using ByteBank.Sistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    internal abstract class FuncionarioLogavel : Funcionario, ILogin
    {
        protected FuncionarioLogavel(string nome, string cpf, double salario, string usuario, string senha) : base(nome, cpf, salario)
        {
            this.Senha = senha;
            this.Usuario = usuario;
        }

        public override abstract double AumentarSalario();

        public string Senha { get; set; }
        public string Usuario { get; set; }
    }
}
