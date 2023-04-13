void Insert(ref int[] array, int value, int index)
{
    int[] newArray = new int[array.Length + 1];

    newArray[index] = value;

    for (int i = 0; i < index; i++)
        newArray[i] = array[i];

    for (int i = index; i < array.Length; i++)
    {
        newArray[i + 1] = array[i];
    }

    array = newArray;
}

void AddFirst(ref int[] array, int value)
{
    Insert(ref array, value, 0);
}

void AddLast(ref int[] array, int value)
{
    Insert(ref array, value, array.Length);
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
}

void MenosIndex(ref int[] array, int index)
{
    int[] newArray = new int[array.Length - 1];
    
    for (int i = 0; i < index; i++)
    {
        newArray[i] = array[i];
    }

    for (int i = index + 1; i < array.Length; i++)
    {
        newArray[i - 1] = array[i];
    }

    array = newArray;
}

void FirstDel(ref int[] array)
{
    MenosIndex(ref array, 0);
}

void LastDel(ref int[] array)
{
    MenosIndex(ref array, array.Length - 1);
}

int[] myArray = { 1, 4, 6, 2 };
Insert(ref myArray, -5, 2);
PrintArray(myArray);
System.Console.WriteLine();
AddFirst(ref myArray, -5);
PrintArray(myArray);
System.Console.WriteLine();
AddLast(ref myArray, -5);
PrintArray(myArray);
System.Console.WriteLine();
MenosIndex(ref myArray, 2);
PrintArray(myArray);
System.Console.WriteLine();
FirstDel(ref myArray);
PrintArray(myArray);
System.Console.WriteLine();
LastDel(ref myArray);
PrintArray(myArray);