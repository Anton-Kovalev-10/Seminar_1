// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число");
string numberFirstStr = Console.ReadLine();

Console.WriteLine("Введите второе число");
string numberSecondStr = Console.ReadLine();

int numberFirst = Convert.ToInt32(numberFirstStr);
int numberSecond = Convert.ToInt32(numberSecondStr);

if (numberFirst>numberSecond)
     Console.WriteLine(numberFirstStr);
      else
       Console.WriteLine(numberSecondStr);