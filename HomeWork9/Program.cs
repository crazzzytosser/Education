// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке 
// от 1 до N.
/*
void PrintDigits(int n)
{
    if (n > 1) PrintDigits(n - 1);
    Console.Write(n + " ");
}

int n = 25;
Console.Write($"N = {n}\t\t");
PrintDigits(n);
*/

/*
// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в 
// промежутке от M до N.


void PrintNums(int m, int n)
{
    if (m > n)
    {
        Console.Write(m + "  ");
        PrintNums(m - 1, n);
    }
    if (n > m)
    {
        PrintNums(m, n - 1);
        Console.Write(n + " ");
    }
    if (m == n) Console.Write(m + " ");
}

int m = 10;
int n = -10;
PrintNums(m,n);
*/

/*
// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два 
// неотрицательных числа m и n.

int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
        else 
            if (m > 0 && n == 0) 
            return Akkerman(m - 1, 1);
        else 
            if (m > 0 && n > 0) 
            return Akkerman(m - 1, Akkerman(m, n - 1));
    else
    {
        return 0;
    }
}
void Res()
{
    int m = 3;
    int n = 5;
    int res = Akkerman(m, n);
    Console.WriteLine(res);
}
Res();
*/