// Задайте двумерный массив. Найдите элементы, у которых оба 
// индекса чётные, и замените эти элементы на их квадраты.

int[,] CreateMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

// void SquadMatrix(int[,] matrix)
// {
//    for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if(i % 2== 0 && j%2 == 0)
//             {
//             matrix[i,j] = matrix[i,j] * matrix[i,j];
//             }
//         }
//     }  
// }
// Console.WriteLine("Input array rows");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input array columns");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] array = CreateMatrix(rows, columns, min, max);
// PrintMatrix(array);
// Console.WriteLine("");
// SquadMatrix(array);
// PrintMatrix(array);


// Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1;1) и 
// т.д.

// void SumMatrix(int[,] matrix)
// {
//     int sum = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (i == j)
//             {
//                 sum += matrix[i, j];
//             }
//         }
//     }
//     Console.WriteLine(sum);
// }

// Console.WriteLine("Input array rows");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input array columns");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("");
// int[,] array = CreateMatrix(rows, columns, min, max);
// PrintMatrix(array);
// Console.WriteLine("");
// SumMatrix(array);


// Задайте двумерный массив из целых чисел. Сформируйте новый 
// одномерный массив, состоящий из средних арифметических 
// значений по строкам двумерного массива. 


double[] SrArArray(int[,] array)
{
    double sum = 0;
    double[] array2 = new double[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        array2[i] = sum / array.GetLength(1);
        sum = 0;
    }
    return array2;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

Console.WriteLine("Input array rows");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input array columns");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input minimal value");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max value");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");
int[,] array = CreateMatrix(rows, columns, min, max);
PrintMatrix(array);
Console.WriteLine("");
PrintArray(SrArArray(array));