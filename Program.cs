
using static System.Console;
Clear();

int[] array = GetArray(6);
WriteLine($"{String.Join(" ", array)}");

WriteLine("Введите число которое вы хотите проверить на наличие в массиве: ");
int number = Int32.Parse(ReadLine());

bool result = FindElement(array, number);
WriteLine($"Наличие заданного элемента в массиве: {result}");


bool FindElement(int[] array, int element)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == element)
        {
            return true;
        }
    }
     return false;

}

int[] GetArray(int L)
{
    int[] result = new int[L];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(-9, 10);
    }

    return result;
}