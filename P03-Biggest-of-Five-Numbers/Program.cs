int numb1 = int.Parse(Console.ReadLine());
int numb2 = int.Parse(Console.ReadLine());
int numb3 = int.Parse(Console.ReadLine());
int numb4 = int.Parse(Console.ReadLine());
int numb5 = int.Parse(Console.ReadLine());

//int max 1 = Math.Max(numb1,numb2);
//int max 2 = Math.Max(numb3,numb4);
//Console.WriteLine(Math.Max(max1, max2));

if (numb1 > numb2 && numb1 > numb3 && numb1 > numb4 && numb1 > numb5)
{
    Console.WriteLine($"{numb1}");
}
else if (numb2 > numb1 && numb2 > numb3 && numb2 > numb4 && numb2 > numb5)
{
    Console.WriteLine($"{numb2}");
}
else if (numb3 > numb1 && numb3 > numb2 && numb3 > numb4 && numb3 > numb5)
{
    Console.WriteLine($"{numb3}");
}
else if (numb4 > numb1 && numb4 > numb2 && numb4 > numb3 && numb4 > numb5)
{
    Console.WriteLine($"{numb4}");
}
else if (numb5 > numb1 && numb5 > numb2 && numb5 > numb3 && numb5 > numb4)
{
    Console.WriteLine($"{numb5}");
}