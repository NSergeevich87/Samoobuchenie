string message = Console.ReadLine();
double.TryParse(message, out double result);
System.Console.WriteLine(result);

void Foo(params object[] parameters)
{
    string message = "Тип данных {0}, значение {1}";

    foreach (var item in parameters)
    {
        System.Console.WriteLine(message, item.GetType(), item);
    }
}

Foo("Hello World", '$', 5.55, 8f, 9);