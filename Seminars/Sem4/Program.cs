// int[] CreateRandomArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// // int CountNumbers(int[] array)
// // {
// //     int count = 0;
// //     for (int i = 0; i < array.Length; i++)
// //     {
// //         if(array[i] % 10 == 1 && array[i] % 7 ==0)
// //         count++;
// //     }
// //     return count;
// // }

// int ArrayToNum(int[] array )
// {
//     string str = string.Empty;
//     for (int i = 0; i < array.Length; i++)
//     {
//         str += array[i];
//     };
//     return Convert.ToInt32(str);
// }

int CountNum(int num)
{
    int cnt = 0;
    while (num > 0)
    {
        num /= 10;
        cnt++;
    }
    return cnt;
}

// Console.WriteLine("Input array size");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] arr = CreateRandomArray(size, min, max);
// PrintArray(arr);
// Console.WriteLine(ArrayToNum(arr));

Console.WriteLine("Input number");
int num = Convert.ToInt32(Console.ReadLine());
int result = CountNum(num);
Console.WriteLine(result);