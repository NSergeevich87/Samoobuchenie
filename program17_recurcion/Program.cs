/* Домашнее задание:
1. Реализовать вывод массива с помощью рекурсии.
2. Найти сумму элементов массива с помощью рекурсии.
3. Найти сумму цифр числа с помощью рекурсии. 561 = 12 */

System.Console.Clear();

int NewMessage(string message)
{
    System.Console.Write(message);
    string answer = Console.ReadLine();
    int number = int.Parse(answer);
    return number;
}

int[] NewArray(int number)
{
    int size = number;
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(10);
    }

    return array;
}

void PrintArray(int[] array, int i = 0)
{
    if (i < array.Length)
    {
        System.Console.Write($"{array[i]} ");
        PrintArray(array, i + 1);
    }
}

int SumElemOfArray(int[] array, int i = 0)
{
    if (i >= array.Length) return 0;
    return array[i] + SumElemOfArray(array, i + 1);
}

int SumOfNamber(int num)
{
    if (num < 10) return num;
    return num % 10 + SumOfNamber(num / 10);
}

int size = NewMessage("Vvedite razmer massiva: ");
int[] newArray = NewArray(size);
PrintArray(newArray);
System.Console.WriteLine();
int num = SumElemOfArray(newArray);
System.Console.WriteLine(num);

int number = NewMessage("Vvedite chislo: ");
int number2 = SumOfNamber(number);
System.Console.WriteLine(number2);

