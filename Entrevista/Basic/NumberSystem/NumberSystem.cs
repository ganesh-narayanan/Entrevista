// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NumberSystem.cs" company="">
//   
// </copyright>
// <summary>
//   The number system.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GaneshNarayanan.Entrevista.Basic.NumberSystem
{
    using System;
    using System.Linq;

    using GaneshNarayanan.Entrevista.Basic.BitsManipulation;

    /// <summary>The number system.</summary>
    public static class NumberSystem
    {
        /// <summary>The add two numbers.</summary>
        /// <param name="numberOne">The number one.</param>
        /// <param name="numberTwo">The number two.</param>
        /// <returns>The <see cref="string"/>.</returns>
        public static string AddTwoNumbers(string numberOne, string numberTwo)
        {
            string response = string.Empty;

            int numberOneLength = numberOne.Length;
            int numberTwoLength = numberTwo.Length;

            int maxLength = BitManipulator.MinMaxCalculator(
                numberOneLength, 
                numberTwoLength, 
                numberOneLength, 
                numberTwoLength);
            int carry = 0;
            for (int i = maxLength - 1; i >= 0; i--)
            {
                int numberOneNum = 0, numberTwoNum = 0, remainder = 0;

                if (numberOneLength > i)
                {
                    numberOneNum = int.Parse(numberOne[i].ToString());
                }

                if (numberTwoLength > i)
                {
                    numberTwoNum = int.Parse(numberTwo[i].ToString());
                }

                int total = numberOneNum + numberTwoNum + carry;
                carry = total > 10 ? 1 : 0;
                remainder = total > 10 ? (total - 10) : total;
                response = remainder + response;
            }

            return response;
        }

        /// <summary>The convert to binary.</summary>
        /// <param name="value">The value.</param>
        /// <returns>The <see cref="string"/>.</returns>
        public static string ConvertToBinary(ulong value)
        {
            string binaryValue = string.Empty;
            ulong quotient;
            do
            {
                quotient = value / 2;
                binaryValue = (value % 2) + binaryValue;
                value = quotient;
            }
            while (quotient > 0);
            return binaryValue;
        }

        /// <summary>The convert to decimal.</summary>
        /// <param name="value">The value.</param>
        /// <returns>The <see cref="object"/>.</returns>
        /// <exception cref="OverflowException">The <paramref name="s"/> parameter represents a number less than <see cref="F:System.UInt64.MinValue"/> (9223372036854775807) or greater than <see cref="F:System.UInt64.MaxValue"/> (0). </exception>
        /// <exception cref="ArgumentOutOfRangeException">value length greater than 63.</exception>
        public static string ConvertToDecimal(string value)
        {
            char[] binaryNumber = value.Reverse().ToArray();
            if (!(binaryNumber.Length < 64))
            {
                throw new ArgumentOutOfRangeException(nameof(binaryNumber));
            }

            string response = "0";
            for (int i = 0; i < binaryNumber.Length; i++)
            {
                ulong number = ulong.Parse(binaryNumber[i].ToString());
                ulong interimValue = number * BitManipulator.PowerOf2(i);
                response = (ulong.Parse(response) + interimValue).ToString();
            }

            return response;
        }
    }
}