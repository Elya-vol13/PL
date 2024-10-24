using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2_csharp
{
    internal class Money
    {
        //поля
        private uint rubles;
        private byte kopeks;

        //конструктор
        public Money(uint rubles, byte kopeks)
        {
            this.rubles = rubles;
            this.kopeks = kopeks;
        }

        //метод для добавления копеек
        public Money AddKopeks(uint addKopeks)
        {
            uint totalKopeks = this.kopeks + addKopeks;
            uint newRubles = this.rubles + totalKopeks / 100;
            byte newKopeks = (byte)(totalKopeks % 100);
            return new Money(newRubles, newKopeks);
        }
        

        //перегрузка метода ToString()
        public override string ToString()
        {
            return $"{rubles} руб. {kopeks} коп.";
        }

        //задание 3
        //унарные операции
        public static Money operator ++(Money m)
        {
            return m.AddKopeks(1);
        }

        public static Money operator --(Money m)
        {
            if (m.kopeks == 0)
            {
                if (m.rubles == 0)
                    return new Money(0, 0);
                return new Money(m.rubles - 1, 99);
            }
            return new Money(m.rubles, (byte)(m.kopeks - 1));
        }

        //операции приведения типа
        public static explicit operator uint(Money m)
        {
            return m.rubles;
        }

        public static implicit operator double(Money m)
        {
            return m.kopeks / 100.0;
        }

        //бинарные операции с беззнаковыми целыми числами
        public static Money operator +(Money m, uint addKopeks)
        {
            return m.AddKopeks(addKopeks);
        }

        public static Money operator +(uint addKopeks, Money m)
        {
            return m.AddKopeks(addKopeks);
        }

        public static Money operator -(Money m, uint subKopeks)
        {
            if (subKopeks > m.rubles * 100 + m.kopeks)
            {
                return new Money(0, (byte)0);
            }
            uint totalKopeks = (m.rubles * 100 + m.kopeks) - subKopeks;
            return new Money(totalKopeks / 100, (byte)(totalKopeks % 100));
        }

        public static Money operator -(uint subKopeks, Money m)
        {
            
            if (subKopeks < m.rubles * 100 + m.kopeks)
            {
                return new Money(0, (byte)0);
            }
            uint totalKopeks = subKopeks - (m.rubles * 100 + m.kopeks);
            return new Money(totalKopeks / 100, (byte)(totalKopeks % 100));
        }
    }
}
