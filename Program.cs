using System;
namespace DerivativeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter function :");
            Formula problem = new Formula(Console.ReadLine());
            Console.WriteLine("Your function : " + problem.ShowFormula());
        }
    }
}
