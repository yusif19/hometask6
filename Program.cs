namespace hometask6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TASK1. Verilmiş ədədlər siyahısını artan sıra ilə düzülmüş ədədlər halına gətirən alqoritm.
            int[] array = { 2, 9, 4, 3, 5, 1, 7, 96, 126, 45 };
            int change = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        change = array[i];
                        array[i] = array[j];
                        array[j] = change;
                    }
                }
            }

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            //TASK2  Verilmiş iki ədədlər siyahısından birincisinin ikincisinin içində olub olmadığını tapan alqoritm.Yəni birinci array-dəki ədədlərin hamısı   2ci array-də də varsa true çıxır output-a , hər hansısa biri yoxdursa false
            int count = 0;
            int[] arr1 = { 1, 2, 4, 5, 7 };
            int[] arr2 = { 2, 1, 3, 56, 7, 7 };
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = i; j < arr2.Length; j++)
                {

                    if (arr1[i] == arr2[j])
                    {


                        count++;

                    }

                }
            }
            if (count == arr1.Length)
            {
                Console.WriteLine(true);

            }
            else
            {
                Console.WriteLine(false);
            }
            //TASK3 Verilmiş artan sıra ilə düzülmüş ədədlər siyahısındaki n ədədinin yerləşdiyi indexi tapan alqoritm (binary search)
            int[] arr = { 3, 4, 5, 6, 7, 8, 9 };
            int x = 7;
            int low = 0, high = arr.Length - 1;
            while (low <= high)
            {
                int mid = low + (high - low) / 2;

                if (arr[mid] == x)
                {
                    Console.WriteLine(mid);
                    break;
                }
                if (arr[mid] < x)
                    low = mid + 1;

                else
                    high = mid - 1;
            }





        }
    }
}