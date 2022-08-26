/*
Задача 64: Задайте значения M и N.
Напишите рекурсивный метод, который выведет все натуральные числа кратные 3-ём в промежутке от M до N.
M = 1; N = 9. -> "3, 6, 9"
M = 13; N = 20. -> "15, 18"
*/

void RecursiveMethod(int M = 1, int N = 33)
{
    if (M > N) return;
    if (M%3 == 0)
    Console.Write(M + " ");
    M++;
    RecursiveMethod(M, N);
}
RecursiveMethod();