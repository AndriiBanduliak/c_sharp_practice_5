using static System.Console;
Clear();
WriteLine("Введите колличество элементов массива: ");
int numb = Convert.ToInt32(ReadLine());
int[] mass = GetArray(numb);
WriteLine($"{String.Join(" ", mass)}");
int[] massSum = GetSum(mass);
WriteLine($"{String.Join(" ", massSum)}");






int[] GetArray(int L)
{
    int[] result = new int[L];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(0, 10);
    }

    return result;
}

int[] GetSum(int[] array)
{
    int length = array.Length % 2 == 0 ? array.Length / 2 : array.Length / 2 + 1;
    int[] ArraySum = new int[length];
for (int i = 0; i < ArraySum.Length; i++)
{
   if (array[i]!=array[(array.Length-1)-i])
   {
     ArraySum[i]=array[i]*array[(array.Length-1)-i];
   }
   else
   {
    ArraySum[i]=array[i];
   }
}
    return ArraySum;
}