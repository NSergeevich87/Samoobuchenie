
// int to double
/*
int a = 2;
int b = 5;

double result = (double) a / b;

Console.Write(result);
*/
// program 1 - srednee arif dvuh chisel
/*
System.Console.WriteLine("Vvedite chislo 1: ");
int a = int.Parse(Console.ReadLine());

System.Console.WriteLine("Vvedite chislo 2: ");
int b = int.Parse(Console.ReadLine());

int result = (a + b) / 2;

System.Console.WriteLine($"Srednee arif dvuh chisel: {result}");
*/
// program 2 - vvesti 3 chislo y vivesti znacheniya summy y proizvedeniya
/*
System.Console.Write("Vvedite chislo 1: ");
int a = int.Parse(Console.ReadLine());

System.Console.Write("Vvedite chislo 2: ");
int b = int.Parse(Console.ReadLine());

System.Console.Write("Vvedite chislo 3: ");
int c = int.Parse(Console.ReadLine());

int sum = a + b + c;
System.Console.WriteLine("summa chisel: " + sum);

int umn = a * b * c;
System.Console.WriteLine("proizvedeniye chisel: " + umn);
*/
// program 3 - napisat prostoy konverter valyut

System.Console.WriteLine("Введите какую валюту хотите конвертировать в рубли (Dollar или Euro): ");
string dinero = Console.ReadLine();

// Euro = 80р, Dollar = 75р

double x;
double result;

if (dinero.ToLower() == "dollar")
{
    System.Console.WriteLine("Введите количество баксиков: ");
    x = double.Parse(Console.ReadLine());
    result = x * 75;
}
else
{
    System.Console.WriteLine("Введите количество евриков: ");
    x = double.Parse(Console.ReadLine());
    result = x * 80;
}

System.Console.WriteLine("Столько деревянных: " + result);



