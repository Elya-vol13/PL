using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Program
{

    //Задание 1
    public static void N1(List<string> L, List<string> L1, List<string> L2)
    {
        int t = 0, i1, ind = 0;
        //поиск первого вхождения L1 в L
        for (int i = 0; i < L.Count - L1.Count + 1; i++)
        {
            t = 0;
            i1 = i;
            for (int j = 0; j < L1.Count; j++)
            {
                if (L[i1++] == L1[j])
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
    public static void N2(LinkedList<int> L)
    {
        if (L.Count <= 1) return; //если в списке 0 или 1 элемент, ничего не делаем

        bool s;
        do
        {
            s = false;
            var a = L.First;

            while (a != null && a.Next != null)
            {
                if (a.Value > a.Next.Value)
                {
                    //меняем элементы местами
                    int b = a.Value;
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
        foreach (var g in studentGames.Values)
        {
            //создаем копию allGames
            var t = new HashSet<string>(allGames);
            //очищаем хешсет
            allGames.Clear();
            foreach (var game in t)
            {
                //если в перечне игр студента, есть какая либо игра из t, добаляем эту игру в allGames
                if (g.Contains(game))
                {
                    allGames.Add(game);
                }
            }
        }
        return allGames;   
    }

    //Определение игр, в которые играют некоторые студенты
    public static HashSet<string> N3_2(Dictionary<string, HashSet<string>> studentGames)
    {
        var someGames = new HashSet<string>();
        foreach (var g in studentGames.Values)
        {
            //добавляем в someGames все игры из перечня игр студентов
            foreach (var game in g)
            {
                someGames.Add(game);
            }
        }
        return someGames;
    }

    //Определение игр, в которые не играет ни один из студентов
    public static HashSet<string> N3_3(HashSet<string> games, HashSet<string> someGames)
    {
        var notGames = new HashSet<string>(games);
        //удаляем из перечечня всех игр игры из перечня игр, в которые играют некоторые студенты
        foreach (var game in someGames)
        {
            notGames.Remove(game);
        }
        return notGames;
    }

    //Задание 4
    private static void N4()
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

        HashSet<char> deafConsonants = new HashSet<char>{'к', 'п', 'т', 'ф', 'с', 'ш', 'х', 'ц'};
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

    public static void Main(string[] args)
    {
        //Задание 1
        Console.WriteLine("Задание 1: ");
        List<string> L = new List<string> {"a", "b", "c", "d", "b", "c"};
        List<string> L1 = new List<string> {"b", "c"};
        List<string> L2 = new List<string> {"e", "f" };
        Console.WriteLine($"Список L: \n{string.Join(", ", L)}");
        Console.WriteLine($"Список L1: \n{string.Join(", ", L1)}");
        Console.WriteLine($"Список L2: \n{string.Join(", ", L2)}");
        N1(L, L1, L2);
        Console.WriteLine($"Список после преобразований: \n{string.Join(", ", L)}");
        
        //Задание 2
        Console.WriteLine("\nЗадание 2: ");
        LinkedList<int> linkedList = new LinkedList<int>(new[] {5, 3, 8, 1, 4});
        Console.WriteLine($"Список до сортировки: \n{string.Join(", ", linkedList)}");
        N2(linkedList);
        Console.WriteLine($"Список после сортировки: \n{string.Join(", ", linkedList)}");

        //Задание 3
        Console.WriteLine("\nЗадание 3: ");
        var games = new HashSet<string> {"Игра1", "Игра2", "Игра3", "Игра4", "Игра5", "Игра6"};
        var studentGames = new Dictionary<string, HashSet<string>>
        {
            { "Студент1", new HashSet<string> {"Игра1", "Игра2", "Игра6"}},
            { "Студент2", new HashSet<string> {"Игра6", "Игра2", "Игра3"}},
            { "Студент3", new HashSet<string> {"Игра1", "Игра6", "Игра2"}}
        };

        var allGames = N3_1(games, studentGames);
        var someGames = N3_2(studentGames);
        var noGames = N3_3(games, someGames);

        Console.WriteLine("Игры, в которые играют все студенты: " + string.Join(", ", allGames)); 
        Console.WriteLine("Игры, в которые играют некоторые студенты: " + string.Join(", ", someGames)); 
        Console.WriteLine("Игры, в которые не играет ни один студент: " + string.Join(", ", noGames));

        //Задание 4
        Console.WriteLine("\nЗадание 4: ");
        N4();
        Console.ReadKey(); 
    }
}
