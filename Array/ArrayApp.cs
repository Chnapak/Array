namespace Array
{
    public class ArrayApp
    {
        public void Run()
        {
            // This program is focused on printing out arrays.

            // Translation: "Amount of elements: "
            Console.Write("Počet prvků: ");
            int desiredAmount = SafelyConvertToInt(Console.ReadLine());

            int[] values = new int[desiredAmount];

            // User inputs the integer vavlues of each element.
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = SafelyConvertToInt(Console.ReadLine());
            }

            // Printing the array in both ways.
            Console.WriteLine("---------------------");
            PrintArray(values);
            Console.WriteLine("---------------------");
            PrintArrayReverse(values);
            
        }
        public int SafelyConvertToInt(string s)
        {
            if (int.TryParse(s, out int i))
            {
                return i;
            }
            return int.MinValue;
        }

        public void PrintArray(int[] s)
        {
            for (int i = 0; i< s.Length; i++)
            {
                Console.WriteLine(s[i]);
            }
        }
        public void PrintArrayReverse(int[] s)
        {
            for (int i = s.Length; i > 0; i--)
            {
                Console.WriteLine(s[i-1]);
            }
        }
    }
}
