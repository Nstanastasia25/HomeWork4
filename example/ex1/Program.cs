// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// int A = 2;
// int B = 3;
// int C = Convert.ToInt32(Math.Pow(A, B));
// System.Console.WriteLine(C);

int Exponentiation(int numberA, int numberB) //Создание массива
{
    int result = 1;
    for (int i = 1; i <= numberB; i++)
    {
        result = result * numberA;
    }
    return result;
}

Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int exponentiation = Exponentiation(numberA, numberB);
Console.WriteLine("Ответ: " + exponentiation);