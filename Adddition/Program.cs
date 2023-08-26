Console.WriteLine("Задача \"Дополнительная\"");

int randomNumber = RandomNumber(0, 100);

int RandomNumber(int min, int max)
{
  return new Random().Next(min, max);
}

void AttemptCounter(int maxCounter)
{

  int counter = 1;
  int myNumber= 0;
  while (counter <= maxCounter)
  {

    Console.Write("Попытка номер " + counter + ".  Введи число от 1 до 99: ");

    myNumber = Convert.ToInt32(Console.ReadLine());

    if (myNumber == randomNumber)
    {
      Console.WriteLine("Поздравляю, ты угадал! ");
      break;
    }
    else
    {
      if (myNumber > randomNumber)
      {
        Console.WriteLine("Не угадал, твоё число великовато");
      }
      else Console.WriteLine("Не угадал, твоё число маловато");
      counter++;
    }
  }
  if (myNumber != randomNumber)
  {
    Console.WriteLine("В основные попытки не уложился. Продолжим ? (напиши да/нет)");

    string? yesNo = Console.ReadLine().ToLower();

    if (yesNo == "да")
    {
      AttemptCounter(1000);
    }
    else Console.Write("Загаданное число было: " + randomNumber);
  }
}

Console.WriteLine("Игра до 3 попыток");
AttemptCounter(3);