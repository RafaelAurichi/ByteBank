using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Exceptions
{
    internal class NumAgenciaInvalidoException : Exception
    {
        public NumAgenciaInvalidoException(string message) : base(message) 
        { 
        
        }
    }
}
