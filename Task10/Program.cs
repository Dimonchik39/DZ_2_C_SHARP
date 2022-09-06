// Задача 10: Напишите программу, которая принимает на 
// вход трехзначное число и на выходе показывает вторую
// цифру этого числа
//  456 -> 5
//  782 -> 8
//  918 -> 1

Console.Clear();
Console.WriteLine("Введите трехзначное число");
int num1 = Convert.ToInt32(Console.ReadLine());

if (num1 > 99 && num1 < 1000)
{
    int num = (num1 % 100 / 10);
    Console.WriteLine($"Вторая цифра данного числа {num}");
}    

else
{
    Console.WriteLine("Введите трехзначное число");
}
