// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

Console.Write("Введите число M: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > 0 && secondNumber > 0)
{
    int Ackerman(int m, int n)
    {
        if (m == 0) return n + 1;
        if (n == 0) return Ackerman(m - 1, 1);

        return (Ackerman((m - 1), Ackerman(m, n - 1)));
    }

    Console.WriteLine($"Функция Аккермана от чисел {firstNumber} и {secondNumber} --> A({firstNumber}, {secondNumber}) = {Ackerman(firstNumber, secondNumber)}");
}

else Console.WriteLine("Введите целые неотрицательные числа");