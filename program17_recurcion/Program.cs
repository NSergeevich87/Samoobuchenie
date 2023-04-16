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

    if (i <= array.Length - 1)
    {
        System.Console.Write($"{array[i]} ");
        i++;
    }
    else return;

    PrintArray(array, i);
}

void SumElemOfArray(int[] array, int sum = 0, int i = 0)
{
    if (i == array.Length)
    {
        System.Console.WriteLine(sum);
        return;
    }
    else
    {
        sum += array[i];
        i++;
    }

    SumElemOfArray(array, sum, i);
}

void SumOfNamber(int num, int result = 0)
{
    if (num > 0)
    {
        int number = num;
        num /= 10;
        number %= 10;

        result += number;
    }
    else
    {
        System.Console.WriteLine(result);
        return;
    }
    
    SumOfNamber(num, result);

}

int size = NewMessage("Vvedite razmer massiva: ");
int[] newArray = NewArray(size);
PrintArray(newArray);
System.Console.WriteLine();
SumElemOfArray(newArray);

int number = NewMessage("Vvedite chislo: ");
SumOfNamber(number);


