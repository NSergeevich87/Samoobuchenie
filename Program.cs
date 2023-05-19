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

            int narcissitic = 153;
            int noNarcissitic = 1938;

            //  1^3 + 5^3 + 3^3 = 1 + 125 + 27 = 153

            bool isNarcissitic = Narcissistic(noNarcissitic);
            Console.WriteLine(isNarcissitic);
        }
        public static bool Narcissistic(int value)
        {
            // Code me
            var str = value.ToString();
            return str.Sum(c => Math.Pow(Convert.ToInt16(c.ToString()), str.Length)) == value;
        }

        public static void PrintArr(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($" {array[i]}");
            }
        }

        public static int[] arrRandom(int[] arr)
        {
            Random rand = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(10);
            }

            return arr;
        }

        public static int[] arrSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int pos = i;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[pos]) pos = j;
                }

                int temp = arr[i];
                arr[i] = arr[pos];
                arr[pos] = temp;
            }
            return arr;
        }
    }
}