// Задача 64: Задайте значения M и N. Напишите программу,
// которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

Console.Write("Введите число M: ");
int startNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int endNumber = Convert.ToInt32(Console.ReadLine());

string PrintNumbers(int startNumber, int endNumber)
{
    if (startNumber == endNumber) return startNumber.ToString();

    return (startNumber + ", " + PrintNumbers(startNumber + 1, endNumber));
}

Console.WriteLine($"Числа от {startNumber} до {endNumber}: {PrintNumbers(startNumber, endNumber)}");

