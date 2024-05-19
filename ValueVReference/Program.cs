//Pass by Value VS. Pass by Reference

//Value - Outside of function variable is not going to change

//Reference - Variables are changed on the outside of the function

Person p1 = new Person();
Person p2 = new Person();

p1.Age = 5;
p2.Age = 10;

Console.WriteLine(p1.Age + " " + p2.Age);
Square(p1, p2);
Console.WriteLine(p1.Age + " " + p2.Age);
void Square(Person a, Person b)
{
    a.Age *= a.Age;
    b.Age *= b.Age;
    Console.WriteLine(a.Age + " " + b.Age);
}
class Person
{
    public int Age { get; set; }
    
}
