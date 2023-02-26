/* 
создать массив из заданных чисел, найти самое маленькое число в массиве
*/
/*
int[] array1 = {11,24,3,45,5,64,7,83,9,10};
int n = array1.Length;

int count = 0;
int max = array1[count];
int min = array1[count];

while (count < n)
{
    if (array1[count] < min)
    {
        min = array1[count];
    }
    else
    {
        if (array1[count] > max)
        {
            max = array1[count];
        }
    }
    count++;
}

Console.WriteLine(min);
Console.WriteLine(max);
*/

int[] array1 = new int[20];
int[] array2 = new int[20];

int strong1 = 0;
int strong2 = 0;

void FillArray1(int[] collection1)
{
    int length1 = collection1.Length;
    int count1 = 0;
    while (count1 < length1)
    {
        collection1[count1] = new Random().Next(0, 999);
        count1++;
    }
}

void FillArray2(int[] collection2)
{
    int length2 = collection2.Length;
    int count2 = 0;
    while (count2 < length2)
    {
        collection2[count2] = new Random().Next(0, 999);
        count2++;
    }
}

void PrintArray1(int[] print1)
{
    int lengthprint1 = print1.Length;
    int countprint = 0;
    while (countprint < lengthprint1)
    {
        Console.Write(" ");
        Console.Write(print1[countprint]);
        countprint++;
    }
}

void PrintArray2(int[] print2)
{
    int lengthprint2 = print2.Length;
    int countprint2 = 0;
    while (countprint2 < lengthprint2)
    {
        Console.Write(" ");
        Console.Write(print2[countprint2]);
        countprint2++;
    }
}

void max1(int[] arraymax1)
{
    int max1Length = arraymax1.Length;
    int countmax1 = 0;
    int maximum1 = arraymax1[countmax1];
    while (countmax1 < max1Length)
    {
        if (maximum1 < arraymax1[countmax1])
        {
            maximum1 = arraymax1[countmax1];
        }
        countmax1++;
    }
    Console.WriteLine($"максимум в первом массиве: {maximum1}");
    strong1 = maximum1;
}

void max2(int[] arraymax2)
{
    int lengthmax2 = arraymax2.Length;
    int countmax2 = 0;
    int maximum2 = arraymax2[countmax2];
    while (countmax2 < lengthmax2)
    {
        if (maximum2 < arraymax2[countmax2])
        {
            maximum2 = arraymax2[countmax2];
        }
        countmax2++;
    }
    Console.WriteLine($"максимум во втором массиве: {maximum2}");
    strong2 = maximum2;
}

FillArray1(array1);
FillArray2(array2);
PrintArray1(array1);
Console.WriteLine("");
PrintArray2(array2);
Console.WriteLine("");
max1(array1);
max2(array2);

if (strong1 > strong2)
{
    Console.WriteLine("Самое большое число появилось в первом массиве");
}
else
{
Console.WriteLine("Самое большое число появилось во втором массиве");
}
