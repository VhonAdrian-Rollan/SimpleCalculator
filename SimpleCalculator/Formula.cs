using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public delegate int GetAnswer(int num1, int num2);
    class Formula
    {
        public static int getSum(int x, int y)
        {
            return x + y;
        }

        public static int getDifference(int x, int y)
        {
            return x - y;
        }

        public static int getProduct(int x, int y)
        {
            return x * y;
        }

        public static int getQuotient(int x, int y)
        {
            return x / y;
        }
    }
}
