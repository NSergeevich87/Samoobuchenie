// Заполнить массив с клавиатуры
// Вывести массив в обратном порядке
// Найти сумму четных чисел в массиве
// Найти наименьшее число в массиве

int[] newArray = new int[] { 1, 2, 3, -4, 5, 6, 7, -8, 9 };

int len = newArray.Length;
System.Console.WriteLine(len);

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