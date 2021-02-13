using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> sehirplaka = new MyDictionary<string, int>();
            sehirplaka.Add("Adıyaman", 02);
            sehirplaka.Add("Antalya", 07);
            sehirplaka.Add("Denizli", 20);
            sehirplaka.Add("Konya", 42);
            sehirplaka.Add("Şırnak", 73);

            Console.WriteLine(sehirplaka.Count());

            sehirplaka.List();
        }
    }
}
