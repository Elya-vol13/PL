using System;

namespace ConsoleApp1_csharp
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        public Customer(int id, string name, int age, string address)
        {
            Id = id;
            Name = name;
            Age = age;
            Address = address;
        }

        public override string ToString()
        {
            return string.Format("{0,-5} {1,-30} {2,-9} {3, -30}", Id, Name, Age, Address); //ID, Имя, Возраст, Адрес
        }
    }
}