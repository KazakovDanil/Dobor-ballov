using System.Linq;

namespace Dobor_ballov
{
    static class ArrayExtension
    {
        public static int[] Square(this int[] array)
        {
            return array.Select(x => x * x).ToArray();
        }
        public static int[] Cube(this int[] array)
        {
            return array.Select(x => x * x * x).ToArray();
        }
        public static double Average(this int[] array)
        {
            if (array.Length == 0)
            {
                return 0;
            }
            int sum = 0;
            foreach (int number in array)
            {
                sum += number;
            }
            return (double)sum / array.Length;
        }
        public static int Sum(this int[] array)
        {
            int sum = 0;
            foreach (int number in array)
            {
                sum += number;
            }
            return sum;
        }
        public static int[] Even(this int[] array)
        {
            return array.Where(x => x % 2 == 0).ToArray();
        }
        public static int[] Odd(this int[] array)
        {
            return array.Where(x => x % 2 != 0).ToArray();
        }
    }
}
