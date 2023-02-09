using HelloWorld;

Console.WriteLine("Add numbers!");

Console.Write("Enter number 1: ");
var input1 = Console.ReadLine();

Console.Write("Enter number 2: ");
var input2 = Console.ReadLine();

double.TryParse(input1, out var a);
double.TryParse(input2, out var b);

var result = Calculator.Add(a, b);

if (result == 42)
{
    Console.WriteLine("JACKPOT!!!!!!!");
}
else if (result > 100)
{
    Console.WriteLine("Big number!");
}
else
{
    Console.WriteLine($"Result: {result}");
}
