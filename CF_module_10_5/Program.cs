using System;

namespace CF_module_10_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Calculator calculator = new Calculator();
            string excText = "";
            int sum = 0;
            try
            {
                Console.WriteLine("Введите первое число: ");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите второй число: ");
                int number2 = Convert.ToInt32(Console.ReadLine());

                sum = calculator.SumNumbers(number, number2);
                calculator.WriteLog(sum);
            }
            catch (FormatException ex)
            {
                excText = ex.Message;
                calculator.WriteLog(excText);
            }
            
        }
    }

    public class Calculator : ICalcSum, ILogger
    {
        public int SumNumbers(int a, int b)
        {
            return a + b;
        }

        public void WriteLog(string exc)
        {
            if (exc != "")
            {
                Console.WriteLine("Введен текст вместо числа");
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.Write("Ошибка: ");
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine(exc);
                Console.ResetColor();
                Console.ReadKey();

            }
            else
            {
                Console.WriteLine("Пустое сообщение");
            }
            Console.ReadKey();

        }

        public void WriteLog(int sum)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write("Сумма сложения двух чисел: ");
            Console.ResetColor();
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }

    public interface ICalcSum
    {
        public int SumNumbers(int a, int b);
    }

    public interface ILogger
    {
        void WriteLog() { Console.WriteLine("Logging"); }
    }
}
