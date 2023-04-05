// Написать метод который выводит на экран строку.
// Символы из которых состоит строка и их количество вводятся пользователем.

// Napisat metod dlya poiska indeksa elementa massiva (tip elementov - int),
// metod dolgen vernut indeks pervogo naydennogo elementa (elsli on bedet nayden).

System.Console.Clear();

/* 
char SimbolMessage(string message)
{
    System.Console.Write(message);
    string answer = Console.ReadLine();
    char simbol = char.Parse(answer);
    return simbol;
}

int QuantityMessage(string message)
{
    System.Console.Write(message);
    string answer = Console.ReadLine();
    int number = int.Parse(answer);
    return number;
}

void RepitSimbol(char simbol, int number)
{
    for (int i = 0; i < number; i++)
    {
        Console.WriteLine($"{i + 1}: {simbol} ");
    }
}

char sim = SimbolMessage("Vvedite simbol: ");
int num = QuantityMessage("Vvedite skolko raz povtorit simbol: ");
RepitSimbol(sim, num);  */

int NewMessage(string message)
{
    System.Console.Write(message);
    string answer = System.Console.ReadLine();
    int result = int.Parse(answer);
    return result;
}

int[] CreatArray(int size, int from, int to)
{
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(from, to + 1);
    }
    
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine($"\t Index {i}: {array[i]}");
    }
}

void FindElemArray(int[] array, int number)
{
    int findIndex = -1;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
        {
            findIndex = i;
            break;
        }
    }

    if (findIndex == -1)
    {
        System.Console.WriteLine("Dannoye chislo otsutstvuet!");
    }
    else System.Console.WriteLine($"Index pervogo naydennogo chisla: {findIndex}");
}

int size = NewMessage("Vvedite razmer massiva: ");
int numbersFrom = NewMessage("Vvedite diapazon chisel OT: ");
int numbersTo = NewMessage("Vvedite diapazon chisel DO: ");
int numberFind = NewMessage("Vvedite chislo dlya poiska: ");

int[] newArray = CreatArray(size, numbersFrom, numbersTo);
System.Console.WriteLine();
PrintArray(newArray);
System.Console.WriteLine();
FindElemArray(newArray, numberFind);