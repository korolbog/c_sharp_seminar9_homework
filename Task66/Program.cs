/*
Задача 66:
Задайте значения M и N.
Напишите рекурсивный метод,
который найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int sum = 0;
int M = 4;
int N = 8;
void RecursiveMethod(int counter = 1)
{
    if (counter > N-M+1) return;
    sum = sum + (M+N);
    counter++;
    RecursiveMethod(counter);
}
RecursiveMethod();
Console.WriteLine(sum/2);