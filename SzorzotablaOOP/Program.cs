using System;
using SzorzotablaOOP;

namespace SzorzotablaOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] eredmenyek;

            Szorzotabla szorzotabla2 = new Szorzotabla();
            szorzotabla2.SetSzam(5);
            szorzotabla2.SetEredmény();
            eredmenyek = szorzotabla2.GetEredmény();
            Console.WriteLine("A 3-as szorzótábla:");
            for (int i = 1; i <= 9; i++)
            {
                Console.WriteLine($"{i} * 3 = {eredmenyek[i]}");
            }
        }
    }
}
