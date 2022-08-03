// Задача 38: 
// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] array = new double[6];
void GetArray()
{
    for (int i = 0; i < 6; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
    Console.WriteLine("Массив: {0}{1}{2}", "[", String.Join(", ", array), "]");
}
double getMinMax(double[] arr)
{
    double max = arr[0];
    double min = arr[0];
    foreach (int i in arr)
    {
        max = (i > max) ? i : max;
        min = (i < min) ? i : min;
    }
    Console.WriteLine($"min - {min} \nmax - {max}");
    return max - min;
}
GetArray();
Console.WriteLine($"разница между максимальным и минимальным составляет: {getMinMax(array)}");
