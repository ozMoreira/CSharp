using System;
using System.Collections.Generic;
using System.Text;

namespace Modulo_Comentarios_RedeSocial.Entities
{
    class Comentario
    {
        public string Texto { get; set; }

        public Comentario()
        {

        }

        public Comentario(string texto)
        {
            Texto = texto;
        }
    }
}
