using System;
using System.Collections.Generic;
using System.Linq;

namespace MyFirstBlazorApp.Pages
{
    public partial class Sayani
    {
        /// <summary>
        /// Determines whether a specified number is a happy number.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <param name="interations">The number of interations to test for convergence.</param>
        public bool IsHappyNumber(int number, int interations = 1000000) //number = 7
        {
            for (int i = 0; i < interations; i++)
            {
                number = GetSumOfDigitsSquared(number);

                if (number == 1)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Calculates the sum of squares of each digit in the passed number.
        /// </summary>
        /// <param name="number"> The number to find the sum of the squared digits.</param>
        public int GetSumOfDigitsSquared(int number)
        {

            if (number <= 0)
            {
                throw new ArgumentOutOfRangeException("Number must be greater than 0.");
            }

            var numberAsAString = number.ToString();

            var sumOfSquares = 0;

            foreach (var digit in numberAsAString)
            {
                var d = char.GetNumericValue(digit);
                var digitSquared = Math.Pow(d, 2);
                sumOfSquares += (int)digitSquared;
            }
            return sumOfSquares;
        }

        /// <summary>
        /// Checks for repeated numbers in a set of years.
        /// </summary>
        /// <param name="rangeOfYrs">The range of years to search.</param>
        /// <returns>The number of repeated digits.</returns>
        /// <exception cref="System.ArgumentOutOfRangeException">Year must be greater than 0.</exception>
        public int YrsInARange(List<int> rangeOfYrs)
        {
            var repeatedDigitCount = 0;

            foreach (var year in rangeOfYrs)
            {
                if (year <= 0)
                {
                    throw new ArgumentOutOfRangeException("Year must be greater than 0.");
                }
                else
                {
                    var digitsDict = new Dictionary<int, string>();

                    var yearAsAString = year.ToString();

                    bool duplicateAdded = false;

                    foreach (var digit in year.ToString())
                    {
                        var digitAsNum = char.GetNumericValue(digit);

                        try
                        {
                            digitsDict.Add((int)digitAsNum, digitAsNum.ToString());
                        }
                        catch (Exception)
                        {
                            if (!duplicateAdded)
                            {
                                repeatedDigitCount += 1;
                                duplicateAdded = true;
                            }
                        }
                    }
                }
            }
            return repeatedDigitCount;
        }

        public double Product(double num1, double num2)
        {
            return num1 * num2;
        }

        public string ReverseString(string text)
        {
            char[] charArray = text.ToCharArray();
            string reversed = String.Empty;
            for (int i = charArray.Length - 1; i >= 0; i--)
            {
                reversed += charArray[i];
            }
            return reversed;
        }

        /// <summary>
        /// Determines whether a word is a palindrome.
        /// </summary>
        /// <param name="text">The word to test.</param>
        public bool IsPalindrome(string text)
        {
            text = text.ToUpper();

            char[] charArray = text.ToCharArray();
            string reversed = "";
            for (int i = charArray.Length - 1; i >= 0; i--)
            {
                reversed += charArray[i];
            }

            if (reversed == text)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
