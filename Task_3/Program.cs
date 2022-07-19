// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите номер дня недели: ");
        int n;
        n = Convert.ToInt32(Console.ReadLine());
        if (n < 6)
        {
            Console.WriteLine("нет");
        }
        else
        {
            Console.WriteLine("да");
        }
    }
}