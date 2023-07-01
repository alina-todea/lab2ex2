using System;

namespace Lab2ex2
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * Scrieti o functie care va determina daca un numar este sau nu palindrom.
             */

            Console.WriteLine("Introduceti un numar intreg");
            int numar = int.Parse(Console.ReadLine());

            if (EstePalindrom(numar))
            {
                Console.WriteLine("Numarul " + numar + " este palindrom");
            }
            else
            {
                Console.WriteLine("Numarul " + numar + " nu este palindrom");
            }

        }

        static bool EstePalindrom(int numar)
        {
            bool result = false;
            int intermediar = numar;
            int numarNou = 0;
            int ultimaCifra = 0;


            while (intermediar>0)
            {
                ultimaCifra = intermediar % 10;
                numarNou = (numarNou * 10) + ultimaCifra;
                intermediar = intermediar / 10;

            }

            if (numarNou == numar)
            {
                result = true;
            }
            
            return result;

        }
    }
}
