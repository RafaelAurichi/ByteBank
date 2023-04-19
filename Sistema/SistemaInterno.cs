using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Sistema
{
    internal class SistemaInterno
    {
        public bool LoginAutenticar(ILogin logavel,  string usuario, string senha)
        {
            if (logavel.Senha == senha && logavel.Usuario == usuario)
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
