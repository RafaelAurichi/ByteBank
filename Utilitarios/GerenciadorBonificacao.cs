using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Utilitarios
{
    internal class GerenciadorBonificacao
    {
        public double TotalBonificacoes { get; private set; }

        public double GetTotalBonificacoes(Funcionario funcionario) => TotalBonificacoes += funcionario.GetBonificacao();
    }
}
