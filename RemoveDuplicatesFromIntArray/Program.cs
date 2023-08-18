// See https://aka.ms/new-console-template for more information
using RemoveDuplicatesFromIntArray;

Console.WriteLine("Hello, World!");

int[] input = new[] { 1, 2, 3, 4, 4, 56 };

Console.WriteLine("Input");

foreach (int i in input)
{
    Console.Write(i + ", ");
}
Console.Write("\n");

int[] result = input.RemoveDuplicates();

Console.WriteLine("Output");

foreach (int i in result)
{
    Console.Write(i + ", ");
}
Console.Write("\n");

Console.WriteLine("Output Enumerable");

foreach (int i in input.RemoveDuplicatesEnumerable())
{
    Console.Write(i + ", ");
}
Console.Write("\n");