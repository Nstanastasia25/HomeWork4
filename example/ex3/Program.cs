// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.


int[] CreateArray(int count)//-Создание массива 
{
    int[] result = new int[count];
    return result;
}
// -заполнить массив => два способа
void FillRandomArray(int[] array, int min, int max)
{
    int len = array.Length;
    for (int i = 0; i < len; i++)
    {
        System.Console.Write($"array[{i}]: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}
// второй способ
void FillArrayFromConsole(int[] array, int min, int max)

{
    int len = array.Length;
    for (int i = 0; i < len; i++)
    {
        System.Console.Write($"array[{i}]: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}
// - инверсия
int[] Inverse(int[] array)
{
    int len = array.Length;
    int[] result = new int[len];

    for (int i = 0; i < len; i++)
    {
        result[i] = array[i];
    }
    return result;
}
// -печать массива в консоль

void PrintArray(int[] array)
{
    int len = array.Length;
    for (int i = 0; i < len; i++)
    {
        Console.Write($"{array[i]}: ");
    }
    Console.WriteLine();
}

string ConvertArrayToString(int[] array)
{
    int len = array.Length;
    string result = String.Empty;
    for (int i = 0; i < len; i++)
    {
        result +=$"{array[i]}:";
    }
    return result;
}

int[] inArr = CreateArray(8);
FillRandomArray(inArr, 0, 8);
string outStr = ConvertArrayToString(inArr);
Console.WriteLine(outStr);
File.WriteAllText("file.txt", outStr);
int[] outArr = Inverse(inArr);
outStr= ConvertArrayToString(outArr);
Console.WriteLine(outStr);
File.WriteAllText("fileout.txt", outStr);