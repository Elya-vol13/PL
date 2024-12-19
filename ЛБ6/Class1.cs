using System;

namespace ConsoleApp1_csharp
{
    //Задание 1
    //Интерфейс для классов, которые могут мяукать
    public interface IMeow
    {
        void Meow();
    }
    
    //Задание 1
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


    //Задание 2
    public class ToyCat : IMeow
    {
        private string toy_name;

        public ToyCat(string toy_name)
        {
            this.toy_name = toy_name;
        }

        public void Meow()
        {
            Console.WriteLine($"{toy_name}: мяу!");
        }

        //Перегрузка ToString
        public override string ToString()
        {
            return $"Плюшевый кот: {toy_name}";
        }
    }

    //Задание 3
    public class CountingCat : IMeow
    {
        private Cat _cat;
        private int meow_Count;

        public CountingCat(Cat cat)
        {
            _cat = cat;
            meow_Count = 0;
        }

        public void Meow()
        {
            _cat.Meow();
            meow_Count++;
        }

        public int MeowCount()
        {
            return meow_Count;
        }
    }
}