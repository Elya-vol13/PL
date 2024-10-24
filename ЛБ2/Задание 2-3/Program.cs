using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2_csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ввод данных пользователем
            Console.WriteLine("Введите рубли: ");
            uint rubles;
            while (true)
            {
                if (uint.TryParse(Console.ReadLine(), out rubles))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Неверный ввод! Введите целое число!");
                }
            }

            Console.WriteLine("Введите копейки: ");
            byte kopeks;
            while (true)
            {
                if (byte.TryParse(Console.ReadLine(), out kopeks))
                {
                    if (kopeks < 100)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Введите число до 100!");
                    }
                }
                else
                {
                    Console.WriteLine("Неверный ввод! Введите целое число!");
                }
            }
            //создание объекта Money
            Money money = new Money(rubles, kopeks);
            Console.WriteLine("Исходная сумма: " + money);

            //задание 2
            Console.WriteLine("\nЗадание 2:");
            //ввод дополнительных копеек
            Console.WriteLine("Введите количество добавляемых копеек: ");
            uint addKopeks;
            while (true)
            {
                if (uint.TryParse(Console.ReadLine(), out addKopeks))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Неверный ввод! Введите целое число!");
                }
            }
            
            //добавление копеек и вывод результата
            Money updatedMoney = money.AddKopeks(addKopeks);
            Console.WriteLine("Обновленная сумма: " + updatedMoney);

            //задание 3
            Console.WriteLine("\nЗадание 3:");

            //тестирование унарных операций
            Console.WriteLine("\nТестирование унарных операций:");
            Console.WriteLine("После добавления копейки: " + ++money);
            Console.WriteLine("После вычитания копейки: " + --money);

            //тестирование операций приведения типов
            Console.WriteLine("\nТестирование операций приведения типов:");
            uint rubleAmount = (uint)money; // Явное приведение
            double kopeckAmount = money;     // Неявное приведение
            Console.WriteLine($"Количество рублей: {rubleAmount}");
            Console.WriteLine($"Количество копеек в рублях: {kopeckAmount}");

            //тестирование бинарных операций
            Console.WriteLine("\nТестирование бинарных операций:");
            Console.WriteLine("Сколько копеек вы хотите добавить:");
            uint x;
            while (true)
            {
                if (uint.TryParse(Console.ReadLine(), out x))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Неверный ввод! Введите целое число!");
                }
            }
            Console.WriteLine($"Добавление {x} копеек: " + (money + x));

            Console.WriteLine("Сколько копеек вы хотите вычесть:");
            while (true)
            {
                if (uint.TryParse(Console.ReadLine(), out x))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Неверный ввод! Введите целое число!");
                }
            }
            Console.WriteLine($"Вычитание {x} копеек: " + (money - x));

            Console.WriteLine("Ко скольки копейкам вы хотите добавить:");
            while (true)
            {
                if (uint.TryParse(Console.ReadLine(), out x))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Неверный ввод! Введите целое число!");
                }
            }
            Console.WriteLine($"Добавление к {x}: " + (x + money));

            Console.WriteLine("Из скольки копеек вы хотите вычесть:");
            while (true)
            {
                if (uint.TryParse(Console.ReadLine(), out x))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Неверный ввод! Введите целое число!");
                }
            }
            Console.WriteLine($"Вычитание из {x} копеек: " + (x - money));
            Console.ReadKey();
        }
    }
}
