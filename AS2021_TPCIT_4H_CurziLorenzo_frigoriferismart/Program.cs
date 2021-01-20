using System;
using AS2021_TPCIT_4H_CurziLorenzo_frigoriferismart.Models;

namespace AS2021_TPCIT_4H_CurziLorenzo_frigoriferismart
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programma frigoriferi smart di Lorenzo Curzi, 4H");

            //creo un array contentente 4 prodotti
            Prodotti[] products = new Prodotti[4];

            products[0] = new Prodotti("AAA123", "Mele", 2021, 50, 5);
            products[1] = new Prodotti("AAA124", "Carne", 2021, 1400, 1);
            products[2] = new Prodotti("AAA125", "Pesce", 2019, 600, 2);
            products[3] = new Prodotti("AAA126", "Pasta", 2025, 900, 7);

            Console.WriteLine("Lista dei prodotti all'interno del frigorifero");
            Console.WriteLine();
            //Visualizzo tutti i prodotti all'interno del frigorifero
            for(int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].VisualizzaProdotti());
            }

            Console.WriteLine();
            Console.WriteLine("Lista dei prodotti scaduti all'interno del frigorifero");
            Console.WriteLine();
            //Visualizzo eventuali prodotti scaduti
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].VisualizzaProdottiScaduti());
            }

            Console.WriteLine();
            //Calcolo dei prodotti presente inserito il codice
            Console.WriteLine("Inserire il codice del prodotto che si vuole cercare:");
            string codice = Console.ReadLine();
            int j = - 1;

            for (int i = 0; i < products.Length; i++)
            {
                bool ris = products[i].Calcoloprodotti(codice);

                if (ris)
                    j = i; //salvo la posizione in cui si trova il prodotto cercato
            }

            if (j != -1)
                Console.WriteLine($"Il prodotto cercato è: {products[j].ToString()}");
            else
                Console.WriteLine("Prodotto non trovato.");
        }
    }
}
