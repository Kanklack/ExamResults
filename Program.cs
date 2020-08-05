using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamResults
{
    class Program
    {
         static void Main(string[] args)
        { 
            Console.WriteLine("Please enter your mark: ");

            int mark = Convert.ToInt32(Console.ReadLine());


            if (mark >= 80)
            {

                Console.WriteLine("Distinction");

            }

            else if (mark >= 60) {

                Console.WriteLine("Merit");

            }

            else if (mark >= 40)
            {

                Console.WriteLine("Pass");

            }

            else
            {

                Console.WriteLine("Fail");

            }

            Console.Read();
        }
    }
}
