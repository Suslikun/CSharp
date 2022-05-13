using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Com;
using Decimal = Com.Decimal;

namespace Exe
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.Write("Работу выполнил Булгар Александр Сергеевич\n" +
                              "Для выбора работы на проверку наберите число от 1 до 3\n" +
                              "1. Программа Complex\n" +
                              "2. Программа подсчета суммы всех нечетных положительных чисел введенных пользователем\n" +
                              "3. Программа Decimal\n" +
                              "4. Для выхода с систему\n" +
                              "Число: ");
                switch (Input())
                {
                    case 1: Complex(); break;
                    case 2: SumNum(); break;
                    case 3: Dec(); break;
                    case 4: return;
                    default: Console.WriteLine("Вы ввели не верное значение!"); Console.ReadLine(); break;
                }
                //Question();
            }
        }

        static void Complex()
        {
            Complex complex1 = new Complex(5, 3);
            Complex complex2 = new Complex(-1, 3);
            while (true)
            { 
                Console.Write($"Работа с комплексными числами {complex1} и {complex2}\n" +
                          $"Выберите действие с комплексными числами:\n" +
                          $"1. Сложение\n" +
                          $"2. Вычитание\n" +
                          $"3. Умножение\n" +
                          $"4. Для выхода в меню\n" +
                          $"Число: ");
                switch (Input())
                {
                    case 1: Console.WriteLine($"Результат сложения комплексных чисел ({complex1}) + ({complex2}) = {complex1 + complex2}"); break;
                    case 2: Console.WriteLine($"Результат вычитания комплексных чисел ({complex1}) - ({complex2}) = {complex1 - complex2}"); break;
                    case 3: Console.WriteLine($"Результат умножения комплексных чисел ({complex1}) * ({complex2}) = {complex1 * complex2}"); break;
                    case 4: return;
                    default: Console.WriteLine("Вы ввели не верное значение!"); break;
                }
                Console.ReadLine();
                Console.Clear();
            }
        }

        static void SumNum()
        {
            Console.WriteLine("Программа подсчета суммы всех нечетных положительных чисел введенных пользователем");
            int a;
            int SumNum = 0;
            string text = "";
            do
            {
                Console.Write("Введите любое натуральное число: ");
                if (int.TryParse(Console.ReadLine(), out a))
                {
                    //text = text + Convert.ToString(a) + ", ";             //Если снять коментарий с трех строк, то вывод в конце будет только чисел, без некорректно введенный символов!
                    if (a % 2 != 0 & a > 0)
                    {
                        SumNum = SumNum + a;
                    }
                }
                else
                {
                    a = 1;
                    Console.WriteLine("Вы ввели некорректное число.");
                }
            }
            while (a != 0);
            //Console.Clear();
            //Console.WriteLine(text);
            Console.WriteLine($"Cуммы всех нечетных положительных чисел: {SumNum}");
            Console.ReadLine();
        }

        static void Dec()
        {
            Decimal dec1 = new Decimal(5, 3);
            Decimal dec2 = new Decimal(-1, 3);
            while (true)
            {
                Console.Write($"Работа с комплексными числами {dec1} и {dec2}\n" +
                              $"Выберите действие с комплексными числами:\n" +
                              $"1. Сложение\n" +
                              $"2. Вычитание\n" +
                              $"3. Умножение\n" +
                              $"4. Деление\n" +
                              $"5. Для выхода в меню\n" +
                              $"Число: ");
                switch (Input())
                {
                    case 1: Console.WriteLine($"Результат сложения дробей ({dec1}) + ({dec2}) = {dec1 + dec2}"); break;
                    case 2: Console.WriteLine($"Результат вычитания дробей ({dec1}) - ({dec2}) = {dec1 - dec2}"); break;
                    case 3: Console.WriteLine($"Результат умножения дробей ({dec1}) * ({dec2}) = {dec1 * dec2}"); break;
                    case 4: Console.WriteLine($"Результат деления дробей ({dec1}) / ({dec2}) = {dec1 / dec2}"); break;
                    case 5: return;
                    default: Console.WriteLine("Вы ввели не верное значение!"); break;
                }
                Console.ReadLine();
                Console.Clear();
            }
        }

        static void Question()
        {
            Console.WriteLine("Вернуться в меню \"Y\", для выхода в систему наберите любой другой символ:");
            string yn = Console.ReadLine();
            Console.Clear();
            if (yn == "Y" | yn == "y") return;
            else Environment.Exit(0);
        }

        static int Input()
        {
            int input;
            int.TryParse(Console.ReadLine(), out input);
            Console.Clear();
            return input;
        }
    }
}
