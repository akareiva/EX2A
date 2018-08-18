using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculating_Averages2
{
    class Program
    {
        static void Main(string[] args)

        {
            int num1, num2, num3, num4, num5, num6, num7, num8, num9, num10, sum;
            double avg;





            Console.Write("Insert a number between 0 and 100 to calculate their sum");
            Console.Write("First number:");
            num1 = Convert.ToInt32(Console.ReadLine());
            while (num1 <= 0 || num1 >= 100)
            {
                Console.WriteLine("Invalid Entry");
                Console.WriteLine("Enter number again");
                num1 = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Second number:");
            num2 = Convert.ToInt32(Console.ReadLine());
            while (num2 <= 0 || num2 >= 100)
            {
                Console.WriteLine("Invalid Entry");
                Console.WriteLine("Enter number again");
                num2 = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Third number:");
            num3 = Convert.ToInt32(Console.ReadLine());
            while (num3 <= 0 || num3 >= 100)
            {
                Console.WriteLine("Invalid Entry");
                Console.WriteLine("Enter number again");
                num3 = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Fourth number:");
            num4 = Convert.ToInt32(Console.ReadLine());
            while (num4 <= 0 || num4 >= 100)
            {
                Console.WriteLine("Invalid Entry");
                Console.WriteLine("Enter number again");
                num4 = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Fifth number:");
            num5 = Convert.ToInt32(Console.ReadLine());
            while (num5 <= 0 || num5 >= 100)
            {
                Console.WriteLine("Invalid Entry");
                Console.WriteLine("Enter number again");
                num5 = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Sixth number:");
            num6 = Convert.ToInt32(Console.ReadLine());
            while (num6 <= 0 || num6 >= 100)
            {
                Console.WriteLine("Invalid Entry");
                Console.WriteLine("Enter number again");
                num6 = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Seventh number:");
            num7 = Convert.ToInt32(Console.ReadLine());
            while (num7 <= 0 || num7 >= 100)
            {
                Console.WriteLine("Invalid Entry");
                Console.WriteLine("Enter number again");
                num7 = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Eigth number:");
            num8 = Convert.ToInt32(Console.ReadLine());
            while (num8 <= 0 || num8 >= 100)
            {
                Console.WriteLine("Invalid Entry");
                Console.WriteLine("Enter number again");
                num8 = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Ninth number:");
            num9 = Convert.ToInt32(Console.ReadLine());
            while (num9 <= 0 || num9 >= 100)
            {
                Console.WriteLine("Invalid Entry");
                Console.WriteLine("Enter number again");
                num9 = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Tenth number:");
            num10 = Convert.ToInt32(Console.ReadLine());
            while (num10 <= 0 || num10 >= 100)
            {
                Console.WriteLine("Invalid Entry");
                Console.WriteLine("Enter number again");
                num10 = Convert.ToInt32(Console.ReadLine());
            }
            sum = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10;
           
            avg = sum / 10;

            while (avg >= 90.0)
            {
                Console.WriteLine("Letter Grade is an A");
                avg = Convert.ToInt32(Console.ReadLine());
            }
            while (avg >= 80.0)
            {
                Console.WriteLine("Letter Grade is a B");
                avg = Convert.ToInt32(Console.ReadLine());
            }
            while (avg >= 70.0)
            {
                Console.WriteLine("Letter Grade is a C");
                avg = Convert.ToInt32(Console.ReadLine());
            }
            while (avg >= 60.0)
            {
                Console.WriteLine("Letter Grade is a D");
                avg = Convert.ToInt32(Console.ReadLine());
            }
            while (avg < 60.0)
            {
                Console.WriteLine("Letter Grade is a F");
                avg = Convert.ToInt32(Console.ReadLine());
            }
            Console.ReadKey();

        }

        
    }
}
