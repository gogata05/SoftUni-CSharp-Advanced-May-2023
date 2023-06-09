﻿Queue<string> cars = new();
int n = int.Parse(Console.ReadLine());
string command = Console.ReadLine();
int count = 0;
while (command != "end")
{
    if (command == "green")
    {
        for (int i = 0; i < n; i++)
        {
            if (cars.Count == 0)
            {
                break;
            }
            count++;
            Console.WriteLine($"{cars.Dequeue()} passed!");
        }
    }
    else
    {
        cars.Enqueue(command);
    }
    command = Console.ReadLine();
}
Console.WriteLine($"{count} cars passed the crossroads.");

