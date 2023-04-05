// Зубчатые массивы

System.Console.Clear();

Random random = new Random();

int[][][] myArray = new int[random.Next(3, 6)][][];

for (int z = 0; z < myArray.Length; z++)
{
    myArray[z] = new int[random.Next(2, 6)][];

    for (int y = 0; y < myArray[z].Length; y++)
    {

        myArray[z][y] = new int[random.Next(2, 6)];

        for (int x = 0; x < myArray[z][y].Length; x++)
        {
            myArray[z][y][x] = random.Next(100);
        }
    }
}

for (int z = 0; z < myArray.Length; z++)
{
    System.Console.WriteLine("Page" + (z + 1));

    for (int y = 0; y < myArray[z].Length; y++)
    {
        for (int x = 0; x < myArray[z][y].Length; x++)
        {
            System.Console.Write(myArray[z][y][x] + "\t");
        }
        System.Console.WriteLine();
    }

    System.Console.WriteLine();
}





