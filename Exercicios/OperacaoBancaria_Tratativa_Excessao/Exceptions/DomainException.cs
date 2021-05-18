using System;

namespace OperacaoBancaria_Tratativa_Excessao.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string mensagem) : base(mensagem)
        {
        }
    }
}
