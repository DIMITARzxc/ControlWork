using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlWork
{
    class Program
    {
        struct City
        {
            public int Population;
            public int Name;
            public int Denisty;

        }
        static void Main(string[] args)
        {
            string s;
            
            Console.WriteLine("Enter city name, population,square ");
            s = Console.ReadLine();
            string[] words = s.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
           // string[] popul = s.Split(',');
            
           /* for(int i=0; i<popul.Length; i++)
            {
               
                Console.WriteLine(int.Parse("popul"));
            }*/
           // Console.WriteLine(int.Parse("popul"));
            
            string[] town = new string[words.Length];
            for(int i=0; i<words.Length; i++)
            {
                 town = words[i].Split('=');
                if (town[i].Length > town[i + 1].Length)
                {

                    Console.WriteLine("Most populated town =" + town[i]);
                }
                else
                {
                    Console.WriteLine("Most populated town = " + town[i + 1]);
                }
                
                
                Console.WriteLine(town[0]);
                
            }
            string[] numbers = new string[town.Length];
            string[] kil = new string[numbers.Length];
            for (int i = 0; i < words.Length; i++)
            {
                numbers = words[i].Split(',');
                kil = numbers[i].Split(',');
                Console.WriteLine(numbers[0]);
                Console.WriteLine(kil[0]);

            }
            

           
           
            Console.Read();


        }
    }
}
