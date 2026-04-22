

// Different datatypes
/*
    text - string
    intergers - int
    decimal - double, float, decimal
    logical - bool
 */

string name = "Lenny Delatour";

Console.WriteLine(name);
Console.WriteLine("I am " + name);  // String concatenation
Console.WriteLine($"They call me {name}");  // String interpolation
Console.WriteLine("I was given the name {0}", name);  // Formatted string

int age = 97;
int retirementYearsLeft = 15;
int retirementAge = age + retirementYearsLeft;

Console.WriteLine("My age is: " + age);
Console.WriteLine("My retirement age is: " + retirementAge);

bool isRetired = false;
Console.WriteLine("Am I retired? " +  isRetired);