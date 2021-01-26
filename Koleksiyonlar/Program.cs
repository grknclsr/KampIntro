using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[]
            {
                "Engin","Murat", "Halil","Gürkan"
            };

            List<string> isimler2 = new List<string>() { "Murat", "Kerem", "Halil", "Gürkan" };

            isimler2.Add("Ahmet");

            Console.WriteLine(isimler2[4]);
        }
    }
}
