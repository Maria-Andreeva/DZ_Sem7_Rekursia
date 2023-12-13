// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

Console.Clear();

void ShowNaturNumber(int m, int n)
{
    if(n <= 0 || m <= 0)
    {
        Console.WriteLine("Numb must be graiter then 0");
        return;
    }

    Console.Write(m++ + " ");

    if (m <= n)
    {
        ShowNaturNumber(m, n);
    }
}

ShowNaturNumber(1, 10);

