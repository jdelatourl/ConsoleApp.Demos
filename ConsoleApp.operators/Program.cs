
// 2 ways to get an option fron the input.
Console.Write("Please enter the first Number: ");
int num1 = Convert.ToInt32(Console.ReadLine());


Console.Write("Please enter the second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());  

/* Math Operations and operators 
 */
// Add numbers
int sum = num1 + num2;  
// multiply
int product = num1 * num2;
// Division
int quotient = num1 / num2;
// Subtraction
int difference = num1 - num2;
// Modulus
int mod = num1 % num2;

Console.WriteLine("********************* Math Results *************************");
Console.WriteLine();
Console.WriteLine($"sum: {sum}");
Console.WriteLine($"product: {product}");
Console.WriteLine($"quotient: {quotient}");
Console.WriteLine($"difference: {difference}");
Console.WriteLine($"Modulus: {mod}");
Console.WriteLine();
Console.WriteLine("********************* End Math Results *************************");



/* Logic Operations and operators
 */

bool isGreaterThan = num1 > num2;
bool isLessThan = num1 < num2;  
bool isEqualTo = num1 == num2;
bool isGreaterThanOrEqualTo = num1 > num2;
bool isLessThanOrEqualTo = num1 < num2;
bool isNotEqual = num1 != num2;

Console.WriteLine("********************* Logic Results *************************");
Console.WriteLine();
Console.WriteLine($"Is greater than: {isGreaterThan}");
Console.WriteLine($"Is less than: {isLessThan}");
Console.WriteLine($"Is equal to: {isEqualTo}");
Console.WriteLine($"Is greater than or equal to: {isGreaterThanOrEqualTo}");
Console.WriteLine($"Is less than or equal to: {isLessThanOrEqualTo}");
Console.WriteLine($"Is not equal: {isNotEqual}");
Console.WriteLine();
Console.WriteLine("********************* end Logic Results *************************");

/*
    Assignment Operations and Operators
*/
Console.Write("Enter Random Value for Assignment Operations: ");
int randomValue = Convert.ToInt32(Console.ReadLine());
//int increaseValue = num1 + 5;

//num1 = num + 5;
//num1 += 5;

Console.WriteLine("********************* Assignment Results *************************");
Console.WriteLine();
//num1 = num1 + randomValue;
num1 += randomValue;
Console.WriteLine($"num 1 increased by {randomValue}: {num1}");
//num1 = num1 - randomValue;
num1 -= randomValue;
Console.WriteLine($"num 1 reduced by {randomValue}: {num1}");
//num1 = num1 / randomValue;
num1 /= randomValue;
Console.WriteLine($"num 1 divided by {randomValue}: {num1}");
//num1 = num1 % randomValue;
num1 %= randomValue;
Console.WriteLine($"num 1 mod by {randomValue}: {num1}");
//num1 = num1 * randomValue;
num1 *= randomValue;
Console.WriteLine($"num 1 multiplied by {randomValue}: {num1}");
Console.WriteLine();
Console.WriteLine("********************* End Assignment Results *************************");








