// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Пожалуйста, введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = num1;
int sum = 0;
if (num1 > -9 && num1 < 9)
Console.WriteLine($"Ошибка: введено число из одной цифры. Сумма равна введённому числу: {num1}.");
else
{

while (num1 > 0)
{
    sum = sum + num1 % 10;
    num1 = num1 / 10;
}
Console.WriteLine($"Сумма цифр в числе {num2} равна {sum}.");
}