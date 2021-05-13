using System;
using Modulo_Comentarios_RedeSocial.Entities;


namespace Modulo_Comentarios_RedeSocial
{
    class Program
    {
        static void Main(string[] args)
        {
            Comentario c1 = new Comentario("Tenha uma boa viagem");
            Comentario c2 = new Comentario("Caramba, que incrível!");
            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Viajando para Nova Zelandia",
                "Estou indo visitar esse país incrível!",
                12);
            p1.AddComentario(c1);
            p1.AddComentario(c2);

            Comentario c3 = new Comentario("Boa Noite");
            Comentario c4 = new Comentario("Que a Força Esteja com Voce!");
            Post p2 = new Post(
                DateTime.Parse("28/07/2018 23:14:19"),
                "Boa Noite Pessoal!",
                "Vejo voces amanhã!",
                5);
            p2.AddComentario(c3);
            p2.AddComentario(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
