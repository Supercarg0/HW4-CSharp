/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

try
{
    int SumOfNumbers(int num)
    {
        int res = 0;
        for (int i = 0; i <= num; i++)
        {
            res = res + num % 10;
            num = num / 10;
        }
        return res;
    }
    Console.WriteLine("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    int SumOfNum = SumOfNumbers(num);
    Console.WriteLine($"Сумма цифр в числе {num} -> {SumOfNum}");
}
catch
{
    Console.WriteLine("Ошибка ввода! Введите число!");
}

