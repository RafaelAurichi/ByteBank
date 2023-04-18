using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public abstract class Funcionario
    {
        public string Nome { get; private set; }
        public string Cpf { get; private set; }
        public double Salario { get; protected set; }

        //Construtor
        public static int TotalFuncionarios { get; private set; }

        public Funcionario(string nome, string cpf, double salario)
        {
            this.Nome = nome;
            this.Cpf = cpf;
            this.Salario = salario;
            TotalFuncionarios++;
        }

        //Metodos
        public virtual double Bonificar() => this.Salario = this.Salario + (this.Salario * 0.10);
        public virtual double GetBonificacao() => this.Salario * 0.10;
        public abstract double AumentarSalario();        
    }
}
