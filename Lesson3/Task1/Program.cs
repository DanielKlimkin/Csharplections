﻿// Задача №1

// Вычислить значение формулы ,(a×b)/(c+d)
// где a, b, c, d — некоторые целые числа.
// Результат вывести на экран. Решеине оформит ввиде функции.

double CalculateFormula(int a, int b, int c, int d)
{
    double numenator = a * b;
    int denomenator = c + d;
    double result = numenator / denomenator;
    return result;
}

double result = CalculateFormula(1, 2, 3, 4);
Console.WriteLine(result);