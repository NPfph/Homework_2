// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
// 645 -> 5; 78 -> третьей цифры нет; 32679 -> 6
Console.WriteLine("Введите число");
int n;
n = Convert.ToInt32(Console.ReadLine());
if (n < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else if (n > 99 && n < 1000)
{
    Console.WriteLine(n % 10);
}
else if (n > 999 && n < 10000)
{
    Console.WriteLine(n / 10 % 10);
}
else if (n > 9999 && n < 100000)
{
    Console.WriteLine(n / 100 % 10);
}
else 
{
    Console.WriteLine("Неверное число");
}