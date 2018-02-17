using System;
using System.Linq;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace EasyUtilities.Math
{
    /// <summary>
    /// Extensions applicable for Math operations.
    /// </summary>
    public static class MathExtensions
    {
        /// <summary>
        /// Performs '+' operation on numerics of type int, long, short, float, double, decimal
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="operand1"></param>
        /// <param name="operand2"></param>
        /// <exception cref="System.TypeAccessException">Thrown when either or both of the operand types are not numeric.</exception>
        /// <returns></returns>
        public static T Add<T>(this T operand1, T operand2)
        {
            var type = typeof(T).Name;
            if (!ParallelEnumerable.Contains<string>((new string[] { "Int16", "Int32", "Int64", "Decimal", "Double", "Single" }).AsParallel(), type))
            {
                throw new TypeAccessException(string.Format("Cannot perform this operation with operands of type '{0}'.", type));
            }

            dynamic op1 = operand1;
            dynamic op2 = operand2;

            return (T)(op1 + op2);
        }
    }
}