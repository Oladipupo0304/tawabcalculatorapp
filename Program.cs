// // See https://aka.ms/new-console-template for more information
Console.WriteLine("=====Calculator App=====\nHELLO USER");

Console.WriteLine(" insert 'start' or 's' to open");
string open = Console.ReadLine()!;


while (!((open.Equals("start", StringComparison.OrdinalIgnoreCase)  || open.Equals("s", StringComparison.OrdinalIgnoreCase))))
{   Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("invalid key word inserted type ");
    Console.ResetColor();
    Console.Write("'start or 's' to open properly ");
    open =  Console.ReadLine()!;
}  

Console.WriteLine("calculator\n what sign would you do.");
string select_sign = Console.ReadLine()!.ToLower();
Console.WriteLine("Enter two number");
Console.WriteLine("----------------");

Console.WriteLine("Enter first number ");
int number1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Enter second number ");
int number2 = int.Parse(Console.ReadLine()!);
//variable defination
//variable declaration
int operationResult;
switch(select_sign )
{

    case "+":
 operationResult = number1 + number2;
 Console.WriteLine($"the result of operation is: {operationResult}");
    break;
    case"-":
operationResult = number1 - number2; 
Console.WriteLine($"the result of the operation is: {operationResult}");
    break;
    case "*":
operationResult = number1 * number2; 
Console.WriteLine($"the result of the operation is: {operationResult}");
    break;
    case "/":
operationResult = number1 / number2; 
Console.WriteLine($"the result of the operation is: {operationResult}");
    break;

}

Console.WriteLine("THANKS FOR USING THIS APP");