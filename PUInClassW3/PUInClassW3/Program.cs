using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUInClassW3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want to play some music?");
            String answer = Console.ReadLine();
            Console.WriteLine($"My answer is:{answer}");
            if (answer == "Yes")
            {
                Console.WriteLine("Playing music ....!!!");
            }
            else if (answer == "No")
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Wrong input!");
            }
        }
    }
}
