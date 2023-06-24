using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Titular
{
    public class Cliente : IDisposable
    {
        public Cliente(string nome, string cpf)
        {
            Nome = nome;
            Cpf = cpf;
        }

        public void Dispose()
        {
            Console.WriteLine("fechou!");
        }

        public string Nome { get; private set; }
        public string Cpf { get; private set; }
        public string Profissao { get; set; }
    }
}
