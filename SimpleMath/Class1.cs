using System;

namespace SimpleMath
{
    public static class MathFunctions
    {
        public static int Fibonacci(int factor)
        {
            if (factor < 2)
                return factor;
            int x = Fibonacci(--factor);
            int y = Fibonacci(--factor);
            return x + y;
        }

        /******************************************************************************************/
    }
}
