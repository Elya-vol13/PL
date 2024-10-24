using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2_csharp
{
    internal class Animals
    {
        //поля
        private string name;

        ////конструктор 
        public Animals(string name)
        {
            this.name = name;
        }

        //конструктор копирования
        public Animals(Animals animals)
        {
            this.name = animals.name;
        }

        //метод добавления восклицательных знаков в начало строки
        public void add_ex()
        {
            name = "!!!" + name;
        }

        //перегрузка метода ToString
        public override string ToString()
        {
            return $"Животное: {name}";
        }

        //свойство для доступа к приватному полю главного класса
        public string Name => name;
    }
}
