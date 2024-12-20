using System;

namespace ConsoleApp1_csharp
{
    public class FractionCache
    {
        private readonly Fraction fraction; // Ссылка на дробь
        private double? cachedValue; // Кэшированное значение

        public FractionCache(Fraction fraction)
        {
            this.fraction = fraction;
        }

        //Получение кэшированного значения
        public double GetCachedValue()
        {
            if (!cachedValue.HasValue) // Если значение не закэшировано
            {
                cachedValue = (double)fraction.Num / fraction.Den; // Вычисляем и кэшируем значение
            }
            return cachedValue.Value; // Возвращаем кэшированное значение
        }

        //Инвалидация кэша при изменении дроби
        public void Invalidate()
        {
            cachedValue = null; // Сбрасываем кэш
        }
    }
}
