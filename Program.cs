using System;

namespace homework3103
{
    class Program
    {
        static void Main(string[] args)
        {
         {// ex #2
            Console.Write("Enter size of array: ");
            int N = int.Parse(Console.ReadLine());
            int[] numbers1 = new int[N];
            for (int i = 0; i < N; i++)
            {
                numbers1[i] = i + 1;
                Console.WriteLine(numbers1[i]);
            }
            int min = numbers1[0], max = numbers1[0], summa = 0;
            Double srar = 0;
            for (int i = 0; i < numbers1.Length; i++)
            {
                if(max<numbers1[i]){
                    max = numbers1[i];
                }
                if(min>numbers1[i]){
                    min = numbers1[i];
                }
                summa+=numbers1[i];
            }
            Console.WriteLine(min);
            Console.WriteLine(max);
            Console.WriteLine(summa);
            srar = (double)summa/N;
            Console.WriteLine(srar);
            }
            {/// ex #3 
            int[] numbers = new int[5] {1,2,3,4,5};
            numbers = ReverseArray(numbers);

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            }
            { // ex #4
            Console.Write("Enter size of array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] numbers3 = new int[n];
            for(int i = 0; i < n; i++)
            {
                numbers3[i] = i;
                Console.Write($"{numbers3[i]} ");
            }
            Console.Write("\nIndex = ");
            int index = Convert.ToInt32(Console.ReadLine());
            Console.Write("Count = ");
            int count = Convert.ToInt32(Console.ReadLine());

            numbers3 = PartOfArr(numbers3, index, count);
            foreach(var item in numbers3)
                {
                Console.Write($"{item} ");
                }
            }
        }
        static int[] ReverseArray(int[] original) {
            int[] reversed = new int[original.Length];

            for (int i = 0; i < original.Length; i++) {
                reversed[i] = original[original.Length-1-i];
            }

            return reversed;
        }
        static int[] PartOfArr(int[] arr, int index, int count)
        {
            int[] tmp = new int[count];
              for(int i = 0; i < count; i++)
                if(i + index < arr.Length)
                    tmp[i] = arr[i + index];
                else tmp[i] = 1;
             return tmp;
        }
    }
}