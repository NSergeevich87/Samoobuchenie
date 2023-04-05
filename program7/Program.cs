

void PrintTreangul(int x)
{
    for (int i = 0; i < x; i++)
    {


        for (int k = x; k > i; k--)
        {
            System.Console.Write("*");
        }

        System.Console.WriteLine();
    }

   

    for (int i = 0; i < x; i++)
    {
        for (int k = x; k > i; k--)
        {
            System.Console.Write(" ");
        }
        
        for (int j = 0; j <= i; j++)
        {
            System.Console.Write("*");
        }
        System.Console.WriteLine();
    }

   System.Console.WriteLine();

   for (int i = 0; i < x; i++)
    {
        for (int k = 0; k <= i; k++)
        {
            System.Console.Write(" ");
        } 
        
        for (int j = x; j > i; j--)
        {
            System.Console.Write("*");
        }
        

        System.Console.WriteLine(); 
    } 

    for (int i = 0; i < x; i++)
    {

        for (int k = 0; k <= i; k++)
        {
            System.Console.Write("*");
        }

        System.Console.WriteLine();
    }
}
System.Console.Write("Введите высоту треугольника: ");
int high = int.Parse(Console.ReadLine());

/* System.Console.Write("Введите ширину треугольника: ");
int wids = int.Parse(Console.ReadLine()); */

PrintTreangul(high);