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
            Console.WriteLine("Главный класс:");
            Animals a = new Animals("Кот");
            Console.WriteLine(a);
            a.add_ex();
            Console.WriteLine("\nПосле добавления восклицательных знаков:");
            Console.WriteLine(a);

            Console.WriteLine("\nВведите кличку кота/кошки:");
            string Name = Console.ReadLine();

            Console.WriteLine("\nВведите породу кота/кошки:");
            string Breed = Console.ReadLine();

            Console.WriteLine("\nВведите возраст кота/кошки:");
            int Age;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out Age))
                {
                    if (Age > 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Возраст не может быть отрицательным!");
                    }
                }
                else
                {
                    Console.WriteLine("Неверный ввод! Введите целое число!");
                }
            }

            Console.WriteLine("\nВведите любимое блюдо кота/кошки:");
            string FF = Console.ReadLine();

            Console.WriteLine("\nВведите пол(самка/самец):");
            string Gd = Console.ReadLine();

            Console.WriteLine("\nДочерний класс:");
            Cats cat1 = new Cats(Name, Breed, Age, FF, Gd);
            Console.WriteLine(cat1);
            cat1.add_ex();
            Console.WriteLine("\nПосле добавления восклицательных знаков:");
            Console.WriteLine(cat1);

            Console.WriteLine("\nМетод вывода информации:");
            Console.WriteLine(cat1.CatInfo());

            Console.WriteLine("\nМетод увеличения возраста:");
            cat1.Birthday();
            Console.WriteLine(cat1.CatInfo());

            Console.WriteLine("\nМетод смены любимого блюда:");
            Console.WriteLine("\nВведите новое любимое блюдо кота/кошки:");
            FF = Console.ReadLine();
            cat1.ChangeFF(FF); 
            Console.WriteLine(cat1);

            Console.WriteLine("\nДемонстрация работы конструктора копирования:");
            Cats cat2 = new Cats(cat1);
            Console.WriteLine(cat2);

            Console.ReadKey(); 
        }
    }
}
