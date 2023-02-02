using System;
using System.Text;

namespace convertIntegerToRoman
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
            var num = 36;
            var values =  new int[13] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            var romanl = new string[] { "M", "CM", "D", "CD", "C", "XC","L","XL","X","IX","V","IV","I" };
            var a = new string[2];

            StringBuilder roman = new StringBuilder();
            
            for(int i = 0; i < values.Length; i++)
            {
                while (num >= values[i])
                {
                    num = num-values[i];
                    roman.Append(romanl[i]);
                    

                }
            }
            Console.WriteLine(roman.ToString());
        }
    }
}
