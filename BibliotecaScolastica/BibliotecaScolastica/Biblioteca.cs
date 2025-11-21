using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaScolastica
{
    internal class Biblioteca
    {
        private string _nome;
        private string _indirizzo;
        private List<Libro> _libri;
        private int _oraApertura;
        private int _oraChiusura;

        public Biblioteca(string nome, string indirizzo, List<Libro> libri, int oraApertura, int oraChiusura)
        {
            _nome = nome;
            _indirizzo = indirizzo;
            _libri = libri;
            _oraApertura = oraApertura;
            _oraChiusura = oraChiusura;
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public string Indirizzo
        {
            get { return _indirizzo; }
            set { _indirizzo = value; }
        }

        public List<Libro> Libri
        {
            get { return _libri; }
            set { _libri = value; }
        }

        public int OraApertura
        {
            get { return _oraApertura; }
            set { _oraApertura = value; }
        }

        public int OraChiusura
        {
            get { return _oraChiusura; }
            set { _oraChiusura = value; }
        }

        public void aggiungiLibro(Libro libro)
        {
            Libri.Add(libro);
        }
        public void salva()
        {
            using (StreamWriter sw = new StreamWriter("biblioteca.txt", true))
            {
                sw.WriteLine(_nome + _indirizzo + _oraApertura + _oraChiusura + _libri);
            }
            Console.WriteLine("Dati salvati con successo!");
        }

        public void salvaLibri()
        {
            using (StreamWriter sw = new StreamWriter("libti.txt", true))
            {
                foreach (Libro libro in _libri)
                {
                    sw.WriteLine(libro);
                }
            }
            Console.WriteLine("Libri salvati con successo!");
        }

        public void cercaLibroPerTitolo(string titoloDaCercare)
        {
            using (StreamReader sr = new StreamReader("libri.txt", true))
            {
                foreach (Libro libro in _libri)
                {
                    sr.ReadLine();
                    if (libro.titolo == titoloDaCercare)
                    {
                        Console.WriteLine(libro);
                    }
                }
            }
        }

        public void cercaLibroPerAutore(string autoreDaCercare)
        {
            using (StreamReader sr = new StreamReader("libri.txt", true))
            {
                foreach (Libro libro in _libri)
                {
                    sr.ReadLine();
                    if (libro.autore == autoreDaCercare)
                    {
                        Console.WriteLine(libro);
                    }
                }
            }
        }

        public int numeroLibri()
        {
            int numeroLibri = 0;
            using (StreamReader sr = new StreamReader("libri.txt"))
            {
                foreach (Libro libro in _libri)
                {
                    numeroLibri++;
                }
            }
            return numeroLibri;
        }
    }
}
