
// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

class HelloWorld
{
    static bool isPal(int n)
    {
        int r = 0, nn = n;
        while (n > 0)
        {
            r = r * 10 + n % 10;
            n = n / 10;
        }
        return r == nn;
    }
    static void Main()
    {
        int n;
        Console.Write("Введите пятизначное число -> ");
        n = Convert.ToInt32(Console.ReadLine());
        if (isPal(n))
            Console.WriteLine("Палиндром");
        else
            Console.WriteLine("Не палиндром");
    }
}