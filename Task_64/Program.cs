//Задача 64: Задайте значение N. Напишите программу, которая выведет все
// натуральные числа в промежутке от N до 1.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


using static System.Console;
Clear();

Write("Введите значение числа n: ");
int n = int.Parse(ReadLine()!);
PrintSequence(n);





void PrintSequence(int number)
{
    Write(number +" ");
    if (number < 3) WriteLine("1");
    else PrintSequence(number - 1);
}