using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_plecakowy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ile_przedmiotow;
            int pojemnosc_plecaka;

            Console.WriteLine("Podaj ilość przedmiotów, z których trzeba wybrać: ");
            ile_przedmiotow = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj udzwig plecaka");
            pojemnosc_plecaka = int.Parse(Console.ReadLine());
            Backpack plecak = new Backpack(ile_przedmiotow, pojemnosc_plecaka);
            //plecak.WriteToConsole();
            Console.WriteLine(plecak);
            plecak.sort(ile_przedmiotow);
            Console.WriteLine("Posortowane przedmioty względem wartości:\n");
            //plecak.WriteToConsole();
            Console.WriteLine(plecak);
            Console.WriteLine("Pakowanie plecaka:\n");
            plecak.packing(ile_przedmiotow);
            Console.Read();

        }
    }
}
