// Напишите программу, 
// которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа

Console.WriteLine("Введите трехзначное число");
int n;
n = Convert.ToInt32(Console.ReadLine());
if(n < 1000 && n > 99)
{
    Console.WriteLine(n / 10 % 10);
}
else
{
    Console.WriteLine("Неверное число");
}
