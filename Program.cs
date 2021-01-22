using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            // DZ 1
            task1();
            task2();
            task3();
            // DZ 2
            task4();
            task5();
            task6();
        }

        static void task1()
        {
            Console.WriteLine("task 1");
            Console.WriteLine("Enter 2 numbers");
            var ok = inputTwoNumber(out int a, out int b);
            if (!ok)
            {
                Console.WriteLine("bad input");
                return;
            }
            
            if (a != b)
            {
                if (a > b)
                {
                    b = a;
                }
                else
                {
                    a = b;
                }
            }
            else
            {
                a = 0;
                b = 0;
            }

            Console.WriteLine($"a={a} b={b}");
        }

        static bool inputTwoNumber(out int a, out int b)
        {
            var input = Console.ReadLine();
            var ok = Int32.TryParse(input, out a);
            if (!ok) {
                a = 0;
                b = 0;
                return false;
            }

            input = Console.ReadLine();
            if (!ok) {
                a = 0;
                b = 0;
                return false;
            }
            ok = Int32.TryParse(input, out b);
            return true;
        }

        static void task2()
        {
            Console.WriteLine("task 2");
            Console.WriteLine("Enter 2 numbers");
            var ok = inputTwoNumber(out int operand1, out int operand2);
            if (!ok)
            {
                return;
            }

            Console.WriteLine("Enter operation symbol");
            var sign = Console.ReadLine();

            int result = sign switch {
                "+" => operand1 + operand2,
                "-" => operand1 - operand2,
                "*" => operand1 - operand2,
                "/" => operand2 != 0 ? operand1 / operand2 : throw new DivideByZeroException("Попытка деления на ноль"),
                _ => throw new ArgumentException("Недопустимый код операции"),
            };
            
            Console.WriteLine(result);
        }

        static void task3()
        {
            Console.WriteLine("task 3");
            Console.WriteLine("Enter 1 number");

            var input = Console.ReadLine();
            var ok = Int32.TryParse(input, out int number);
            if (!ok)
            {
                Console.WriteLine("Not a number");
                return;
            }

            string answer = number switch {
                >= 0 and <= 14 => "[0 - 14]",
                >= 15 and <= 35 => "[15 - 35]",
                >= 36 and <= 50 => "[36 - 50]",
                >= 50 and <= 100 => "[50 - 100]",
                _ => "никакой",
            };

            Console.WriteLine($"число попадает в промежуток {answer}");
        }

        static void task4()
        {
            Console.WriteLine("task 4");
            Console.WriteLine("Enter 1 number");

            Int64.TryParse(Console.ReadLine(), out long amount);
            if (amount < 0)
            {
                Console.WriteLine("invalid amount");
                return;
            }
            
            double price;
            var discountPercent = 0;

            if (amount >= 1000)
            {
                discountPercent = 5;
            }
            else if (amount >= 500)
            {
                discountPercent = 3;
            }

            price = amount - (amount * discountPercent / 100);
            Console.WriteLine($"price is {price}");
        }

        static void task5()
        {
            Console.WriteLine("task 5");
            Console.WriteLine("Enter 4 numbers");

            inputTwoNumber(out int a, out int b);
            inputTwoNumber(out int c, out int d);
            if (d < c || c < b || b < a)
            {
                var min = a;
                if (min > b)
                {
                    min = b;
                }
                if (min > c)
                {
                    min = c;
                }
                if (min > d)
                {
                    min = d;
                }
                Console.WriteLine($"min number is {min}");
            }
            else if (a == b || b == c || c == d)
            {
                var result = a * b * c * d;
                Console.WriteLine($"Multiply result is {result}");
            }
            else
            {
                Console.WriteLine("«Числа расположены по возрастанию».");
            }
        }

        static void task6()
        {
            Console.WriteLine("task 3");
            Console.WriteLine("Enter 3 numbers");

            inputTwoNumber(out int a, out int b);
            Int32.TryParse(Console.ReadLine(), out int c);
            
            int temp;
            if (c > b)
            {
                temp = b;
                b = c;
                c = temp;
            }
            if (b > a)
            {
                temp = a;
                a = b;
                b = temp;
            }
            if (c > b)
            {  
                temp = b;
                b = c;
                c = temp;
            }
            Console.WriteLine($"a b c {a} {b} {c}");
        }
    }
}
