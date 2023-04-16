using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Titular
{
    public class Cliente
    {
        public Cliente(string nome, string cpf)
        {
            this.Nome = nome;
            this.Cpf = cpf;
        }

        public string Nome { get; private set; }
        public string Cpf { get; private set; }
        public string Profissao { get; set; }
    }
}
