// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

System.Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int st = 1;
System.Console.WriteLine(PrintNumbers(N, st));

string PrintNumbers(int N, int st)
{
    if(N == st)
    {
        return N.ToString();
    }
    return (N + " " + PrintNumbers(N - 1, st));
}
