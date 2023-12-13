// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.


int Ackkerman (int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return Ackkerman(m - 1, 1);
    }

    return Ackkerman(m - 1, Ackkerman(m, n - 1));  
}

Console.Write("Please enter number «m»: ");
var m = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter number «n»: ");
var n = Convert.ToInt32(Console.ReadLine());

if (m <= 0 || n <= 0)
{
    Console.WriteLine("Numb must be graiter then 0");
    return;
}

if (m > n)
{
   Console.WriteLine("Wrong Number");
   return;
}

Console.WriteLine(Ackkerman(m, n));