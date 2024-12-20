using System;

namespace ConsoleApp1_csharp
{
    //Кот 2
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
}
