List<string> notes = new List<string>
{
    "Заметка 1",
    "Заметка 2",
    "Заметка 3",
    "Заметка 4",
    "Заметка 5"
};
Console.WriteLine("Выбранная дата");
Console.WriteLine("  Заметка 1");
Console.WriteLine("  Заметка 2");
Console.WriteLine("  Заметка 3");
Console.WriteLine("  Заметка 4");
Console.WriteLine("  Заметка 5");
int pos = 1;
ConsoleKeyInfo key;
Console.CursorVisible = false;

do
{
    key = Console.ReadKey();

    Console.SetCursorPosition(0, pos);
    Console.WriteLine("  ");

    if (key.Key == ConsoleKey.UpArrow && pos != 1)
    {
        pos--;
    }
    else if (key.Key == ConsoleKey.DownArrow && pos != 5)
    {
        pos++;
    }
    Console.SetCursorPosition(0, pos);
    Console.WriteLine("->");

} while (key.Key != ConsoleKey.Enter);
Console.Clear();
Console.WriteLine("Выбранная дата");
Console.WriteLine("-----------------------");
Console.WriteLine("  " + notes[pos - 1]); 
Console.WriteLine("-----------------------");
Console.WriteLine("Описание: ");
Console.WriteLine("Дата: ");
