using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe
{
    class Program
    {
        static void Main(string[] args)
        {
            //Работу выполнил Булгар Александр Сергеевич
            while (true)
            {
                Console.Write("Работу выполнил Булгар Александр Сергеевич\n" +
                              "Для выбора работы на проверку наберите число от 1 до 7\n" +
                              "1. Программа возвращающая минимальное из трех чисел\n" +
                              "2. Программа подсчета цифр числа\n" +
                              "3. Программа подсчета суммы всех нечетных положительных чисел введенных пользователем\n" +
                              "4. Проверка логина и пароля\n" +
                              "5. Программа подсчета ИМТ\n" +
                              "6. Программа подсчета хороших чисел\n" +
                              "7. Программа для рукурсивного метода\n" +
                              "Число: ");
                int i = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (i)
                {
                    case 1: MinNum(); break;
                    case 2: Num(); break;
                    case 3: SumNum(); break;
                    case 4:
                        if (Pass() == true)
                        {
                            Console.WriteLine("Доступ разрешен");
                        }
                        else
                        {
                            Console.WriteLine("Доступ заблокирован");
                        }
                        break;
                    case 5: IMT(); break;
                    case 6: Good(); break;
                    case 7: Rec(); break;
                    default: Console.WriteLine("Вы ввели не верное значение!"); break;
                }
                question();
            }
        }

        static void MinNum()
        {
            Console.Write("Программа возвращающая минимальное из трех чисел\nВведите значение a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите значение b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Введите значение c = ");
            int c = int.Parse(Console.ReadLine());
            int MinNum = a < b ? (a < c ? a : c) : (b < c ? b : c);
            Console.WriteLine("Наименьшее число: {0}" , a < b ? (a < c ? a : c) : (b < c ? b : c) );
            Console.WriteLine($"Наименьшее число: {(a < b ? (a < c ? a : c) : (b < c ? b : c))}");
        }

        static void Num()
        {
            Console.Write("Программа подсчета цифр числа\nВведите целое число: ");
            int a = int.Parse(Console.ReadLine());
            int Num = 0;
            if (a!=0)
            {
                while (a != 0)
                {
                    a = a / 10;
                    Num++;
                }
            }
            else
            {
                Num++;
            }
            Console.WriteLine($"Колличество цифр в числе: {Num}");       
        }

        static void SumNum()
        {
            Console.WriteLine("Программа подсчета суммы всех нечетных положительных чисел введенных пользователем");
            int a;
            int SumNum = 0;
            do
            {
                Console.Write("Введите любое натуральное число: ");
                a = int.Parse(Console.ReadLine());
                if (a % 2 == 0 & a > 0)
                {
                    SumNum = SumNum + a;
                }
            }
            while (a != 0);
            Console.WriteLine($"Cуммы всех нечетных положительных чисел: {SumNum}");
        }

        static bool Pass()
        {
            Console.WriteLine("Проверка логина(root) и пароля(GeekBrains)");
            string login = "root";
            string pass = "GeekBrains";
            int i = 0;
            string l;
            string p;
            bool f = false;
            do
            {
                Console.Write("Вход в систему\nЛогин:");
                l = Console.ReadLine();
                Console.Write("Пароль:");
                p = Console.ReadLine();
                if (l == login & p == pass)
                {
                    f = true;
                    i = 2;
                }
                else
                {
                    Console.WriteLine("Логин или пароль введен не венрно!");
                }
                i++;
            } while (i != 3);
            return f;
        }

        static void IMT()
        {
            Console.Write("Программа расчета ИМТ \nВведите массу вашего тела, кг: ");
            string weight = Console.ReadLine();
            double m = double.Parse(weight);
            Console.Write("Введите ваш рост, см: ");
            string height = Console.ReadLine();
            double h = double.Parse(height) / 100;
            double i = m / (h * h);
            if (i >= 18.5 & i < 25)
            {
                Console.WriteLine("Индекс массы тела: " + "{0:0.##}, ваша масса в норме", i);
                return;
            }
            else if (i < 18.5)
            {
                double m1 = 18.5 * h * h - m;
                Console.WriteLine("Индекс массы тела: " + "{0:0.##}, вы имеете недостаточный вес, советуем набрать {1:0.##} кг", i, m1);
                return;
            }
            else
            {
                double m1 = m - 25 * h * h;
                Console.WriteLine("Индекс массы тела: " + "{0:0.##}, вы имеете избыточный вес, советуем похудеть на {1:0.##} кг", i, m1);
                return;
            }
        }

        static void Good()
        {
            DateTime start = DateTime.Now;
            Console.WriteLine("Программа подсчета хороших чисел в диапазоне от 1 до 1 000 000 000");
            int x = 1;
            int i = 0;
            while (x <= 1000000000)
            {
                if ((x % RecSum(x)) == 0)
                    i++;
                x++;
            }
            Console.WriteLine("Хороших чисел в диапазоне от 1 до 1 000 000 000: " + i + ", время подсчета составило: " + (DateTime.Now - start));
        }

        static int RecSum(int a)
        {
            if (a == 0) return 0;
            else return RecSum(a / 10) + a % 10;
        }

        static void Rec()
        {
            Console.Write("Программа вывода на экран чесел от a до b(a<b)\nВведите число a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите число b: ");
            int b = int.Parse(Console.ReadLine());
            if (a < b)
            {
                Console.WriteLine("Вывод всех чисел от a до b:");
                RecWrite(a, b, 0);
                Console.WriteLine("Сумма всех чисел от a до b:" + RecSumNum(a, b));
            }
            else
            {
                Console.WriteLine("Вы ввели неверное значение, a > b!");
                return;
            }
        }

        static void RecWrite(int a, int b, int i)
        {
            if (a <= b)
            {
                Console.Write(a + "\t");
                a++;
                i++;
                if (i == 10)
                {
                    i = 0;
                    Console.WriteLine();
                }
                RecWrite(a, b, i);
            }
        }

        static int RecSumNum(int a, int b)
        {
            if (a <= b)
            {
                return (a + RecSumNum(a + 1, b));
            }
            return 0;
        }

        static void question()
        {
            Console.WriteLine("Вернуться в меню Y/N: ");
            string yn = Console.ReadLine();
            Console.Clear();
            if (yn == "Y" | yn == "y") return;
            else Environment.Exit(0);
        }
    }
}
