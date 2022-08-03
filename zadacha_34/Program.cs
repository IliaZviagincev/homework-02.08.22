// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] array = new int[5];
void GetArray()
{
    for (int i = 0; i < 5; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    Console.Write("Массив: {0}{1}{2}", "[", String.Join(", ", array), "]");
}
int GetEven(int[] arr)
{
    int count = 0;
    foreach (int i in arr)
    {
        count += (i % 2 == 0) ? 1 : 0;
    }
    return count;
}
GetArray();
Console.WriteLine();
Console.WriteLine($"Четных чисел в массиве: {GetEven(array)}");