using System;

namespace ConsoleApp1_csharp
{
    //Кот 1
    public class Cat : IMeow
    {
        private string name;

        //Конструктор
        public Cat(string name)
        {
            this.name = name;
        }

        //Перегрузка ToString
        public override string ToString()
        {
            return $"Кот: {name}";
        }

        //выводит стандартное мяуканье
        public void Meow()
        {
            Console.WriteLine($"{name}: мяу!");
        }

        //Перегруженный метод, который позволяет мяукать заданное количество раз
        public void Meow(int count)
        {
            Console.Write($"{name}: ");
            for (int i = 0; i < count; i++)
            {
                Console.Write("мяу");
                if (i < count - 1) Console.Write("-");
            }
            Console.WriteLine("!");
        }
    }
}
