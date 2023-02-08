using System;

namespace _02._MergeSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[]{ 3, 10, 6, 13, 7, 1, 5 };
            Console.WriteLine(string.Join(" ",MergeSort(arr)));

        }
        static int[] MergeSort(int[] array)
        {
            int[] firstHalf;
            int[] secondHalf;   
            int[] result = new int[array.Length];

            if(array.Length <= 1)
                return array;

            int middle = array.Length / 2;

            firstHalf = new int[middle];
            
            if(array.Length%2==0)
                secondHalf = new int[middle];
            else
                secondHalf = new int[middle+1];

            for(int i = 0; i < middle; i++)
            {
                firstHalf[i] = array[i];
            }
            int x = 0;

            for(int i = middle; i < result.Length; i++)
            {
                secondHalf[x] = array[i];
                x++;
            }

            firstHalf = MergeSort(firstHalf);
            secondHalf = MergeSort(secondHalf);
            result = Merge(firstHalf, secondHalf);

            return result;


            
            

        }
        static int[] Merge(int[] left, int[] right)
        {
            
            int resultLength = right.Length + left.Length;
            int[] result = new int[resultLength];
            
            int indexLeft = 0, indexRight = 0, indexResult = 0;
            
            while (indexLeft < left.Length || indexRight < right.Length)
            {
                
                if (indexLeft < left.Length && indexRight < right.Length)
                {
                    

                    if (left[indexLeft] <= right[indexRight])
                    {
                        result[indexResult] = left[indexLeft];
                        indexLeft++;
                        indexResult++;
                    }
                    
                    else
                    {
                        result[indexResult] = right[indexRight];
                        indexRight++;
                        indexResult++;
                    }
                }
                
                else if (indexLeft < left.Length)
                {
                    result[indexResult] = left[indexLeft];
                    indexLeft++;
                    indexResult++;
                }

                else if (indexRight < right.Length)
                {
                    result[indexResult] = right[indexRight];
                    indexRight++;
                    indexResult++;
                }
            }
            return result;
        }
    }
}
