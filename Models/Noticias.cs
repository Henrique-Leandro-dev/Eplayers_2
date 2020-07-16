using System;
using System.Collections.Generic;
using System.IO;
using Eplayers_2.Interfaces;

namespace Eplayers_2.Models
{
    public class Noticias : EPlayersBase , INoticias
    {
        public int IdNoticia { get; set; }
        public string Titulo { get; set; }
        public string Texto { get; set; }
        public string Imagem { get; set; }

        private const string PATH = "Database/noticias.csv";

        public Noticias()
        {
            CreateFolderAndFile(PATH);
        }
        public void Create(Noticias no)
        {
            string[] linhas = {PrepararLinha(no)};
            File.AppendAllLines(PATH, linhas);
        }

        private string PrepararLinha (Noticias no)
        {
            return $"{no.IdNoticia};{no.Titulo};{no.Texto};{no.Imagem}";
        }

        public void Delete(int IdNoticia)
        {
            List<string> linhas = ReadAllLinesCSV(PATH);
           
            linhas.RemoveAll(a => a.Split(";")[0] == IdNoticia.ToString());

            RewriteCSV(PATH, linhas);
        }

        public List<Noticias> ReadAll()
        {
            List<Noticias> news = new List<Noticias>();
            string[] linhas = File.ReadAllLines(PATH);
            foreach (var item in linhas)
            {
                string[] linha = item.Split(";");
                Noticias noticia = new Noticias();
                noticia.IdNoticia = Int32.Parse(linha[0]);
                noticia.Titulo = linha[1];
                noticia.Texto = linha[2];
                noticia.Imagem = linha[3];

                news.Add(noticia);
            }
            return news;
        }

        public void Update(Noticias no)
        {
            List<string> linhas = ReadAllLinesCSV(PATH);
            
            linhas.RemoveAll(a => a.Split(";")[0] == no.IdNoticia.ToString());
            linhas.Add( PrepararLinha(no) );
            RewriteCSV(PATH, linhas);
        }
        
    }
}