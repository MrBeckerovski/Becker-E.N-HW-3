using System;

namespace Becker_E.N_HW_3
{
  

        struct Complex
        {

            public int a, b;

            public Complex(int re, int im)
            {
                a = re;
                b = im;
            }

            static public Complex Sum(Complex x, Complex y)
            {
                return new Complex(re: x.a + y.a, im: x.b + y.b);
            }

            static public Complex operator +(Complex x, Complex y)
            {
                return new Complex(re: x.a + y.a, im: x.b + y.b);
            }

            static public Complex operator -(Complex x, Complex y)
            {
                return new Complex(re: x.a - y.a, im: x.b - y.b);
            }

            public override string ToString()
            {

                return b < 0 ? $"{a}-{-b}i" : $"{a}+{b}i";
            }
        }


        class Program
        {
            static void parseNum(out int getNum, out string value, string msg)
            {
                bool success;
                do
                {
                    Console.Write(msg);
                    value = Console.ReadLine();
                    success = int.TryParse(value, out getNum);

                } while (!success);

            }

            static void Main(string[] args)
            {
                int re, im;
                string value;

                parseNum(out re, out value, "Введите вещественую часть первого комплексного числа: ");
                parseNum(out im, out value, "Введите мнимую часть второго комплексного числа: ");

                Complex com_1 = new Complex(re, im);

                parseNum(out re, out value, "Введите вещественую часть второго комплексного числа: ");
                parseNum(out im, out value, "Введите мнимую часть второго комплексного числа: ");

                Complex com_2 = new Complex(re, im);

                Complex comSum = com_1 + com_2;
                Complex comDiff = com_1 - com_2;


                Console.WriteLine($"Комплексное число #1 = {com_1}");
                Console.WriteLine($"Комплексное число #2 = {com_2}");

                Console.WriteLine($"Сумма комплексных чисел = {comSum}");
                Console.WriteLine($"Разность комплексных чисел = {comDiff}");








            }
        }
    }
