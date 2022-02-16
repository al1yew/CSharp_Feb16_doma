using System;

namespace Feb16_doma_domashka_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stringlerden ibaret array-i və char qəbul edən metod yazın.Arrayin hansi index-də
            //bu qəbul edilən char varsa, o string-ləri ekranda yazdirin
           
            Console.WriteLine("Salam, sizi xosh gorduk. Bize bir soz ve ya cumle gonderin, ardi ise surpriz olsun!))");

            //string[] array = new string[] { };
            //string str = Console.ReadLine();
            //Array.Resize(ref array, array.Length + 1);
            //array[array.Length - 1] = str;
            //Console.WriteLine(' ');
            //Console.WriteLine("Indi ise bir dene herf daxil edin!");
            //string abc = Console.ReadLine();
            //char b = char.Parse(abc);
            // ---- Readline ile yoxladim, niyese ishlemedi, yegin sehv resize-dadir, duzelish aparacam ustunde. ona gore en sade metodla yazdim, 
            //      umud edirem duzdur.

            string[] array = { "Hello", "There", "World", "I", "like", "coffee", };
            char b = 'o';
            FindChar(array, b);
        }
        static void FindChar(string[] str, char ch) 
        {
            foreach (string item in str)
            {
                if (item.Contains(ch))
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
