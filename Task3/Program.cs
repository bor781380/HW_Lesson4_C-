// Задача 3: 
// Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)

int[] arrayGreate(int len, int arrayMin, int arrayMax)
{
    int[] array = new int[len];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(arrayMin, arrayMax);
    }
    return array;
}

int[] arrayContr(int[] array)
{
    int[] arrayContr = new int[array.Length];
    int j=0;
    for(int i = array.Length-1; i >=0; i--)
    {
        arrayContr[j] = array[i];
        j++;
    }
    return arrayContr;
}
void printArray(int[] massiv)
{
    for (int i = 0; i < massiv.Length; i++)
    {
        Console.Write(massiv[i] + " ");
    }
}
Console.Write("Введите количество цифр в массиве :");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное число массива :");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число массива :");
int max = Convert.ToInt32(Console.ReadLine());
int[] array = arrayGreate(size, min, max);
Console.Write("Начальный массив:    ");
printArray(array);
Console.WriteLine();
Console.Write("Перевернутый массив: ");
printArray(arrayContr(array));