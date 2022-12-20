/*
Задача 64
Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
M = 1; N = 5 -> 2, 4
M = 4; N = 8 -> 4, 6, 8
*/

Console.Clear();

int[] RecursionNumbers(int[] list, int a, int b, int count)
{
    list[count] = a;
    if (a == b)
    {
        return list;
    }
    else
    {
        return RecursionNumbers(list, a + 1, b, count + 1);
    }
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0)
        {
            Console.Write(array[i]);
            Console.Write(" ");
        }
}

Console.WriteLine("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] finalArray = new int[n - m + 1];

finalArray = RecursionNumbers(finalArray, m, n, 0);
ShowArray(finalArray);