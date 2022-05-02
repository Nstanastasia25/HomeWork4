//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int SumNumber(int numberN)
{

    int length = Convert.ToString(numberN).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < length; i++)
    {
        advance = numberN - numberN % 10;
        result = result + (numberN - advance);
        numberN = numberN / 10;
    }
    return result;
}

int sumNumber = SumNumber(numberN);
Console.WriteLine("Сумма цифр в числе: " + sumNumber);

