using BibliotecaScolastica;
using System;

class Program
{
    static void Main(string[] args)
    {
        bool ancoraLibro = false;
        Console.WriteLine("Benvenuto nella biblioteca");
        Console.WriteLine("Stabilire l'indirizzo della biblioteca:");
        string indirizzo = Console.ReadLine();
        Console.WriteLine("Inserire il nome della biblioteca: ");
        string nomeBiblioteca = Console.ReadLine();
        Console.WriteLine("Inserire l'orario di apertura: ");
        int orarioApertura = int.Parse(Console.ReadLine());
        Console.WriteLine("Inserire l'orario di chiusura: ");
        int orariochiusura = int.Parse(Console.ReadLine());
        Biblioteca biblioteca = new Biblioteca(nomeBiblioteca, indirizzo, orarioApertura, orariochiusura);
        biblioteca.salva();
        do
        {
            Console.WriteLine("Inserisci il titolo del libro: ");
            string nomeLibro = Console.ReadLine();
            Console.WriteLine("Inserisci l'autore del libro: ");
            string autoreLibro = Console.ReadLine();
            Console.WriteLine("Inserisci l'anno di pubblicazione: ");
            int annoPubblicazione = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserisci l'editore: ");
            string editore = Console.ReadLine();
            Console.WriteLine("Inserisci il numero di pagine: ");
            int nPagine = int.Parse(Console.ReadLine());
            Libro libro = new Libro(autoreLibro, nomeLibro, annoPubblicazione, editore, nPagine);
            
            Console.WriteLine("Vuoi aggiungere altri libri? s per continuare...");
            if(Console.ReadLine() == "s")
            {
                ancoraLibro = true;
            }
            else
            {
                ancoraLibro = false;
            }
            biblioteca.aggiungiLibro(libro);
            biblioteca.salvaLibri();
        } while (ancoraLibro);

        Console.WriteLine("Scrivere 1 per cercare un libro con il titolo, " +
            "2 per cercare tutti i libri per autore," +
            "3 per determinare il numero di libri, ");
        switch (Console.ReadLine())
        {
            case "1":
                Console.WriteLine("Inserisci il nome dell'titolo:");
                biblioteca.cercaLibroPerTitolo(Console.ReadLine());
                break;

            case "2":
                Console.WriteLine("Inserisci il nome dell'autore: ");
                biblioteca.cercaLibroPerAutore(Console.ReadLine());
                break;
                case "3":
                Console.WriteLine(biblioteca.numeroLibri());
                break;
        } //Commento per program.cs
    }
}
