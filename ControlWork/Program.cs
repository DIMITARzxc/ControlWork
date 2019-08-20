using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlWork
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s= "Kharkiv=143000,320;Kqwrtyqw=12490,319;LosAngeles=124000,450" ;
            Console.WriteLine("Input:");
             string s = Console.ReadLine();
            string[] input = s.Split(';');
            string[] city = new string[input.Length];
            string[] elemnt = new string[input.Length];
            string[] square = new string[elemnt.Length];
            for(int i=0; i < city.Length-1; i++)
            {
                city = input[i].Split('=');
               

            }
            if (city[0].Length > city[1].Length && city[0].Length>city[2].Length)
            {
                Console.WriteLine("Longest name " + city[0], city[0].Length);
            }
            if (city[0].Length < city[1].Length || city[1].Length > city[2].Length)
            {
                Console.WriteLine("Longest name " + city[1], city[1].Length);
            }
            if (city[2].Length > city[0].Length || city[2].Length > city[1].Length)
            {
                Console.WriteLine("Longest name " + city[2], city[2].Length);
            }
            for (int i = 0; i < square.Length - 1; i++)
            {
                square = input[i].Split(',');
                
                

            }
            //Console.WriteLine(square[0]);
            string[] numbers = new string[input.Length];
            string[] kil = new string[numbers.Length];
            for (int i = 0; i < input.Length; i++)
            {
                numbers = input[i].Split(',');
                kil = numbers[i].Split(',');
                Console.WriteLine(numbers[0]);
                Console.WriteLine(kil[0]);

            }

            //           Console.WriteLine(input[0]);
            Console.ReadKey();
        }
    }
}
