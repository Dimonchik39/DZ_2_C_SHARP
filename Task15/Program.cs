// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());


if (num == 1 || num == 2 || num == 3 || num == 4 || num == 5) Console.WriteLine("Рабочий день");

else if (num == 6 || num == 7) Console.WriteLine("Ура - это выходной");

else 
{
    Console.WriteLine("Еще не придумали такого дня");
}
