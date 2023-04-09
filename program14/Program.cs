/* string text = null;
text = text ??= string.Empty;
System.Console.WriteLine("Kolichestvo simvolov v stroke: " + text.Length);

int[] array = {1, 2, 3};
ref int b = ref array[0];
b = -5;
System.Console.WriteLine(b); */

// metod kotoriy sposoben uvelichit ili umenshit razmer massiva

/* int[] Resize(int[] arr, int numF, int numL, int numI)
{
    int[] newArray = arr;

    newArray[0] = numF;
    newArray[newArray.Length - 1] = numL;
    newArray[numI] = 99;
    
    return newArray;
}*/

void PrintArray<T>(T[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]} ");
    }
}
/*
int[] array = new int[5];

PrintArray(array);

int numFirst = 5; // Dlya vvoda pervogo elementa
int numLast = 10; // Dlya poslednego elementa
int numIndex = 1; // Dlya lubogo indeksa 99
array = Resize(array, numFirst, numLast, numIndex);

System.Console.WriteLine();
PrintArray(array);
 */

void Resize<A>(ref A[] array, int newSize)
{
  
  A[] newArray = new A[newSize];

    for (int i = 0; i < array.Length && i < newArray.Length; i++)
    {
        newArray[i] = array[i];
    }

    array = newArray;
}

int[] myArray = { 1, 4, 6 };
PrintArray(myArray);

Resize(ref myArray, 2);
// Array.Resize(ref myArray, 2);
System.Console.WriteLine();

PrintArray(myArray);

System.Console.WriteLine();
string[] text = {"hello", "world", "russia"};
Resize(ref text, 2);
PrintArray(text);
 