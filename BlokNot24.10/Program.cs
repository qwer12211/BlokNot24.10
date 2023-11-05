Console.WriteLine($" Выбранная дата:: {DateTime.Now}");
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
if (pos == 1)
{
    Console.WriteLine("Придти на пары");
    Console.WriteLine("-----------------------");
    Console.WriteLine("Описание: ");
    Console.WriteLine($"Дата: {DateTime.Now} ");
}

if (pos == 2)
{
    Console.WriteLine("Сходить в магазин");
    Console.WriteLine("-----------------------");
    Console.WriteLine("Описание: - ");
    Console.WriteLine($"Дата: {DateTime.Now}  ");
}

if (pos == 3)
{
    Console.WriteLine("Придти на пары");
    Console.WriteLine("-----------------------");
    Console.WriteLine("Описание:  ");
    Console.WriteLine($"Дата: {DateTime.Now} ");
}

if (pos == 4)
{
    Console.WriteLine("Сходить в магазин");
    Console.WriteLine("-----------------------");
    Console.WriteLine("Описание: купить хлеба ");
    Console.WriteLine($"Дата: {DateTime.Now}  ");
}
if (pos == 5)
{
    Console.WriteLine("Придти на пары");
    Console.WriteLine("-----------------------");
    Console.WriteLine("Описание:  ");
    Console.WriteLine($"Дата: {DateTime.Now} ");
}
do
{
    key = Console.ReadKey();

    Console.SetCursorPosition(0, pos);
    Console.WriteLine("  ");

    if (key.Key == ConsoleKey.LeftArrow && pos != 1)
    {
        pos--;
    }
    else if (key.Key == ConsoleKey.RightArrow && pos != 4)
    {
        pos++;
    }
    Console.SetCursorPosition(0, pos);

} while (key.Key != ConsoleKey.Enter);
Console.Clear();
