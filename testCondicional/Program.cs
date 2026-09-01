

/*
 * bool isRaining = false;
 * if (isRaining)
{
    Console.WriteLine("It's raining. Don't forget to take an umbrella!");
}
else
{
    Console.WriteLine("It's not raining. Enjoy your day!");
    Console.WriteLine("Have a great day!");
}

string myVariable = "this fruit is delicious";
Type type = myVariable.GetType();
Console.WriteLine(type);

object myVariable2 = 123.321;
if (myVariable2.GetType() == typeof(int))
{
    Console.WriteLine($"The variable {myVariable2} is an integer.");
} else
{
    Console.WriteLine($"The variable {myVariable2} is not an integer.");
}

string myVariable3 = "123";
int number = int.Parse(myVariable3);
Console.WriteLine(number);
Console.WriteLine(number.GetType());*/

int num1 = 5;
double num2 = 2.5;
double result = num1 + num2;
Console.WriteLine(result);

//CASTING
double num3 = 3.14;
int piInt = (int)num3;
Console.WriteLine(piInt);

//PARSING

string myString = "42";
int myInt = int.Parse(myString);
Console.WriteLine(myInt);
Console.WriteLine(myInt.GetType());
