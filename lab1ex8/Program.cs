﻿using System;

namespace lab1ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Ex 8
            Se citesc doua numere de la tastatura, x si y. Scrieti un program care va verifica
            daca x este divizibil cu y.
            In cazul in care x este divizibil cu y, programul va afisa “divizibil” iar in caz contrar,
            “indivizibil”.
             */

            int x;
            int y;
            Console.WriteLine("Introduceti primul numar: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti al doilea numar: ");
            y = int.Parse(Console.ReadLine());

            if (x % y == 0)
            {
                Console.WriteLine("divizibil");
            }
            else
            {
                Console.WriteLine("indivizibil");
            }
        }
    }
}
