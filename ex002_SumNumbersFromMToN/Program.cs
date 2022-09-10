// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число M: ");
int startNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int endNumber = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int startNumber, int endNumber)
{
    if (startNumber == endNumber) return startNumber;

    return (startNumber + SumNumbers(startNumber + 1, endNumber));
}

Console.WriteLine($"Сумма чисел от {startNumber} до {endNumber} --> {SumNumbers(startNumber, endNumber)}");