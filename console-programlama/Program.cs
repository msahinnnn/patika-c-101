using System;

namespace console_programlama
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("İsminizi girin:");
            String name = Console.ReadLine();
            Console.WriteLine("Soyisminizi girin:");
            String surName = Console.ReadLine();


            Console.WriteLine("Merhaba " + name + " " + surName);
        }
    }
}
