/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int Degr(int num1, int num2)
{
    int res = num1;
    for (int i = 1; i < num2; i++)
    {
        num1 = res * num1;
    }
    return num1;
}
try
{
    Console.WriteLine("Введите основание степени: ");
    int basis = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите показатель степени: ");
    int indicat = Convert.ToInt32(Console.ReadLine());
    int ResDegr = Degr(basis, indicat);

    Console.WriteLine($"{basis} в степени {indicat} -> {ResDegr}");
}
catch
{
    Console.WriteLine("Ошибка ввода! Введите число!");
}

