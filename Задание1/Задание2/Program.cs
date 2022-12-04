// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое числа");
string number1Str=Console.ReadLine();
Console.WriteLine("Введите второе числа");
string number2Str=Console.ReadLine();
Console.WriteLine("Введите третье числа");
string number3Str=Console.ReadLine();

int number1 = Convert.ToInt32(number1Str);
int number2 = Convert.ToInt32(number2Str);
int number3 = Convert.ToInt32(number3Str);

if (number1 > number2)
if (number1 > number3)
{
    Console.WriteLine(number1);
}
if (number2 > number1)
if (number2 > number3)
{
     Console.WriteLine(number2);
}
if (number3 > number1)
if (number3 > number2)
{
     Console.WriteLine(number3);
}
