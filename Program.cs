using System;

namespace BasicProgrammingConstruction
{
    class Program
    {
        static void Main(string[] args)
        {
            static double LocalPow(double a, int pow)
            {
                double result = 1;
                for (int i = 0; i < pow; i++) result *= a;
                return result;
            }

            static double SqrtN(double n, double A, double eps = 0.0001)
            {
                var x0 = A / n;
                var x1 = (1 / n) * ((n - 1) * x0 + A / LocalPow(x0, (int)n - 1));

                while (Math.Abs(x1 - x0) > eps)
                {
                    x0 = x1;
                    x1 = (1 / n) * ((n - 1) * x0 + A / LocalPow(x0, (int)n - 1));
                }

                return x1;
            }

            static string ConvToBin(int num)
            {
                return Convert.ToString(num, 2);
            }

            double myNumber = 569742;
            double mySqrtN = 5;
            double myRes = SqrtN(mySqrtN, myNumber, 0.0000001);
            double mathRes = Math.Pow(myNumber, 1/mySqrtN);
            double deltaRes = myRes - mathRes;
            Console.WriteLine($"Задание 1. NET.C#.02 Основные программные конструкции C#.");
            Console.WriteLine($"Число {myNumber}, степень корня {mySqrtN}");
            Console.WriteLine($"Результат по методу Ньютона {myRes}, результат модуля Math {mathRes} и разница между ними {deltaRes}");

            int myInt = 987;
            string myBin = ConvToBin(myInt);
            Console.WriteLine($"Задание 2. NET.C#.02 Основные программные конструкции C#.");
            Console.WriteLine($"Число {myInt}, двоичное представление {myBin}");

            Console.ReadLine();
        }
    }
}
