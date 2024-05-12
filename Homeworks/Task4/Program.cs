Console.Write("Введите натуральное число N: ");  //input 113
int N = Convert.ToInt32(Console.ReadLine());
if (N < 10)                                  //113 > 10
{
Console.WriteLine(N);
}
else
{
while (N > 0)                               //113 > 0    //11 > 0   //1 > 0
{
int currentDigit = N % 10;               //output 3     //output 1   //output 1
N /= 10;                                 //output 11    //output 1   //output 0
if (N > 0)                               //11 > 0        // 1 > 0    //0 = 0
{
Console.Write(currentDigit + ",");        //output 3,   //output 1,  
}
else
{
Console.WriteLine(currentDigit);                                     //output 1
}
}
}