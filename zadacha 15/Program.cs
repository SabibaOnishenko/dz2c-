//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
//является ли этот день выходным.

Console.WriteLine("Введи цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckDayWeek (int dayNumber) {
  if (dayNumber == 6 || dayNumber == 7) 
  {
  Console.WriteLine("(это выходной) -> да");
  }
  else if (dayNumber < 1 || dayNumber > 7) {
    Console.WriteLine("ошибка");
  }
  else Console.WriteLine("(этот день не выходной) -> нет");
}

CheckDayWeek(dayNumber);