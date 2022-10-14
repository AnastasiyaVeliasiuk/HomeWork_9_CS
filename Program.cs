// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке 
// от N до 1. Выполнить с помощью рекурсии.

/*string NewRecursion (int n, int a)
{
    if (n >= a) return $"{n} " + NewRecursion (n - 1, a);
    else return String.Empty;
}

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int a = 1;
Console.WriteLine(NewRecursion(n, a));*/


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в 
// промежутке от M до N.

/*int RecursionSum (int m, int n)
{
    if (m >= n) return m; 
    else return m + RecursionSum(m + 1, n);
}
Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(RecursionSum(m, n));*/


//  Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

/*int RecursionAkkerman (int m, int n)
{
    if (m == 0) 
    {
        return n + 1;
    }
    else if (m > 0 && n == 0) 
    {
        return RecursionAkkerman(m-1, 1);
    }
    else if (m > 0 && n > 0) 
    {   
        return RecursionAkkerman(m-1, RecursionAkkerman(m, n-1));
    }
    return 0;
}
Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(RecursionAkkerman(m, n));*/
