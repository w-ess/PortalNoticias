using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PortalDeNoticias.Models
{
    public class RepositorioNoticias
    {
        private static List<Noticia> noticias;

        public static List<Noticia> Noticias
        {
            get
            {
                if (noticias == null)
                    CriarNoticias();
                return noticias;
            }
        }

        private static void CriarNoticias()
        {
            noticias = new List<Noticia>();

            noticias.Add(new Noticia
            {
                Id = 1,
                Titulo = "Festa Hetohoky dos Karajás na Ilha do Bananal",
                Autor = "Joao",
                Conteudo = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"
            });

            noticias.Add(new Noticia
            {
                Id = 2,
                Titulo = "noticias 2",
                Autor = "Joao zezim",
                Conteudo = "bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb"
            });

            noticias.Add(new Noticia
            {
                Id = 3,
                Titulo = "titulo sei la",
                Autor = "claudio",
                Conteudo = "Cccccccccccccccccccccccccccccccccccc"
            });

            noticias.Add(new Noticia
            {
                Id = 4,
                Titulo = "noticia mundo",
                Autor = "maria",
                Conteudo = "ddddddddddddddddddddddddddddddddddddddd"
            });

            noticias.Add(new Noticia
            {
                Id = 5,
                Titulo = "ilha bela",
                Autor = "pedro",
                Conteudo = "eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee"
            });
        }
    }
}