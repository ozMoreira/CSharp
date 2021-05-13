using Enum_Exemplos.Entidades;
using Enum_Exemplos.Entidades.Enums;
using System;

namespace Enum_Exemplos
{
    class Program
    {
        static void Main(string[] args)
        {
            Pedido pedido = new Pedido
            {
                Id = 1080,
                Momento = DateTime.Now,
                Status = StatusPedido.PagamentoPendente
            };

            Console.WriteLine(pedido);
            //Converte Enum para String
            string txt = StatusPedido.PagamentoPendente.ToString();
            //Converte String para Enum
            StatusPedido os = Enum.Parse<StatusPedido>("Entregue");
            Console.WriteLine(os);
            Console.WriteLine(txt);
        }
    }
}
