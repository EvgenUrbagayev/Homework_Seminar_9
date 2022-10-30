//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
//натуральных элементов в промежутке от M до N.

//  M = 1; N = 15 -> 120
//  M = 4; N = 8. -> 30

using static System.Console;
Clear();

WriteLine("Введите значение числа M: ");
int numberM = int.Parse(ReadLine()!);
WriteLine("Введите значение числа N:");
int numberN = int.Parse(ReadLine()!);

int z = 0;
if (numberN > numberM) { int temp = numberN; numberN = numberM; numberM = temp; };
int sum = FindSum(numberN, numberM);
WriteLine($"Сумма чисел в промежутке от {numberN} до {numberM} равна {sum}.");


int FindSum(int a, int b)
{
    z += a;
    if (a == b) return z;
    else return FindSum(a+1, b);
    
}