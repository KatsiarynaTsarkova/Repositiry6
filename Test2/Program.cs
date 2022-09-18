// Задайте одномерный массив, заполненный случайными числами,
//найдите сумму элементов, стоящих на нечетных позициях
using static System.Console;
int[] arRay = GetArray(7,1,9);
WriteLine(string.Join(" ", arRay));
 
    int sum = 0;
    for (int i = 0; i < arRay.Length; i++)
{
    if(i %2 > 0)
    {
        sum = sum + arRay[i];
    }
}
WriteLine($"Сумма чисел на четных позициях= {sum}");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for(int i = 0; i < size; i++)
    { 
        result[i] = new Random().Next(minValue,maxValue+1);
    }
    return result;
}