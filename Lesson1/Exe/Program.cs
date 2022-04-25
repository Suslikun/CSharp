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
            m1:
            Console.Write("Работу выполнил Булгар Александр Сергеевич\n" +
                          "Для выбора работы на проверку наберите число от 1 до 5\n" +
                          "1. Программа \"Анкета\"\n" +
                          "2. Расчет индекса массы телы (ИМТ)\n" +
                          "3. Расчет расстояния меджу двумя точками\n" +
                          "4. Программа обмена значений двух переменных\n" +
                          "5. Вывод личных данных пользователя\n" +
                          "Число: ");
            int i = int.Parse(Console.ReadLine());
            Console.Clear();
            if (i==1) form();
            else if (i == 2) IMT();
            else if (i == 3) distance();
            else if (i == 4) exchange();
            else if (i == 5) data();
            else Console.WriteLine("Вы ввели не верное значение!");
            question();
            goto m1;
        }

        static void form()
        {
            Console.Write("Программа Анкета \nВведите ваше имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите вашу фамилию: ");
            string surname = Console.ReadLine();
            Console.Write("Введите ваш возраст: ");
            string age = Console.ReadLine();
            Console.Write("Введите ваш рост: ");
            string height = Console.ReadLine();
            Console.Write("Введите ваш вес: ");
            string weight = Console.ReadLine();
            Console.WriteLine("а) Имя: " + name + ", Фамилия: " + surname + ", Возраст: " + age + ", Рост: " + height + ", Вес: " + weight);       //Склеивание
            Console.WriteLine("б) Имя: {0}, Фамилия: {1}, Возраст: {2}, Рост: {3}, Вес: {4}", name, surname, age, height, weight);                 //Форматированный вывод
            Console.WriteLine($"в) Имя: {name}, Фамилия: {surname}, Возраст: {age}, Рост: {height}, Вес: {weight}");                               //Со знаком $
        }

        static void IMT()
        {
            Console.Write("Программа расчета ИМТ \nВведите массу вашего тела, кг: ");
            string weight = Console.ReadLine();
            float m = float.Parse(weight);
            Console.Write("Введите ваш рост, см: ");
            string height = Console.ReadLine();
            float h = float.Parse(height) / 100;
            float i = m / (h * h);
            Console.WriteLine("Индекс массы тела: " + "{0:0.##}", i);       //также тут можно было использовать "{0:F}", i
        }

        static void distance()
        {
            Les1 T = new Les1();
            Console.Write("Программа расчета расстояния между точками \nВведите координаты точек: А и В\nx1 = ");
            int x1 = int.Parse(Console.ReadLine());
            Console.Write("y1 = ");
            int y1 = int.Parse(Console.ReadLine());
            Console.Write("x2 = ");
            int x2 = int.Parse(Console.ReadLine());
            Console.Write("y2 = ");
            int y2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Расстояние между точками А и В равно: " + "{0:0.##}", T.distance(x1, y1, x2, y2));        //также тут можно было использовать "{0:F}", i
        }

        static void exchange()
        {
            Console.Write("Программа обмена значениями двух переменных \nВведите первую переменную A = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите вторую переменную B = ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Вариант решения А:");
            int c = a;
            a = b;
            b = c;
            Console.WriteLine($"A = {a}, B = {b}");
            Console.WriteLine("Вариант решения Б:");
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"A = {a}, B = {b}");
        }

        static void data()
        {
            Les1 T = new Les1();
            Console.Write("Программа вывода данных \nВведите ваше имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите вашу фамилию: ");
            string surname = Console.ReadLine();
            Console.Write("Введите ваш город: ");
            string city = Console.ReadLine();
            string msg = "Приветствую " + name + " " + surname + " из города " + city;
            Console.Clear();
            T.Print(msg);
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
