using System;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;

class Program
{
    private static List<Note> notes = new List<Note>();
    private static int poz = 0;
    static void Main(string[] args)
    {
        Allnotes();
        ConsoleKeyInfo key;

        do
        {
            Console.Clear();
            Menu();

            key = Console.ReadKey();
            DateTime currentDate = DateTime.Now;
            switch (key.Key)
            {
                case ConsoleKey.UpArrow:
                    if (poz > 0)
                        poz--;
                    break;
                case ConsoleKey.DownArrow:
                    if (poz < notes.Count - 1)
                        poz++;
                    break;
                case ConsoleKey.Enter:
                    SND(notes[poz]);
                    break;
                case ConsoleKey.LeftArrow:
                    currentDate = currentDate.AddDays(-1); // не работает переключение дат, почему не знаю
                    break;
                case ConsoleKey.RightArrow:
                    currentDate = currentDate.AddDays(1);
                    break;
            }
        } while (key.Key != ConsoleKey.Escape);
    }

    private static void Menu()
    {
        Console.WriteLine($"Дата: {DateTime.Now}"); 
        Console.WriteLine();

        for (int i = 0; i < notes.Count; i++)
        {
            Console.Write(i == poz ? "-> " : "  ");
            Console.WriteLine(notes[i].Naznanie);
        }
    }
    private static void Allnotes()
    {
        notes.Add(new Note
        {
            Naznanie = "Придти на пары",
            Opisanie = "Отсидеть пять пар",
            Date = new DateTime(2023, 12, 12), // не понимаю как сделать унивесальную дату

        });

        notes.Add(new Note
        {
            Naznanie = "Сходить в магазин",
            Opisanie = "Купить хлеба",
            Date = new DateTime(2023, 12, 12),

        });

        notes.Add(new Note
        {
            Naznanie = "Пойти погулять",
            Opisanie = "Прогуляться по парку",
            Date = new DateTime(2023, 12, 12),

        });

        notes.Add(new Note
        {
            Naznanie = "Сделать уроки",
            Opisanie = "Выполнить практические работы",
            Date = new DateTime(2023, 12, 12),
        });

        notes.Add(new Note
        {
            Naznanie = "Придти домой",
            Opisanie = "отдохнуть",
            Date = new DateTime(2023, 12, 12), 
        });
    }
    private static void SND(Note note)
    {
        Console.Clear();
        Console.WriteLine($"Название: {note.Naznanie}");
        Console.WriteLine("-----------------------------------");
        Console.WriteLine($"Описание: {note.Opisanie}");
        Console.WriteLine($"Дата: {DateTime.Now}");
        Console.WriteLine("\nНажмите любую клавишу для возврата.");
        Console.ReadKey();
    }
}
class Note
{
    public string Naznanie { get; set; }
    public string Opisanie { get; set; }
    public DateTime Date { get; set; }
    public bool IsCompleted { get; set; }
}
