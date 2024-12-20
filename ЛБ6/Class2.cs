using System;

namespace ConsoleApp1_csharp
{
    // Интерфейс для дроби
    public interface IFraction
    {
        // Метод для получения вещественного значения дроби
        double GetValue();

        // Метод для установки числителя и знаменателя
        void SetFraction(int numerator, int denominator);
    }

    public class Fraction : ICloneable, IFraction
    {
        private int num; //Числитель
        private int den; //Знаменатель

        //Конструктор
        public Fraction(int num1, int den1)
        {
            num = num1;
            den = den1;
            Normalize(); //Сокращаем дробь
        }

        //Метод для сокращения дроби
        private void Normalize()
        {
            int nod = NOD(Math.Abs(num), den);
            num /= nod;
            den /= nod;
        }

        //Метод для нахождения НОД
        private int NOD(int a, int b)
        {
            while (b != 0)
            {
                int c = b;
                b = a % b;
                a = c;
            }
            return a;
        }

        //Строковое представление дроби
        public override string ToString()
        {
            return $"{num}/{den}";
        }

        //1
        //Перегрузки арифметических операции
        //Операции между дробями
        //Cложениe
        public static Fraction operator +(Fraction a, Fraction b)
        {
            int new_num = a.num * b.den + b.num * a.den;
            int new_den = a.den * b.den;
            return new Fraction(new_num, new_den);
        }

        //Вычитание
        public static Fraction operator -(Fraction a, Fraction b)
        {
            int new_num = a.num * b.den - b.num * a.den;
            int new_den = a.den * b.den;
            return new Fraction(new_num, new_den);
        }

        //Умножение
        public static Fraction operator *(Fraction a, Fraction b)
        {
            int new_num = a.num * b.num;
            int new_den = a.den * b.den;
            return new Fraction(new_num, new_den);
        }

        //Деление
        public static Fraction operator /(Fraction a, Fraction b)
        {
            if (b.num == 0)
                throw new DivideByZeroException("Деление на ноль невозможно.");

            int new_num = a.num * b.den;
            int new_den = a.den * b.num;
            return new Fraction(new_num, new_den);
        }

        //Операции с целым числом
        //Сложение
        public static Fraction operator +(Fraction a, int B)
        {
            Fraction b = new Fraction(B, 1);
            return a + b; //Используем уже перегруженный оператор +
        }

        //Вычитание
        public static Fraction operator -(Fraction a, int B)
        {
            Fraction b = new Fraction(B, 1);
            return a - b; //Используем уже перегруженный оператор -
        }

        //Умножение
        public static Fraction operator *(Fraction a, int b)
        {
            return new Fraction(a.num * b, a.den);
        }

        //Деление
        public static Fraction operator /(Fraction a, int b)
        {
            return new Fraction(a.num, a.den * b);
        }

        //2
        //Перегрузка операторов сравнения
        public static bool operator ==(Fraction a, Fraction b)
        {
            if (a.num == b.num)
            {
                if (a.den == b.den)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Fraction a, Fraction b)
        {
            if (a.num == b.num)
            {
                if (a.den == b.den)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return true;
            }
        }

        //3
        public object Clone()
        {
            //Возвращаем новый объект Fraction с теми же значениями полей
            return new Fraction(num, den);
        }

        //4
        //Метод для получения вещественного значения
        public double GetValue()
        {
            return (double)num / den;
        }

        //Метода для установки числителя и знаменателя
        public void SetFraction(int num, int den)
        {
            this.num = num;
            this.den = den;
        }
    }
}
