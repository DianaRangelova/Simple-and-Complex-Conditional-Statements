int timeInSeconds1 = int.Parse(Console.ReadLine());
int timeInSeconds2 = int.Parse(Console.ReadLine());
int timeInSeconds3 = int.Parse(Console.ReadLine());

int totalSeconds = timeInSeconds1 + timeInSeconds2 + timeInSeconds3;
int timeInMinutes = totalSeconds / 60;
int timeInSeconds = totalSeconds % 60;

Console.WriteLine($"{timeInMinutes}:{timeInSeconds:D2}");

