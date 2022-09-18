// Задайте массив, заполненный случайными положительными трехзначными числами. 
//Напишите программу, которая покажет количество четных чисел

using static System.Console;
WriteLine("Введите размер массива, min, max через пробел: ");
int[] parametr = GetParams(ReadLine());
int[] array = GetArray(parametr[0],parametr[1],parametr[2]);
WriteLine(String.Join(" ", array));
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if(array[i] %2==0)
    {
        Write(array[i] + " ");
        count++;
    }
}
WriteLine($"Количество четных чисел= {count}");

int[] GetParams(string inSting)
{
    string[] param = inSting.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int [] result = new int[param.Length];
    for(int i = 0; i < result.Length; i++)
    { 
        result[i] = int.Parse(param[i]);
    }
    return result;
}

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for(int i = 0; i < size; i++)
    { 
        result[i] = new Random().Next(minValue,maxValue+1);
    }
    return result;
}