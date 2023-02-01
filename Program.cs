//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
//в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите целое число N: ");
int numberN = int.Parse(Console.ReadLine() ?? "");

Console.Write($"N = {numberN} -> ");

ShowNumbers(numberN, 1);

void ShowNumbers(int lastNum, int firstNum)
{
    if (lastNum >= firstNum)
    {
        Console.Write(lastNum);
        if (lastNum > firstNum) Console.Write(", ");
        ShowNumbers(lastNum - 1, firstNum);
    }
}