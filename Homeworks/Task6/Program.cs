//  Задайте массив заполненный случайными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
int[] CreateRandomArray(int size)
{
    int[] array = new int [size];
    for(int i = 0; i < size; i++)
    {
        array [i] = new Random().Next(100, 1000);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void ShowEvenElements(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i] % 2 == 0)
        {
            count++;
        }else
        count+= 0;
    }
    Console.WriteLine(count);
}

Console.WriteLine("Input size");
int size = Convert.ToInt32 (Console.ReadLine());
int[] arr = CreateRandomArray(size);
PrintArray(arr);
ShowEvenElements(arr);