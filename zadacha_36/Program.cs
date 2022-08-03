// Задача 36: 
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

int[] array = new int[5];
void GetArray()
{
    for (int i = 0; i < 5; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
    Console.Write("Массив: {0}{1}{2}", "[", String.Join(", ", array), "]");
}
int GetOdd(int[] arr)
{
    int result = 0;
    foreach (int i in arr)
    {
        result += (i % 2 == 0) ? 0 : i;
    }
    return result;
}
GetArray();
Console.WriteLine();
Console.WriteLine($"Сумма нечентных чисел в массиве:  {GetOdd(array)}");