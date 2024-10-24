using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2_csharp
{
    internal class Cats : Animals
    {
        //поля
        private string breed;
        private int age;
        private string ff; //favorite food
        private string gd; //пол

        //конструктор 
        public Cats(string name, string breed, int age, string ff, string gd) : base(name)
        {
            this.breed = breed;
            this.age = age;
            this.ff = ff;
            this.gd = gd;
        }

        //конструктор копирования
        public Cats(Cats cats) : base(cats)
        {
            this.breed = cats.breed;
            this.age = cats.age;
            this.ff = cats.ff;
            this.gd = cats.gd;
        }

        //метод для вывода информации о коте
        public string CatInfo()
        {
            return $"{Name}: Возраст: {age}; Пол: {gd}";
        }

        //метод для увеличения возраста
        public void Birthday()
        {
            age++;
        }

        //метод для изменения любимой еды
        public void ChangeFF(string new_ff)
        {
            ff = new_ff;
        }

        //перегрузка метода ToString
        public override string ToString()
        {
            return $"Кличка: {Name}: Возраст: {age}; Пол: {gd}; Порода: {breed}; Любимая еда: {ff}";
        }
    }
}
