// int[] CreateRandomArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

// // // bool CheckArray(int[] array, int num)
// // // {
// // //     for (int i = 0; i < array.Length; i++)
// // //     {
// // //         if (array[i] == num) return true;
// // //     }
// // //     return false;
// // // }

// // Console.WriteLine("Input array size");
// // int size = Convert.ToInt32(Console.ReadLine());
// // Console.WriteLine("Input minimal value");
// // int min = Convert.ToInt32(Console.ReadLine());
// // Console.WriteLine("Input max value");
// // int max = Convert.ToInt32(Console.ReadLine());

// // int[] array = CreateRandomArray(size, min, max);

// // void Invers(int[] array)
// // {
// // for (int i = 0; i < array.Length; i++)
// // {
// //     Console.Write($"{-array[i]} ");
// // }
// // }
// // PrintArray(array);
// // Invers(array);

// // Console.WriteLine("Input number to find");
// // int num = Convert.ToInt32(Console.ReadLine());

// // Console.WriteLine(CheckArray(array, num));


// int[] PairsCount(int[] array)
// {
//     int[] temparray = new int[array.Length / 2];
//     for (int i = 0; i < array.Length / 2; i++)
//     {
//         temparray[i] = array[i] * array[array.Length - i - 1];
//     }
//     return temparray;
// }
// Console.WriteLine("Input array size");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] array = CreateRandomArray(size, min, max);

// PrintArray(array);
// PrintArray(PairsCount(array));


int[] NewArray(int num)
{
    int[] newarray = new int[3];
    if(num >= 100 && num < 1000)
    {
        int ed = num % 10;
        int dec = num / 10 % 10;
        int sot =num / 100;
        newarray[0] = ed;
        newarray[1] = dec;
        newarray[2] = sot;
    }else
    {
        Console.WriteLine("not a three digit number");
    }
    return newarray;
}
Console.WriteLine("Input number to find");
int num = Convert.ToInt32(Console.ReadLine());
PrintArray(NewArray(num));