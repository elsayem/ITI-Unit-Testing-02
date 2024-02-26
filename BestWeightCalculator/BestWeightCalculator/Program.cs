using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestWeightCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            WeightCalculator weight = new WeightCalculator { 
            Height = 170,
            Gender='m'};

            double w = weight.GetBestWeight();           
            Console.WriteLine($"The Ideal Weight is {w}");
            double testValue = 65;
            if(w == testValue)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Test Succeeded");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Test Failed");
            }
            Console.ReadLine();

        }
    }
}
