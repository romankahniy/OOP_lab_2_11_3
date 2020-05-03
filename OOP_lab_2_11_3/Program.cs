using System;

namespace OOP_lab_2_11_3
{
    class Program
    {
        static int AmountOfZeroes(int[] array)
        {
            int amount = 0;

            for (int i = 0; i < array.Length; ++i)
            {
                if (array[i] == 0)
                {
                    ++amount;
                }
            }

            return amount;
        }

        static int IndexOfAbsMax(int[] array)
        {
            int index = 0;

            for (int i = 0; i < array.Length; ++i)
            {
                if (Math.Abs(array[index]) <= Math.Abs(array[i]))
                {
                    index = i;
                }
            }

            return index;
        }

        static int Multiplication(int[] array)
        {
            int index = IndexOfAbsMax(array);
            if (index == array.Length - 1)
            {
                return 0;
            }
            else
            {
                int d = 1;

                for (int i = index; i < array.Length; ++i)
                {
                    d *= array[i];
                }

                return d;
            }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var random = new Random();
            int[] array = new int[n];

            for (int i = 0; i < n; ++i)
            {
                array[i] = random.Next(-100, 100);
            }

            for (int i = 0; i < n; ++i)
            {
                Console.WriteLine("a[{0}] = {1}", i, array[i]);
            }

            Console.WriteLine("\nKiлькiсть нульових елементiв масиву: {0}", AmountOfZeroes(array));
            Console.WriteLine("\nДобуток елементiв масиву, розташованих пiсля максимального за модулем елемента: {0}", Multiplication(array));
        }
    }
}
