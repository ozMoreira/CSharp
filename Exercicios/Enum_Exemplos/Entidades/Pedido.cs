using Enum_Exemplos.Entidades.Enums;
using System;

namespace Enum_Exemplos.Entidades
{
    class Pedido
    {
        public int Id { get; set; }
        public DateTime Momento { get; set; }
        public StatusPedido Status { get; set; }

        public override string ToString()
        {
            return Id
                + ", "
                + Momento
                + ", "
                + Status;

        }
    }
}
