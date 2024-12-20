using System;

namespace ConsoleApp1_csharp
{
    //Интерфейс для дроби
    public interface IFraction
    {
        //Метод для получения вещественного значения дроби
        double GetValue();

        //Метод для установки числителя и знаменателя
        void SetFraction(int numerator, int denominator);
    }

}
