double numb1 = double.Parse(Console.ReadLine());
double numb2 = double.Parse(Console.ReadLine());
double numb3 = double.Parse(Console.ReadLine());

if (numb1 < numb2 && numb2 > numb3 && numb3 < 0)
{
    Console.WriteLine("negative");
}
else if (numb1 < 0 && numb2 < 0 && numb3 > 0)
{
    Console.WriteLine("positive");
}
else if (numb1 == 0 && numb2 > numb1 && numb3 > numb2)
{
    Console.WriteLine("zero");
}