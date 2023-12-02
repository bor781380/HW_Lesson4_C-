// Задача 2: 
// Задайте массив заполненный случайными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] arrayGreate(int len, int arrayMin, int arrayMax)
{
    int[] array = new int[len];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(arrayMin, arrayMax);
        Console.Write(array[i] + " ");
    }
    return array;
}

int scoreEven(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i]%2 == 0)
        {
            count ++;
        }
    }
    return count;
}
Console.Write("Введите количество цифр в массиве :");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное число массива :");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число массива :");
int max = Convert.ToInt32(Console.ReadLine());
int[] array = arrayGreate(size, min, max);
Console.Write("Количество четных чисел в массиве :" + scoreEven(array));