/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
 которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2


int [] RandomMassiv (int size, int minValue, int maxValue)
{
    int [] newArray = new int [size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue+1);
    }
    return newArray;
}
 void ShowArray (int[] array)
 {
    Console.Write("Massiv -> ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
     Console.WriteLine();
 }
 void Chet (int [] array)
 {
    int sumchet = 0;
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j] %2 == 0) 
        sumchet = sumchet + 1;
    }
    Console.WriteLine($"количество четных чисел = {sumchet}");  
 }
 
 Console.WriteLine("Введите размер массива");
 int a = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("Введите минимальный элемент");
 int min = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("Введите максимальный элемент");
 int max = Convert.ToInt32(Console.ReadLine());
 int[] myArray = RandomMassiv(a, min, max);
 
 ShowArray(myArray); 
 Chet(myArray);
 */

 /*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/
/*
int [] RandomMassiv (int size, int minValue, int maxValue)
{
    int [] newArray = new int [size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue+1);
    }
    return newArray;
}
 void ShowArray (int[] array)
 {
    Console.Write("Massiv -> ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
     Console.WriteLine();
 }

void Sum(int[] array)
{
    int sum = 0;

    for (int j = 1; j < array.Length; j= j+2)
    {
        sum = sum +array[j];

    }
    Console.WriteLine($"cумма чисел = {sum}");
}

 Console.WriteLine("Введите размер массива");
 int a = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("Введите минимальный элемент");
 int min = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("Введите максимальный элемент");
 int max = Convert.ToInt32(Console.ReadLine());
 int[] myArray = RandomMassiv(a, min, max);
 
 ShowArray(myArray); 
 Sum(myArray);
 */

 /*
 Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/
int [] RandomMassiv (int size, int minValue, int maxValue)
{
    int [] newArray = new int [size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue+1);
    }
    return newArray;
}
 void ShowArray (int[] array)
 {
    Console.Write("Massiv -> ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
     Console.WriteLine();
 }

 void Diff(int[] array)
 {
   int diff = 0;
   int min = array[0];
   int max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
        if (array[i] > max) max = array[i];
    }
    diff = max - min;
    Console.Write($"{max} - {min} = {diff}");
 }
 Console.WriteLine("Введите размер массива");
 int a = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("Введите минимальный элемент");
 int min = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("Введите максимальный элемент");
 int max = Convert.ToInt32(Console.ReadLine());
 int[] myArray = RandomMassiv(a, min, max);
 
 ShowArray(myArray); 
 Diff(myArray);