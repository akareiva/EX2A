using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageSpecificNumber
{
    class Program
    {
        public void sumAverage(int[] arr, int num)
        {

            int sum = 0;
            int avg = 0;
            for (int i = 0; i < num; i++)
            {
                sum += arr[i];
            }
            avg = sum / num;
            Console.WriteLine("Sum Of Test Scores is : " + sum);
            Console.WriteLine("Average Of Test Scores is : " + avg);
            Console.ReadLine();
        }
            static void Main(string[] args)
        {
                int num;
                Console.WriteLine("Enter the Number of Tests :");
                num = Convert.ToInt32(Console.ReadLine());
                int[] a = new int[num];
                Console.WriteLine("Enter the Test Scores : ");
                for (int i = 0; i < num; i++)
                {
                    a[i] = Convert.ToInt32(Console.ReadLine());
                }
                int len = a.Length;
                //program pg = new program();
                //pg.sumAverage(a, len);
            }
    }
}
