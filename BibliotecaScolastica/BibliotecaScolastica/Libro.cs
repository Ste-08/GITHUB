using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaScolastica
{
    internal class Libro
    {
        private string autore;
        private string titolo;
        private int annoPublicazione;
        private string editore;
        private int numeroPagine;

        public Libro(string autore, string titolo, int annoPublicazione, string editore, int numeroPagine, string autore, string titolo, int annoPublicazione, string editore, int numeroPagine)
        {
            Autore = autore;
            Titolo = titolo;
            AnnoPublicazione = annoPublicazione;
            Editore = editore;
            NumeroPagine = numeroPagine;
            Autore = autore;
            Titolo = titolo;
            AnnoPublicazione = annoPublicazione;
            Editore = editore;
            NumeroPagine = numeroPagine;
        }

        public string Autore
        {
            get { return autore; }
            set { autore = value; }
        }

        public string Titolo
        {
            get { return titolo; }
            set { titolo = value; }
        }

        public int AnnoPublicazione
        {
            get { return annoPublicazione; }
            set { annoPublicazione = value; }
        }

        public string Editore
        {
            get { return editore; }
            set { editore = value; }
        }

        public int NumeroPagine
        {
            get { return numeroPagine; }
            set { numeroPagine = value; }
        }

        public string toString()
        {
            return autore + " " + titolo + " " + annoPublicazione + " " + editore + " " + numeroPagine;

        }

        public string readingTime()
        {
            if (numeroPagine < 100)
            {
                return "1h";
            }
            else if (numeroPagine > 100 && numeroPagine < 200)
            {
                return "2h";
            }
            else if (numeroPagine < 200)
            {
                return "Più di 2h";
            }
        }
    }
}
