namespace Clase_82
{
    /*
    Kata.HighAndLow("1 2 3 4 5");  // return "5 1"
    Kata.HighAndLow("1 2 -3 4 5"); // return "5 -3"
    Kata.HighAndLow("1 9 3 4 -5"); // return "9 -5"
    */

    class Program
    {
        public static void Main(string[] args)
        {
            string test = "what time are we climbingsdhthr up to the volcano"; //taxi 54
            Console.WriteLine(High(test));
        }
        public static string High(string s)
        {
            char[] mesArr = s.ToLower().ToCharArray();

            string alf = "abcdefghijklmnopqrstuvwxyz";
            char[] alfArr = alf.ToCharArray();

            string word = String.Empty;
            int maxSum = 0;
            int sum = 0;
            string newWord = String.Empty;

            for (int i = 0; i < mesArr.Length; i++)
            {
                if (mesArr[i] == ' ')
                {
                    i++;
                    if (maxSum < sum)
                    {
                        maxSum = sum;
                        newWord = word;
                    }
                    sum = 0;
                    word = "";
                }
                for (int j = 0; j < alfArr.Length; j++)
                {
                    if (i == mesArr.Length - 1)
                    {
                        if (mesArr[i] == alfArr[j])
                        {
                            sum += j + 1;
                            word += mesArr[i];
                            if (maxSum < sum)
                            {
                                maxSum = sum;
                                newWord = word;
                            }
                            break;
                        }
                    }
                    else if (mesArr[i] == alfArr[j])
                    {
                        sum += j + 1;
                        word += mesArr[i];
                        break;
                    }
                }
            }
            return newWord;
        }

        public static void PrintArr(int[] array)
        {
            for (int i = 0; i <= array.Length - 1; i++)
            {
                Console.Write(array[i]);
            }
        }
    }
}