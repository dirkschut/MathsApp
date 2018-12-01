using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsApp
{
    /// <summary>
    /// A simple class which does some number conversions simply
    /// </summary>
    class NumberConversion
    {
        private int number = 0;

        /// <summary>
        /// Initialize the object with the decimal number set.
        /// </summary>
        /// <param name="number">The decimal number</param>
        public NumberConversion(int number)
        {
            this.number = number;
        }

        /// <summary>
        /// Sets the decimal base value.
        /// </summary>
        /// <param name="number">The decimal value</param>
        public void SetDecimal(int number)
        {
            this.number = number;
        }

        /// <summary>
        /// Returns the decimal value of the number as a string.
        /// </summary>
        /// <returns>The decimal value as a string</returns>
        public string GetDecimal()
        {
            return number.ToString();
        }

        /// <summary>
        /// Returns the hexadecimal value of the number as a string.
        /// </summary>
        /// <returns>The hexadecimal value as a string</returns>
        public string GetHexadecimal()
        {
            return number.ToString("X");
        }

        /// <summary>
        /// Returns the binary value of the number as a string.
        /// </summary>
        /// <returns>The binary value as a string</returns>
        public string GetBinary()
        {
            return Convert.ToString(number, 2);
        }
    }
}
