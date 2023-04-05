/* 
System.Console.WriteLine("Vvedite chislo: ");
int a = int.Parse(Console.ReadLine());

switch (a)
{
    case 1:
        System.Console.WriteLine("Vveli chislo 1");
        break;
    case 2:
        System.Console.WriteLine("Vveli chislo 2");
        break;
    default:
        System.Console.WriteLine("Ne znayu chto delat s chislom!");
        break;
}

ConsoleKey consoleKey = Console.ReadKey().Key;
switch (consoleKey)
{
    
    default:
} */

double ReadNumber(string message)
{
    Console.Write(message);
    string answer = Console.ReadLine();
    double number = int.Parse(answer);
    return number;
}

char ReadSimbol(string message)
{
    System.Console.WriteLine(message);
    string answer = Console.ReadLine();
    char sim = char.Parse(answer);
    return sim;
}

void MetodResult(double a, char simbol, double b)
{
    switch (simbol)
    {
        case '/':
        Console.WriteLine($"{a} / {b} = {a/b}");
        break;
        case '*':
        Console.WriteLine($"{a} * {b} = {a*b}");
        break;
        case '-':
        Console.WriteLine($"{a} - {b} = {a-b}");
        break;
        case '+':
        Console.WriteLine($"{a} + {b} = {a+b}");
        break;
        
    }
}

double a = ReadNumber("Введите число: ");
char simbol = ReadSimbol("Введите /, *, -, + над числом: ");
double b = ReadNumber("Введите число: ");
MetodResult(a, simbol, b);