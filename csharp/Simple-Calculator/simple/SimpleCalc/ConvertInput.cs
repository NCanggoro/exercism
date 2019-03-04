using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCalc
{
    public class ConvertInput
    {
        public double Convert(string textInput)
        {
            if (!double.TryParse(textInput, out double n)) throw new Exception("Number Expected");
            return n;
        }
    }
}
