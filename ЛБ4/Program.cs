using ConsoleApp2_csharp;
using System;
using System.Collections.Generic;
using System.IO;

public class Program
{
    public static void Main(string[] args)
    {
        //Задание 1
        //Пример с текстовым типом
        Console.WriteLine("Задание 1: ");
        Console.WriteLine("Пример с текстовым типом: ");
        List<string> L = new List<string> { "a", "b", "c", "d", "b", "c" };
        List<string> L1 = new List<string> { "b", "c" };
        List<string> L2 = new List<string> { "e", "f" };
        Console.WriteLine($"Список L: \n{string.Join(", ", L)}");
        Console.WriteLine($"Список L1: \n{string.Join(", ", L1)}");
        Console.WriteLine($"Список L2: \n{string.Join(", ", L2)}");
        LB4.N1(L, L1, L2);
        Console.WriteLine($"Список после преобразований: \n{string.Join(", ", L)}");

        //Пример с числовым типом
        Console.WriteLine("\nПример с числовым типом: ");
        List<int> L4 = new List<int> { 1, 2, 3, 4 };
        List<int> L5 = new List<int> { 2, 3 };
        List<int> L6 = new List<int> { 5, 7 };
        Console.WriteLine($"Список L: \n{string.Join(", ", L4)}");
        Console.WriteLine($"Список L1: \n{string.Join(", ", L5)}");
        Console.WriteLine($"Список L2: \n{string.Join(", ", L6)}");
        LB4.N1(L4, L5, L6);
        Console.WriteLine($"Список после преобразований: \n{string.Join(", ", L4)}");

        //Задание 2
        //Пример с числовым типом
        Console.WriteLine("\nЗадание 2: ");
        Console.WriteLine("Пример с числовым типом: ");
        LinkedList<int> linkedList = new LinkedList<int>(new[] { 5, 3, 8, 1, 4 });
        Console.WriteLine($"Список до сортировки: \n{string.Join(", ", linkedList)}");
        LB4.N2(linkedList);
        Console.WriteLine($"Список после сортировки: \n{string.Join(", ", linkedList)}");

        //Пример с текстовым типом
        Console.WriteLine("\nПример с текстовым типом: ");
        LinkedList<string> linkedList1 = new LinkedList<string>(new[] { "c", "b", "a", "e", "d" });
        Console.WriteLine($"Список до сортировки: \n{string.Join(", ", linkedList1)}");
        LB4.N2(linkedList1);
        Console.WriteLine($"Список после сортировки: \n{string.Join(", ", linkedList1)}");

        //Задание 3
        Console.WriteLine("\nЗадание 3: ");
        var games = new HashSet<string> { "Игра1", "Игра2", "Игра3", "Игра4", "Игра5", "Игра6" };
        var studentGames = new Dictionary<string, HashSet<string>>
        {
            { "Студент1", new HashSet<string> {"Игра1", "Игра2", "Игра6"}},
            { "Студент2", new HashSet<string> {"Игра6", "Игра2", "Игра3"}},
            { "Студент3", new HashSet<string> {"Игра1", "Игра6", "Игра2"}}
        };

        // Вывод игр
        Console.WriteLine("Перечень всех игр:");
        foreach (var game in games)
        {
            Console.Write(game + " ");
        }

        // Вывод игр студентов
        Console.WriteLine("\n\nИгры студентов:");
        foreach (var student in studentGames)
        {
            Console.WriteLine($"{student.Key}: {string.Join(", ", student.Value)}");
        }

        var allGames = LB4.N3_1(games, studentGames);
        var someGames = LB4.N3_2(studentGames);
        var noGames = LB4.N3_3(games, someGames);

        Console.WriteLine("\nИгры, в которые играют все студенты: " + string.Join(", ", allGames));
        Console.WriteLine("Игры, в которые играют некоторые студенты: " + string.Join(", ", someGames));
        Console.WriteLine("Игры, в которые не играет ни один студент: " + string.Join(", ", noGames));

        //Задание 4
        Console.WriteLine("\nЗадание 4: ");
        LB4.N4();
        Console.ReadKey();
    }
}
