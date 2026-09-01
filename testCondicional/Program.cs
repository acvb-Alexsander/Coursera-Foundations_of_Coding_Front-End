

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
}*/

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
Console.WriteLine(number.GetType());