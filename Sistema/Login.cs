using System;
using ByteBank.Funcionarios;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Metadata.Ecma335;

namespace ByteBank.Sistema
{
    public abstract class Login:Funcionario
    {
        protected Login(string nome, string cpf, double salario, string usuario, string senha) : base(nome, cpf, salario)
        {
            this.usuario = usuario;
            this.senha = senha;
        }

        public abstract override double AumentarSalario();

        //Senha
        private string senha;
        public string usuario { get; private set; }

        public bool Autenticar(string usuario, string senha)
        {
            if ((this.senha == senha) && (this.usuario == usuario))
            {
                Console.WriteLine("Login realizado com sucesso!");
                return true;
            }
            else
            {
                Console.WriteLine("Login inválido!");
                return false;
            }
        }
    }
}