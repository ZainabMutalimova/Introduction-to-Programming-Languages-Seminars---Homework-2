Console.WriteLine("Упражненеи № 1");

Console.WriteLine("Ввведите трехзначное число число:");
int number = Convert.ToInt32(Console.ReadLine());
string stringFromNumber = Convert.ToString(number);
Console.WriteLine($"Вторая цифра числа: {stringFromNumber[1]}");

Console.WriteLine("Упражненеи № 2");

Console.WriteLine("Ввведите число:");
int num = Convert.ToInt32(Console.ReadLine());
string stringFromNum = Convert.ToString(num);
if (stringFromNum.Length >= 3) Console.WriteLine($"Третья цифра числа: {stringFromNum[2]}");
else Console.WriteLine("Число имеет меньше трёх разрядов");

Console.WriteLine("Упражненеи № 3");

Console.WriteLine("Ввведите порядковый номер дня недели:");
int day = Convert.ToInt32(Console.ReadLine());
switch (day)
{
    case 1:
        Console.WriteLine("Это будний день");
        break;
    case 2:
        goto case 1;
    case 3:
        goto case 1;
    case 4:
        goto case 1;
    case 5:
        goto case 1;
    case 6:
        Console.WriteLine("Это выходной день");
        break;
    case 7:
        goto case 6;
    default:
        Console.WriteLine("Вы шалите");
        break;
}