using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplySubtractAndDivideUsingAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = -20;
            int b = 5;

            Console.WriteLine("{0} * {1} = {2}", a, b, Multiply(a, b));
            Console.WriteLine("{0} - {1} = {2}", a, b, subtract(a, b));
            Console.WriteLine("{0} / {1} = {2}", a, b, divide(a, b));
        }

        // Implement multiply using the add operator 
        // Todo - Does not work when b is negative
        static int Multiply(int a, int b)
        {
            int product = 0;

            for (int i = 0; i < Math.Abs(b); i++)
            {
                product += a;
            }

            if (b < 0)
            {
                product = Negate(product);
            }

            return product;
        }

        static int Negate(int value)
        {
            int neg = 0;
            int d = value < 0 ? 1 : -1;

            while (value != 0)
            {
                neg += d;
                value += d;
            }

            return neg;
        }

        // Subtract
        static int subtract(int a, int b)
        {
            int result = 0;

            return a + Negate(b);
        }


        // Divide
        // Todo - Does not work when b is negative
        static int divide(int a, int b)
        {
            if (b == 0)
            {
                throw new InvalidOperationException("Cannot divide by 0");
            }

            int result = 0;

            int num = b;

            while (Math.Abs(num) <= Math.Abs(a))
            {
                result++;
                num += b;
            }

            if ((a > 0 && b > 0) && (a < 0 && b < 0))
            {
                return result;
            }
            else
            {
                return Negate(result);
            }
        }
    }
}
