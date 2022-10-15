/*
//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромоm

bool ThePolindrom(int num)
{
   bool newDigit = true;
   while (num > 9)
   {
    int firstNumber = num;
    int lastNumber = num % 10;
    int count = 0;
        while (firstNumber >= 10)
        {
                firstNumber /= 10;
                count ++;
        }
        if (firstNumber != lastNumber)
        {
                newDigit = false;
                break;
        }
    num = num / 10 % (Convert.ToInt32(Math.Pow(10, count - 1)));
   }
   return newDigit;
}
Console.Write("Введите число: ");
int digit = Convert.ToInt32(Console.ReadLine());
bool nuum = ThePolindrom(digit);
if (nuum)
 Console.WriteLine("Yes!");
 else
 Console.WriteLine("No!");
*/

/*
//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

double FindDistance(double x1, double y1, double z1, double x2, double y2, double z2)
    {
      return Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)), 2);
    }
Console.Write($"Введите координату x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write($"Введите координату y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write($"Введите координату z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write($"Введите координату x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write($"Введите координату y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write($"Введите координату z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Расстояние между точками = {FindDistance(x1, y1, z1, x2, y2, z2)}");
*/

/*
//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

double TheDigit(double num)
{
   if (num <= 0)
   {
      Console.Write("Ошибка!");
   }
   int res = 1;
   while (res <= num)
    {
        Console.Write($"{Math.Pow(res, 3)}");
        if (res < num) 
        Console.WriteLine(" "); 
        res++;
    }
    return res;
}

Console.Write("Введите число: ");
double number = Convert.ToDouble(Console.ReadLine());
double digit = TheDigit(number);
*/