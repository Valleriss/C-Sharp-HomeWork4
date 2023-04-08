/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12 */

Console.Write("Введите число: ");
string n = Console.ReadLine();
Console.WriteLine($"Сумма цифр в числе = {SumDigits(n)}");

int SumDigits(string num)
{
    int sum = 0;
    for (int i = 0; i < num.Length; i++)
    {
        sum += int.Parse(num[i].ToString());
    }
    return sum;
}