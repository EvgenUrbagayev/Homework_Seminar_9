// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
//  m = 2, n = 3 -> A(m,n) = 9
//  m = 3, n = 2 -> A(m,n) = 29

using static System.Console;
Clear();

Write("Введите начальное число M: ");
int numberM = int.Parse(ReadLine()!);

Write("Введите начальное число N: ");
int numberN = int.Parse(ReadLine()!);


int AckermanFunction (int numberM, int numberN)
{
    if (numberM == 0) return numberN + 1;
    if (numberM != 0 && numberN == 0) return AckermanFunction(numberM - 1, 1);
    if (numberM > 0 && numberN > 0) return AckermanFunction(numberM - 1, AckermanFunction(numberM, numberN - 1));
return AckermanFunction(numberM, numberN);
}

WriteLine($"Функция Аккермана для чисел A({numberM},{numberN}) = {AckermanFunction(numberM, numberN)}");