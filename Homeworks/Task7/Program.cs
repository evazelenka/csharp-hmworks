// Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)

int[] InverseArray(int[] array)
{
    for(int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i]= array[array.Length - i - 1];
        array[array.Length - i - 1] = temp;
        temp = 0;
    }
    return array;
}

int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int [size];
    for(int i = 0; i < size; i++)
    {
        array [i] = new Random().Next(min, max + 1);
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

Console.WriteLine("Input array size");
int size = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Input min range");
int minR = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("Input max range");
int maxR = Convert.ToInt32 (Console.ReadLine ());

int[] arr = CreateRandomArray(size, minR, maxR);
PrintArray(arr);
PrintArray(InverseArray(arr));


