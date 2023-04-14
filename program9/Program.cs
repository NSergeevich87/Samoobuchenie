// Заполнить массив с клавиатуры
// Вывести массив в обратном порядке
// Найти сумму четных чисел в массиве
// Найти наименьшее число в массиве

Console.Clear();

System.Console.Write("Введите количество элементов в массиве:\t");
int numElem = int.Parse(Console.ReadLine());

int[] newArray = new int[numElem];

int len = newArray.Length;
System.Console.WriteLine(len);

for (int i = 0; i < newArray.Length; i++)
{
    int newElemOfArray = 0;
    System.Console.WriteLine($"Введите {i}й элемент массива: ");
    newElemOfArray = int.Parse(Console.ReadLine());
    newArray[i] = newElemOfArray;
}

int sum = 0;
int minNumber = newArray[0];

for (int i = newArray.Length - 1; i >= 0; i--)
{
    System.Console.Write($"{newArray[i]} ");
}

for (int i = 0; i < newArray.Length; i++)
{
    if (newArray[i] %2 == 0)
    {
        sum += newArray[i];
    }
}
System.Console.WriteLine();
System.Console.WriteLine(sum);

for (int i = 0; i < newArray.Length; i++)
{
    if (newArray[i] < minNumber) minNumber = newArray[i];
}
System.Console.WriteLine(minNumber);