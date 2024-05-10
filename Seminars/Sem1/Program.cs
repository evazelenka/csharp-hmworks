// Console.WriteLine("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"{num} -> {num * num}");

// Console.WriteLine("Input 1st number: ");
// int num1 = Convert.ToInt32 (Console.ReadLine());
// Console.WriteLine("Input 2nd number: ");
// int num2 = Convert.ToInt32 (Console.ReadLine());
// if (num1 == num2*num2)
// {
//     Console.WriteLine($"{num1} is quad of {num2}");
// } else
// {
//     Console.WriteLine($"{num1} is not quad of {num2}");
// }

// Console.WriteLine("Input number: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int i = -n;
// while (i <= n)
// {
//     Console.Write(i + " ");
//     i = i + 1;
// }

Console.WriteLine("Input number: ");
int i = Convert.ToInt32(Console.ReadLine());
if (i > 99 & i < 1000)
{
    int a1 = i / 100;
    int a2 = i % 10;
    int sum = a1 + a2;
    Console.WriteLine(sum);
}else
{
    Console.WriteLine("this number is not three-digit. ");
}