/*
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int TheDigit(int num1, int num2)
{
    int res = 1;
    for (int i = 0; i < num2; i++)
        {
            res *= num1;
        }
    return res;
}
Console.Write("Input your number 1:");
int res1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input your number 2:");
int res2 = Convert.ToInt32(Console.ReadLine());
int digit = TheDigit(res1, res2);
Console.Write(digit);
*/

/*
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Summ(int digit)
{
    int res = 0;
    while (digit > 0)
    {
        res += digit % 10;
        digit /= 10;
    }

    return res;
}
Console.Write("Input your digit: ");
int num = Convert.ToInt32(Console.ReadLine());
int res = Summ(num);
Console.Write($"Сумма цифр числа {num} = {res} ");
*/

/*
// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
// m = 5 -> [1, 2, 5, 7, 19]
// m = 3 -> [6, 1, 33]

int[] MyArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
    if (size <= 0)
    {
        Console.Write("Error");
    }
    else
    {
Console.Write("Введите минимальное число массива: ");
int digit1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число массива: ");
int digit2 = Convert.ToInt32(Console.ReadLine());
    
int[] array = MyArray(size, digit1, digit2);
ShowArray(array);
    }
 */