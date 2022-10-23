using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace итоговый_тест
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Написать программу, которая из имеющегося массива строк формирует массив из строк, длинна кторых меньше либо равна 3 символам.");

            int i = 0;
            int j = 0;
            string[] arr = new string[] { "Привет", "Мир", "3", "Это слишком длинная строка", "Кот" };
            string[] arr2 = new string[arr.Length];

            Console.WriteLine(" ");
            Console.WriteLine("Исходный массив: {0} ", String.Join("  ", arr));
      
         for (i = 0; i < arr.Length; i++)
         {
                if(arr[i].Length <=  3 )
                {
                    
                    arr2[j] = arr[i];
                    j++;
                    
                }

         }

            Console.WriteLine(" ");
            Console.WriteLine("Фильтрованный массив: {0} ", String.Join("  ", arr2));
             
            Console.ReadKey();
        }
    }
}
