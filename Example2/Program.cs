// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y)
// x >0, y<0

int InputInt(string msg)                          //Название метода
{
    System.Console.Write($"{msg}>");                //вывод приглашения ко вводу
    int value;                                      //Инициализация переменой

    if (int.TryParse(Console.ReadLine(), out value))   // Проверка условия ввода + ввод со строки
    {                                                   // если конвертация прошла правильно, то мы попадаем в ветку    
    return value;                                       // которая находится в скобках после наименования функции. Если да
    }                                                   // то выдает первое значение (ввод со строки). Нет второе(out)

System.Console.WriteLine("Вы ввели не число");          
Environment.Exit(1);                                    // если TryParse не сработало, выходим из программы (Exit) с кодом 1
return 0;                                               // нужна для компиляции
}

bool ValidateQuoter(int quoter)
{
    if(quoter < 1 || quoter > 4)
    {
        System.Console.WriteLine("Заданы не правельные значения");
        return false;
    }
    return true;
}

(int, int)GetCoords(int quoter)    //Картеж - набор переменых
{
    switch(quoter )                // Выбор четверти
    {
        case 1: return(1,1);        // что делаем при определении значения переменой  quoter. Вариант при quoter=1
        break;                      // пишется для выхода из switch. Если был до этого return можно не писать
        case 2: return(-1,1); 
        break;
        case 3: return(-1,-1); 
        break;
        default:                    //Вариация else (еслине выбрано любое другое значение)
        return (1, -1);
    }
}

int quoter = InputInt("Введите омер четверти");  // Вызываем функцию ввода с переменой quoter
if(ValidateQuoter(quoter))                       // проверка правильности ввода (что это четверть)
{
    (int x, int y) = GetCoords(quoter);         // получение пары координат (x, y) в зависимости  от введеной четверти
    System.Console.WriteLine($"Возможные координаты в четверти (quoter): {x}, {y} "); // вывод рузультата на экран
}