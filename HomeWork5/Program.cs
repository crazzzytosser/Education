/*
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] RandomArray(int size)
{
    int[] newArray = new int[size];
        for (int i = 0; i < size; i++)
        {
            newArray[i] = new Random().Next(100, 1000);
        }
        return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write( array[i] + " ");
Console.WriteLine();
}

int SumNumbers(int[] array)
{
    int current = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            current++;
        }
    }
    return current;
}

Console.Write("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] qwerarray = RandomArray(size);
int result = SumNumbers(qwerarray);

ShowArray(qwerarray);
Console.Write($"В данном массиве количество четных чисел = "+ result);
*/

/*
//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6]-> 0

int[] NewArray(int size, int min, int max)
{
    int[] myArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        myArray[i] = new Random().Next(min, max + 1);
    }
    return myArray;
}

void OutputArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int SumArray(int[] array)
{
   int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    return sum;
} 

Console.Write("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное число элементов массива: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное число элементов массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] qwerarray = NewArray(size, min, max);
int result = SumArray(qwerarray);

OutputArray(qwerarray);
if(size <= 0)
{
    Console.Write("Error!");
}
Console.Write(result);
*/

/*
//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

int[] NewArray(int size, int min, int max)
{
    int[] myArray = new int[size];
    for(int i = 0; i < myArray.Length; i++)
    {
        myArray[i] = new Random().Next(min, max + 1);
    }
    return myArray;
}

void OutputArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

double SumElementsArray(int[] array)
{
    double maxValue = array[0];
    double minValue = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > maxValue)
        {
        maxValue = array[i];
        }
    }
   for(int i = 0; i < array.Length; i++)
   {
        if(array[i] < minValue)
        {
        minValue = array[i];
        }
   }
    
    return maxValue - minValue;
}

Console.Write("Введите размер массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное число элементов массива: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное число элементов массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] res = NewArray(sizeArray, min, max);
double result = SumElementsArray(res);

OutputArray(res);
Console.Write(result);

*/