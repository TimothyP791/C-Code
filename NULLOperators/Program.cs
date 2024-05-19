// NULL Conditional and Coalescing Operators

string myString = null;

Console.WriteLine(myString ?? "string");

void Print(int? num)
{
    Console.WriteLine(num);
}

Print(null);