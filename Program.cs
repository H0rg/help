using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace test
{
    class Massive
    {
        // 
        // Почему я не могу внести значение переменной b в параметр int[b] когда создаю массив,
        // для того, что б указать размерность массива
        static int b;
        int start;
        int step;
        public Massive(int max, int start, int step)
        {
            b = max;
            this.start = start;
            this.step = step;

        }
        public int[] a = new int[b];
       

        public void Fill()
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = start;
                start += step;
                Console.Write($"{a[i]} ");
            }
            Console.WriteLine("");
        }

            
            
           
        public void Inverse()
        {
            int[] beta = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                beta[i] = -a[i];
                Console.Write($"{beta[i]} ");
            }
            Console.WriteLine("");
        }
        public void Multi()
        {
            Console.WriteLine("На какое число хотите умножить каждый элемент массива?: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = a[i] * n;
                Console.Write($"{a[i]} ");
            }
            Console.WriteLine("");
        }

    }


    class Program
    {

        static void Main(string[] args)
        {
            Massive array = new Massive(10, 1, 2);
            array.Fill();

        }
    }
}
