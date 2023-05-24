// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int M = ReadInt("Введите число M: ");
int N = ReadInt("Введите число N: ");
if (M < N)
{
    System.Console.WriteLine(SumNumbers(M, N));

}
else
{
    System.Console.WriteLine(SumNumbers(N, M));
}




int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int SumNumbers(int M, int N)
{
    if (M > N)
    {
        return 0;
    }
    return M + SumNumbers(M + 1, N);
}
