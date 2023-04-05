int[,,] myArray = new int [4, 3, 5]
{
    {
        {2,9,8,3,4},
        {2,3,9,48,7},
        {42,57,3,5,6}
    },

    {
        {08,6,6,24,6},
        {2,7,4,6,8},
        {57,98,7,5,4}
    },

    {
        {3,5,78,46,79},
        {45,68,79,7,7},
        {4,56,84,6,8}
    },

    {
        {4,69,3,4,95},
        {595,7,8,04,94},
        {46,7,4,8,4}
    }
};

/* for (int z = 0; z < myArray.GetLength(0); z++)
{
    for (int y = 0; y < myArray.GetLength(1); y++)
    {
        for (int x = 0; x < myArray.GetLength(2); x++)
        {
            myArray[z,y,x] = new Random().Next(100);
        }
    }
} */

for (int z = 0; z < myArray.GetLength(0); z++)
{
    
    System.Console.WriteLine("Page №" + (z + 1));

    for (int y = 0; y < myArray.GetLength(1); y++)
    {
        for (int x = 0; x < myArray.GetLength(2); x++)
        {
            System.Console.Write(myArray[z,y,x] + " ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine("-----------------------");
}