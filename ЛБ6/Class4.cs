using System;
using System.Collections.Generic;

namespace ConsoleApp1_csharp
{
    //Кот 3
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
