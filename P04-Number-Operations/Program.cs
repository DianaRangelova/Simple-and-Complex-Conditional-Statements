double numb1 = double.Parse(Console.ReadLine());
double numb2 = double.Parse(Console.ReadLine());
string mathOperator = Console.ReadLine();

double result = 0;

if (mathOperator == "+")
{
    result = numb1 + numb2;
}
else if (mathOperator == "-")
{
    result = numb1 - numb2;
}
else if (mathOperator == "*")
{
    result = numb1 * numb2;
}
else if (mathOperator == "/")
{
    result = numb1 / numb2;
}
Console.WriteLine($"{numb1} {mathOperator} {numb2} = {result:F2}");

