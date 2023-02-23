// 1. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 или Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int InputInt(string msg)
{
    System.Console.Write($"{msg}>");
    int value;

    if (int.TryParse(Console.ReadLine(), out value))
    {
    return value;
    }

System.Console.WriteLine("Вы ввели не число");
Environment.Exit(1);
return 0;

}

bool ValidareCoords(int x, int y)
{
    if (x == 0 || y == 0)
    {
        System.Console.WriteLine("Одна из координат находится на оси");
        return false;
    }
    return true;
}

int GetQuoter(int x, int y)
{
    if (x > 0 && y > 0)
    {
        return 1;
    }
    if (x < 0 && y > 0)
    {
        return 2;
    }
    if (x < 0 && y < 0)
    {
        return 3;
    }
    return 4;

}

int x = InputInt("Введите x");
int y = InputInt("Введите y");
if (ValidareCoords(x, y))
{
    System.Console.WriteLine($"Координаты {x}, {y} находятся в четверти {GetQuoter(x, y)} ");
}