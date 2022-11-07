/*

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int AllNumbers(int m)
{  
    int count = 0;
    for (int i = 0; i < m; i++)
    {         
        Console.Write($"Введите {i + 1}-e число: ");
        if(Convert.ToInt32(Console.ReadLine()) > 0)
        count++;
    }
     return count;
}
Console.Write("Сколько чисел будете вводить?: ");
int res = Convert.ToInt32(Console.ReadLine());
int result = AllNumbers(res);
Console.Write(result);
*/

/*
// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void IntersectionPoint(double b1, double b2, double k1, double k2)
{
    if (k1 == k2) Console.WriteLine("Прямые параллельны.");
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k2 * x + b2;
        Console.WriteLine($"Координаты точки пересечения прямых: x: {x}, y: {y}.");
    }
}
    Console.Write("Введите b1: ");
    double b1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите k1: ");
    double k1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите b2: ");
    double b2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите k2: ");
    double k2 = Convert.ToDouble(Console.ReadLine());
    IntersectionPoint(b1, b2, k1, k2);
    
    */