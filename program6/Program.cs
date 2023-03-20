int NewMessage(string message)
{
    System.Console.Write(message);
    string answer = Console.ReadLine();
    int result = int.Parse(answer);
    return result;
}

void NumCount(int num)
{
int chislo = num;
int count = 1;
int chet = 0;
int neChet = 0;
while (count <= chislo)
{
    if (count %2 == 0)
    {
        chet++;
        
    }
    
    if (count %2 != 0)
    {
        neChet++;
        
    }

    
        count++;
    
}

System.Console.WriteLine($"Четных чисел: {chet}, Нечетных чисел: {neChet}");

}

int number = NewMessage("Введите число: ");
NumCount(number);