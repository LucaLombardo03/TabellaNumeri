using System;

namespace MetodoNumeri
{
    public class MethodNumeri
    {
        public static int Max(int num1, int num2)
        {
            if (num1 >= num2)
            {
                return num1;
            }
            else
                return num2;
        }

        public static int Min(int num1, int num2)
        {
            if (num1 >= num2)
            {
                return num2;
            }
            else
                return num1;
        }

        public static double Media(double num1, double num2)
        {
            return (num1 + num2) / 2;
        }
    }
}
