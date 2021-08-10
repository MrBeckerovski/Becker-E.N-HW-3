  using System;

namespace EX_2._0_Becker_E.N
{ class Program
    {
        static void Main(string[] args)
        {

            int x;
            uint oddNumbers = 0;
            string A;
            bool flag;
            do
            {
                Console.WriteLine("Введите целое положительное число A");
                A = Console.ReadLine();
                flag = int.TryParse(A, out x);
            
                if (flag == true)
                Console.WriteLine("Преобразование прошло успешно");
            else
                Console.WriteLine("Преобразование завершилось неудачно");
        
                int n = x % 2;

                if (n == 0)
                {
                    Console.WriteLine("Число является четным");
                }
                else
                {
                    oddNumbers++;
                    Console.WriteLine("Число является нечетным");
                }


            }

            while (x > 0);
            Console.WriteLine("Количество введенных нечетных положительных чисел= " + oddNumbers);
        }

            
        }
        }

