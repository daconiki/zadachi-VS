using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp166
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете n за елементи");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Въведете елемент");
                arr[i] = int.Parse(Console.ReadLine());

            }
            int sum = 0;
            int min = arr[0];
            int max = arr[0];
            int avr = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];

                if (min > arr[i]) min = arr[i];
                if (max < arr[i]) max = arr[i];
                avr = sum / n;
            }

            Console.WriteLine("Сумата на масива е "+sum);
            Console.WriteLine("Минималният елементе е "+min);
            Console.WriteLine("Максималният елемент е "+max);
            Console.WriteLine("Средното аритметично е "+avr);
        }
    }
}
