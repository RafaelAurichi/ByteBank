using System;
using ByteBank.Funcionarios;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Metadata.Ecma335;
using ByteBank.Parceiros;

namespace ByteBank.Sistema
{
    public interface ILogin
    {
        public string Senha { get; set; }
        public string Usuario { get; set; }
    }
}