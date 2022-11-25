
using static System.Console;
Clear();

int[] mas = GetArray(123);
WriteLine($"{String.Join(" ", mas)}");
WriteLine($"Количество элементов на отрезке {GetCountNumber(mas, 10, 99)}");


int[] GetArray(int l)
{
    int[] result = new int[l];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(-150, 121);
    }
    return result;
}

int GetCountNumber(int[] array, int minCount, int maxCount)
{
    int count = 0;
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j] >= minCount && array[j] <= maxCount)
        {
            count += 1;
        }
    }
    return count;
}
