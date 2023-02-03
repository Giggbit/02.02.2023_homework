using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Массивы_в.NET_homework_02._02._2023
{
    internal class Program
    {
        public static void Swap(ref int a, ref int b) {
            int c = 0;
            c = a;
            a = b;
            b = c;
        }

        static void Main(string[] args)
        {
            #region ex1
            /*int[] mas = new int[10];
            Random rand = new Random();
            for(int i = 0; i < mas.Length; i++) {
                mas[i] = rand.Next(1,101);
                Console.Write($"{mas[i]}  ");
            }

            Console.WriteLine("\n");
            int[] mas_nechet = new int[10];
            for(int i = 0; i < mas.Length; i++) {
                if (mas[i] % 2 != 0) {
                    mas_nechet[i] = mas[i];
                }
                Console.Write($"{mas_nechet[i]}  ");
            }

            int max_nechet = 0, position = 0;
            for (int i = 0; i < mas_nechet.Length; i++) { 
                if(max_nechet < mas_nechet[i]) { max_nechet = mas_nechet[i]; position = i; }
            }
            Console.WriteLine($"\nMax nechet = {max_nechet}\nPosition = {position}\n");

            int a = mas[position];
            for(int i = position + 1; i < mas.Length; i++) {
                Swap(ref mas[position], ref mas[i]);
                position++;
            }
            for(int i = 0; i<mas.Length; i++) {
                Console.Write($"{mas[i]}  ");
            }*/
            #endregion

            #region ex2
            /*int[] mas = new int[10];
            Random rand = new Random();
            for(int i = 0; i < mas.Length; i++) {
                mas[i] = rand.Next(0,5);
                Console.Write($"{mas[i]}  ");
            }
            Console.WriteLine("\n");

            int sum = 0;
            for(int i = 0; i < mas.Length; i++) {
                if (mas[i] == 0) {
                    i++;
                    while (mas[i] != 0) { sum += mas[i]; i++; }
                }
            } Console.WriteLine($"Sum = {sum}");*/
            #endregion

            #region ex3

            #endregion

        }
    }
}
