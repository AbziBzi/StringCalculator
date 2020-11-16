using System;

namespace StringCalculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int result = Converter.Add(number);
            Console.WriteLine(result);
        }
    }
}
