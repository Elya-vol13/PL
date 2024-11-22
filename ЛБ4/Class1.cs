using ConsoleApp2_csharp;
using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp2_csharp
{
    public class LB4
    {
        //Задание 1
        public static void N1<T>(List<T> L, List<T> L1, List<T> L2)
        {
            int t = 0, i1, ind = 0;
            //поиск первого вхождения L1 в L
            for (int i = 0; i < L.Count - L1.Count + 1; i++)
            {
                t = 0;
                i1 = i;
                for (int j = 0; j < L1.Count; j++)
                {
                    if (L[i1++]?.Equals(L1[j]) == true)
                    {
                        t++;
                    }
                }
                if (t == L1.Count)
                {
                    ind = i;
                    i = L.Count;
                }
            }
            //замена первого вхождения L1 в L на L2
            if (t == L1.Count)
            {
                for (int i = 0; i < t; i++)
                {
                    L.RemoveAt(ind);
                }
                L.InsertRange(ind, L2);
            }
        }

        //Задание 2
        public static void N2<T>(LinkedList<T> L) where T : IComparable<T>
        {
            if (L.Count <= 1) return; //если в списке 0 или 1 элемент, ничего не делаем

            bool s;
            do
            {
                s = false;
                var a = L.First;

                while (a != null && a.Next != null)
                {
                    if (a.Value.CompareTo(a.Next.Value) > 0)
                    {
                        //меняем элементы местами
                        T b = a.Value;
                        a.Value = a.Next.Value;
                        a.Next.Value = b;

                        s = true; //устанавливаем флаг, что была перестановка
                    }
                    a = a.Next;
                }
            } while (s); //продолжаем, пока есть перестановки
        }

        //Задание 3 
        //определение игр, в которые играют все студенты
        public static HashSet<string> N3_1(HashSet<string> games, Dictionary<string, HashSet<string>> studentGames)
        {
            var allGames = new HashSet<string>(games);
            foreach (var studentGameSet in studentGames.Values)
            {
                allGames.IntersectWith(studentGameSet); //  оставляем только те игры, которые есть у каждого студента
            }
            return allGames;
        }

        //Определение игр, в которые играют некоторые студенты
        public static HashSet<string> N3_2(Dictionary<string, HashSet<string>> studentGames)
        {
            var someGames = new HashSet<string>();
            foreach (var g in studentGames.Values)
            {
                someGames.UnionWith(g); //добавляем все игры из перечня игр студентов
            }
            return someGames;
        }

        //Определение игр, в которые не играет ни один из студентов
        public static HashSet<string> N3_3(HashSet<string> games, HashSet<string> someGames)
        {
            var notGames = new HashSet<string>(games);
            notGames.ExceptWith(someGames); //удаляем игры, в которые играют некоторые студенты
            return notGames;
        }

        //Задание 4
        public static void N4()
        {
            string filename = "file.txt";
            //Проверка существования файла
            if (!File.Exists(filename))
            {
                Console.WriteLine("Файл не существует.");
                return;
            }

            //Чтение текста из файла
            string text = File.ReadAllText(filename);

            //Проверка на пустой текст
            if (string.IsNullOrWhiteSpace(text))
            {
                Console.WriteLine("Файл пуст.");
                return;
            }

            HashSet<char> deafConsonants = new HashSet<char> { 'к', 'п', 'т', 'ф', 'с', 'ш', 'х', 'ц' };
            //Пробегаемся по тексту посимвольно
            foreach (char c in text)
            {
                //Если символ содержится в наборе глухих согласных, то удаляем его оттуда
                if (deafConsonants.Contains(char.ToLower(c)))
                {
                    deafConsonants.Remove(char.ToLower(c));
                }
            }

            //Вывод результата
            Console.Write("Глухие согласные буквы, которые не входят хотя бы в одно слово: ");
            foreach (var consonant in deafConsonants)
            {
                Console.Write(consonant);
                Console.Write(' ');
            }
        }
    }
}
