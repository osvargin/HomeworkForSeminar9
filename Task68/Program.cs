/*
Задача 68
Задайте значения M и N. Напишите программу, которая найдёт наибольший общий делитель (НОД) этих чисел с помощью рекурсии.
M = 28; N = 7 -> 7
*/

Console.Clear();
int m = 0;
m = InputNumber("наименьшее");
int n = InputNumber("наибольшее");
int nod = m;

System.Console.WriteLine($"Наибольший общий делитель (НОД) для натуральных чисел {m} и {n} - {PrintNOD(m, n, nod)}");

int InputNumber(string str)
{
    while (true)
    {
        Console.Write($"Напишите {str} натуральное число: ");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            if (number > 0 && number > m) 
            {
                return number;                
            }
            else Console.WriteLine($"Некорректно указано {str} натуральное число!");
        }
        else Console.WriteLine($"Некорректно указано {str} натуральное число!");
    }
}

int PrintNOD(int m, int n, int nod)
{
    return n % nod == 0 && m % nod == 0 ? nod : PrintNOD(m, n, nod - 1);    
}
