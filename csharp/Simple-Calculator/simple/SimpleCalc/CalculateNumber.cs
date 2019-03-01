using System;

namespace SimpleCalc
{
    public class CalculateNumber
    {
        public double Calculate(string method, double firstNumber, double SecondNumber)
        {
            double result;

            switch (method.ToLower())
            {
                case "tambah":
                case "+":
                    result = firstNumber + SecondNumber;
                    break;
                case "kurang":
                case "pengurangan":
                case "-":
                    result = firstNumber - SecondNumber;
                    break;
                case "pembagian":
                case "bagi":
                case "/":
                    result = firstNumber / SecondNumber;
                    break;
                case "perkalian":
                case "*":
                case "x":
                    result = firstNumber * SecondNumber;
                    break;
                default:
                    throw new Exception("Wrong Method {*,/,+,-}");
            }

            return result;
        }
    }
}
