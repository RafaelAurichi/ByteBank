using ByteBank.Sistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Parceiros
{
    public class ParceiroComercial : ILogin
    {
        public string Nome { get; set; }
        public int Id { get; set; }
        public string Senha { get; set; }
        public string Usuario { get; set; }
        public ParceiroComercial(string nome, int id, string usuario, string senha)
        {
            this.Nome = nome;
            this.Id = id;
            this.Usuario = usuario;
            this.Senha = senha;
        }

    }
}
