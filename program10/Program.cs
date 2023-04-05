/* int result = myArray.Min();
myArray.Where(in => i % 2 == 0).Sum(); */

/* int[] myArray = new int[10] {89,7,5,43,77,8,30,70,9,72};
System.Console.WriteLine(myArray[^2]); */

int[,] myArray = new int[3, 5] 
{
    {1,2,3,4,5},
    {5,7,3,4,9},
    {5,9,4,7,0}
};

int height = myArray.GetLength(0);
int width = myArray.GetLength(1);

for (int i = 0; i < height; i++)
{
    for (int j = 0; j < width; j++)
    {
        System.Console.Write(myArray[i,j] + "\t");
    }
    System.Console.WriteLine();
}



System.Console.WriteLine(myArray.Rank);
System.Console.WriteLine(myArray.Length);
System.Console.WriteLine(myArray.GetLength(0));

/* foreach (var item in myArray)
{
    System.Console.Write(item + " ");
} */

//System.Console.WriteLine(myArray[0, 2]);
