
int NewMessage (string message)
{
    System.Console.Write(message);
    string answer = System.Console.ReadLine();
    int result = int.Parse(answer);
    return result;
}

/* bool TernarOper (int num)
{
    int oper = num;
    return oper %2 == 0 ? true : false;
} */

int TernarOper (int num)
{
    int oper = num;
    return oper < 0 ? 0 : oper;
}

int number = NewMessage ("Ввелите целое число: ");
int res = TernarOper (number);
System.Console.WriteLine($"Число является четным: {res}");