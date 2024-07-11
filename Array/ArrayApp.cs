using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class ArrayApp
    {
        public void Run()
        {
            int Sum = 0;

            Console.Write("Počet prvků: ");
            int desiredLenght = SafelyConvertToInt(Console.ReadLine());

            int[] values = new int[desiredLenght];

            for (int i = 0; i < values.Length; i++)
            {
                values[i] = SafelyConvertToInt(Console.ReadLine());
            }

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
