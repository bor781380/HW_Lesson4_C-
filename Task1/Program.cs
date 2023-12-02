// Задача 1: 
// Напишите программу, которая бесконечно запрашивает целые числа с консоли. Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.


//void InsertNumber()
//{

static void Function()
{
    while(true)
    {
        Console.WriteLine("Ведите целое число. Чтобы остановить ввод, введите q, или число, сумма цифр которого чётная ");
        string? n = Console.ReadLine();
        
        if (n == "q")
        {
            break;
        }
        bool nNumber = int.TryParse(n, out var number);
        if (nNumber == true)
        { 
            if ((Convert.ToInt32(n)/ 10 + Convert.ToInt32(n)% 10) % 2 == 0)
            {
                break;
            }
        }
    }
}
Function();