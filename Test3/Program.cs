// Задайте массив вещественных чисел
// Найдите разницу между min и max элементами в массиве
using static System.Console;
int[] arRay = GetArray(10,1,1000);
WriteLine(string.Join(" ", arRay));
 double max = arRay[0];
 double min = arRay[0];
    for (int i = 0; i < 9; i++)
{
    if (arRay[i] > max)  
    max = arRay[i];
    if (arRay[i] < min) 
    min = arRay[i];          
}
WriteLine($"Разница между максимальным и минимальным значениями: {max} - {min} = {max-min} ");
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for(int i = 0; i < size; i++)
    { 
        result[i] = new Random().Next(minValue,maxValue+1);
    }
    return result;
}
// Не получилось создать массив double, если можно объясните на семинаре)
