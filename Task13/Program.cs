// Задача 13: Напишите программу, которая выводит
// третью цифру заданного числа или сообщает, что
// третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.Clear();
// Console.WriteLine("Введите целое число");
// int num1 = Convert.ToInt32(Console.ReadLine());
// string num = Convert.ToString(num1);

// if (num1 > 99)
// {
//     if (num.Length > 2)
//     Console.WriteLine($"Третья цифра из числа {num1}: " + num[2]);
// }
// else
// {
//     Console.WriteLine("Введите число, не менее трехзначного");
// }

Console.Clear();
Console.WriteLine("Введите целое число");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = num1;

if (num1 < 100)
{
    Console.WriteLine("Нет третьей цифры");
}
else
{
    while (num2 > 999)
    {
        num2 = num2 / 10;
    }
    num2 = (num2 % 10);
    Console.WriteLine($"Третья цифра из числа {num1}: {num2}");
}
