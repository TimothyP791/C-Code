// For loop C#

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Value of {i}");
}

for (int i = 10; i > 0; i--)
{
    Console.WriteLine($"Value of {i}");
}
var fibNumbers = new List<int> { 0, 1, 1, 2, 3, 5, 8, 13 };

foreach (int element in fibNumbers)
{
    Console.WriteLine($"Value of {element}");
}
