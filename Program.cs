using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int[] sayilar = { 10, 20, 30, 40, 50, 60 };
            string[] isimler= { "c "+" c#"+ " c+" };

            
                for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);
            }

            for (int i = 0; i < isimler.Length; i++)
            {
                Console.WriteLine(isimler[i]);
            }

            Console.ReadLine(); 

        }
    }
}
