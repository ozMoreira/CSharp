using System;
using System.Collections.Generic;
using System.Text;

namespace Modulo_Comentarios_RedeSocial.Entities
{
    class Post
    {
        public DateTime Instante { get; set; }
        public string Title { get; set; }
        public string Conteudo { get; set; }
        public int Curtidas { get; set; }
        //Sempre que tiver uma lista, tenho que criar dois metodos, adiciona e remove para a lista
        public List<Comentario> Comentarios { get; set; } = new List<Comentario>();

        public Post()
        {

        }

        public Post(DateTime instante, string title, string conteudo, int curtidas)
        {
            Instante = instante;
            Title = title;
            Conteudo = conteudo;
            Curtidas = curtidas;
        }

        public void AddComentario(Comentario comentario)
        {
            Comentarios.Add(comentario);
        }

        public void RemoveComentario(Comentario comentario)
        {
            Comentarios.Remove(comentario);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append(Curtidas);
            sb.Append(" Likes - ");
            sb.AppendLine(Instante.ToString("dd/MM/yyy HH:mm:ss"));
            sb.AppendLine(Conteudo);
            sb.AppendLine("Comentários: ");
            foreach (Comentario c in Comentarios)
            {
                sb.AppendLine(c.Texto);
            }
            return sb.ToString();
        }
    }
}
