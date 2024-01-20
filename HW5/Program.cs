
// check if number is divided by 5 without remain

Console.WriteLine("Let's check if number is divided by 5");
Console.WriteLine("Write a number");

int getNum;
getNum = Convert.ToInt32(Console.ReadLine());

if (getNum % 5 == 0)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
} 

// write a program wich will do: /; +; -; *;
// while division and substraction, greater number should bechosen first
// if least number is 0, program should write "Not Allowed To Divide By Zero"


Console.WriteLine("Choose Operation: ");
var operation = Console.ReadLine();

Console.WriteLine("First Number");
int firstNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Second Number");

int secondNum = Convert.ToInt32(Console.ReadLine());

if (operation == "+" )
{
    Console.WriteLine("Result:");
    Console.WriteLine(firstNum + secondNum);
}

if (operation == "*")
{
    Console.WriteLine("Result:");
    Console.WriteLine(firstNum * secondNum);
}

if (operation == "-")
{
    if (firstNum > secondNum)
    {
        Console.WriteLine("Result:");
        Console.WriteLine(firstNum - secondNum);
    }
    else
    {
        Console.WriteLine("Result:");
        Console.WriteLine(secondNum - firstNum);
    }
}

if (operation == "/")
{
    if (firstNum > secondNum)
    {
        Console.WriteLine("Result:");
        Console.WriteLine(firstNum / secondNum);
    }
    if (firstNum < secondNum)
    {
        Console.WriteLine("Result:");
        Console.WriteLine(secondNum / firstNum);
    }

    if (firstNum == 0 || secondNum == 0)
    {
        Console.WriteLine("Result:");
        Console.WriteLine("Not Allowed To Divide By Zero");
    }
}




// replace variable values
// input: x=5 y=10
// output: x = 10 y = 5


Console.WriteLine("Input X: ");
int inputX = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input Y: ");
int inputY = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Result: X = {inputX}; Y = {inputY}");

Console.WriteLine("Exchanging values: ");

int x = inputY;
int y = inputX;

Console.WriteLine($"X = {x}; Y = {y}");



// create multiply table for input


Console.WriteLine("Input:");
int input = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Multiply table for input:");

for (int i = 1; i < 10; i++)
{
    Console.WriteLine($"{input} * {i} = {i * input} ");
}



// get input n, find even numbers 1 to n and print their pwr 2

Console.WriteLine("Your input n:");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <n; i++)
{
    if ( i % 2 == 0)
    {
        Console.WriteLine($"{Math.Pow(i,2)}");
    }
    else
    {
        continue;
    }
}









