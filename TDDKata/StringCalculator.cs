using System;
using System.Linq;

namespace TDDKata.StringCalculator
{
    public class StringCalculator
    {
        public int Add(string numbersToAdd)
        {
            return string.IsNullOrEmpty(numbersToAdd) ? 0 : numbersToAdd.Split(",").Sum(Convert.ToInt32);
        }
    }
}