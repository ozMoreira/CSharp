using System;

namespace Reserva_Hotel_TE.Entities.Exceptions
{
    class DomainException : ApplicationException 
    {
        public DomainException(string mensagem) : base(mensagem)
        {

        }
    }
}
