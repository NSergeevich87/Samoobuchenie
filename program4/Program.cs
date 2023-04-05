/*
bool isInfected = false;

 if (isInfected)
 {
    System.Console.WriteLine("Vi infecirovany!");
 }
 else
 {
    System.Console.WriteLine("Personag ne infecirovan!");
 }
 */

 // Proverka na chetnost

 void chetnechet(int arg)
 {
    if (arg %2 == 0)
    {
        System.Console.WriteLine("Vvedennoe chislo yavlayetsya chetnim");
    }
    else
    {
        System.Console.WriteLine("Vvedennoe chislo yavlayetsya NE chetnim");
    }
 }

 System.Console.Write("Vvedite chislo dlya proverki na chetnost: ");
 int number = int.Parse(Console.ReadLine());

 chetnechet(number);