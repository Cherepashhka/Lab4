using Lab4;

int hour, minutes;
do
{
    Console.Write("Enter the amount of hours: ");
    hour = int.Parse(Console.ReadLine());
}
while (hour < 0 || hour > 23);
do
{
    Console.Write("Enter the amount of minutes: ");
    minutes = int.Parse(Console.ReadLine());
}
while (minutes < 0 || minutes > 59);
Console.Clear();
Doba day = new Doba(hour, minutes);
while (true)
{
    Console.Write("Pick a option:\n1. Calculate the part of day.\n2. Write current time.\n3. ToString.\n4. Exit.\n");
    int choice = 1;
    do
    {
        if (choice < 1 || choice > 4)
            Console.Write("Choose one of offered options: ");
        choice = int.Parse(Console.ReadLine());
    }
    while (choice < 1 || choice > 4);
    if (choice == 1)
        Console.WriteLine("Part of a day = " + day.WhichDayPartIsIt());
    else if (choice == 2)
        Console.WriteLine(day.WriteTime());
    else if (choice == 3)
        Console.WriteLine(day.ToString());
    else
        break;
}