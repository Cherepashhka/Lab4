using Lab4;

int hour, minutes;
do
{
    Console.Write("Введiть годину: ");
    hour = int.Parse(Console.ReadLine());
}
while (hour < 0 || hour > 23);
do
{
    Console.Write("Введiть хвилини: ");
    minutes = int.Parse(Console.ReadLine());
}
while (minutes < 0 || minutes > 59);
Console.Clear();
Doba day = new Doba(hour, minutes);
while (true)
{
    Console.Write("Оберiть дiю:\n1. Розрахувати час доби.\n2. Вивести поточний час.\n3. ToString.\n4. Вийти.\n");
    int choice = 1;
    do
    {
        if (choice < 1 || choice > 4)
            Console.Write("Оберiть одне з запропонованих: ");
        choice = int.Parse(Console.ReadLine());
    }
    while (choice < 1 || choice > 4);
    if (choice == 1)
        Console.WriteLine("Day part = " + day.WhichDayPartIsIt());
    else if (choice == 2)
        Console.WriteLine(day.WriteTime());
    else if (choice == 3)
        Console.WriteLine(day.ToString());
    else
        break;
}