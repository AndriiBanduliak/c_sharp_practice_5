/* Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
Найдите сумму отрицательных и положительных элементов массива*/

using static System.Console;
Clear();

int[] Massive = new int[12];
int summax = 0;
int summin = 0;

for (int i = 0; i < Massive.Length; i++)
{
    Massive[i] = new Random().Next(-9, 10);
}

WriteLine(String.Join(", ", Massive));


for (int j = 0; j < Massive.Length; j++)
{
    if (Massive[j] >= 0)
    {

        summax = summax + Massive[j];
    }
    else summin = summin + Massive[j];
}

WriteLine($"Сумма положительных элементов массива равна: {summax}");
WriteLine($"Сумма отрицательных элементов массива равна: {summin}");