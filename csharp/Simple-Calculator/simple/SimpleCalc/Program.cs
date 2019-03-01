using System;

namespace SimpleCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ConvertInput convertInput = new ConvertInput();
                CalculateNumber calculateNumber = new CalculateNumber();

                double firstNumber = convertInput.Convert(Console.ReadLine());
                double secondNumber = convertInput.Convert(Console.ReadLine());
                string method = Console.ReadLine();

                double result = calculateNumber.Calculate(method, firstNumber, secondNumber);
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                //log the message
                Console.WriteLine(ex.Message);

            }

            Console.ReadLine();



        }
    }
}