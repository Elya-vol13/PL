using System;
using System.Collections.Generic;

namespace ConsoleApp1_csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Выберите задание:\n1. Задание 1\n2. Задание 2\n0. Выход\n>>>");
                switch (Console.ReadLine())
                {
                    case "1":
                        //Задание 1
                        Console.WriteLine("\nЗадание 1:");
                        //1
                        Console.WriteLine("1:");
                        string c;
                        //Ввод имени кота
                        while (true)
                        {
                            Console.Write("Введите имя кота: ");
                            c = Console.ReadLine();
                            if (string.IsNullOrWhiteSpace(c))
                            {
                                Console.WriteLine("Имя кота не может быть пустым или состоять только из пробелов.");
                            }
                            else
                            {
                                break;
                            }
                        }

                        Cat c1 = new Cat(c);
                        Console.WriteLine($"{c1.ToString()}");
                        c1.Meow(); //Мяукает один раз
                        c1.Meow(3); //Мяукает три раза

                        //2
                        Console.WriteLine("\n2:");
                        Cat c2 = new Cat("Мурзик");
                        ToyCat toyCat = new ToyCat("Плюшевый кот");

                        //Собираем все мяукающие объекты в список
                        List<IMeow> ms = new List<IMeow> { c1, c2, toyCat };

                        AllMeow(ms);

                        //3
                        Console.WriteLine("\n3:");
                        // Создаем список с одним котом
                        CountingCat C1 = new CountingCat(c1);
                        List<CountingCat> ms1 = new List<CountingCat> { C1 };
                        for (int i = 0; i < 5; i++)
                        {
                            AllMeow(ms1);
                        }
                        AllMeow(ms1);
                        Console.WriteLine($"Количество мяуканий: {C1.MeowCount()}");
                        break;
                    
                    case "2":
                        //Задание 2
                        Console.WriteLine("\nЗадание 2:");
                        //1
                        Console.WriteLine("1:");
                        // Создание экземпляров дробей
                        int ch, z;
                        Console.WriteLine("Введите первую дробь:");
                        ch = Input_num();
                        z = Input_den();
                        Fraction f1 = new Fraction(ch, z);
                        Console.WriteLine("\nВведите вторую дробь:");
                        ch = Input_num();
                        z = Input_den();
                        Fraction f2 = new Fraction(ch, z);
                        Console.WriteLine("\nВведите третью дробь:");
                        ch = Input_num();
                        z = Input_den();
                        Fraction f3 = new Fraction(ch, z);

                        //Дроби
                        Console.WriteLine("\nВаши дроби:");
                        Console.WriteLine($"f1: {f1}");
                        Console.WriteLine($"f2: {f2}");
                        Console.WriteLine($"f3: {f3}");

                        // Примеры использования методов
                        Console.WriteLine($"{f1} + {f2} = {f1 + f2}");
                        Console.WriteLine($"{f1} - {f2} = {f1 - f2}");
                        Console.WriteLine($"{f1} * {f2} = {f1 * f2}");
                        Console.WriteLine($"{f1} / {f2} = {f1 / f2}");
                        Console.WriteLine($"{f1} + {13} = {f1 + 13}");
                        Console.WriteLine($"{f2} - {5} = {f2 - 5}");
                        Console.WriteLine($"{f3} * {4} = {f3 * 4}");
                        Console.WriteLine($"{f1} / {2} = {f1 / 2}");

                        // Пример вычисления f1.sum(f2).div(f3).minus(5)
                        Console.WriteLine($"Результат (f1 + f2) / f3 - 5: {(f1 + f2) / f3 - 5}");

                        //2
                        Console.WriteLine("\n2:");
                        Console.WriteLine($"{f1} == {f2}: {f1 == f2}");
                        Console.WriteLine($"{f1} == {f3}: {f1 == f3}"); 
                        Console.WriteLine($"{f2} != {f3}: {f2 != f3}");

                        //3
                        Console.WriteLine("\n3:");
                        Fraction f4 = (Fraction)f3.Clone();
                        Console.WriteLine($"f3 = {f3}");
                        Console.WriteLine($"f4(копия f3) = {f4}");
                        Console.WriteLine($"{f4} == {f3}: {f4 == f3}");

                        //4
                        Console.WriteLine("\n3:");
                        //Получаем вещественное значение дроби
                        Console.WriteLine("Значение дроби f1: " + f1.GetValue());
                        //Устанавливаем новые значения для числителя и знаменателя
                        f1.SetFraction(5, 2);
                        Console.WriteLine($"f1 после установки новых числителя и знаменателя = {f1}");

                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Нет такой опции!");
                        break;
                }
                Console.WriteLine();
            }
        }

        //Для задания 1
        public static void AllMeow(IEnumerable<IMeow> ms)
        {
            foreach (var m in ms)
            {
                m.Meow();
            }
        }

        //Для задания 2
        //Ввод числителя
        static int Input_num()
        {
            Console.Write("Введите числитель: ");
            int a;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out a))
                {
                    return a;
                }
                else
                {
                    Console.WriteLine("Неверный ввод! Введите целое число!");
                }
            }
        }
        //Ввод знаменателя
        static int Input_den()
        {
            Console.Write("Введите знаменатель: ");
            int a;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out a))
                {
                    if (a > 0)
                    {
                        return a;
                    }
                    else
                    {
                        Console.WriteLine("Знаменатель должен быть больше 0!");
                    }
                }
                else
                {
                    Console.WriteLine("Неверный ввод! Введите целое число!");
                }
            }
        }
    }
}
