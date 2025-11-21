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
        do
        {
            Console.WriteLine("Inserisci il nome del libro: ");
            string nomeLibro = Console.ReadLine();

        } while (ancoraLibro);

    }
}