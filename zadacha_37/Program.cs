// Задача 37: 
// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

int[] array = new int[6];
void GetArray()
{
    for (int i = 0; i < 6; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
    Console.Write("Массив: {0}{1}{2}", "[", String.Join(", ", array), "]");
}
int[] GetMult(int[] arr, int size)
{
    int[] result = new int[size / 2];
    int k = size - 1;
    for (int i = 0; i < size / 2; i++)
    {
        result[i] = arr[i] * arr[k];
        k--;
    }
    return result;
}
GetArray();
int[] multArray = GetMult(array, array.Length);
Console.WriteLine();
Console.Write("Произведение пар: {0}{1}{2}", "[", String.Join(", ", multArray), "]");