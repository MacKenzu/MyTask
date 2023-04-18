// Демонстрация решения
// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36
Console.WriteLine("Введите число");
int num = Convert.ToInt32 (Console.ReadLine());
int Getsum()
{
    int sum = 0;
    int count = 0;
    while (num > count)
    {
        count++;
        sum+= count;
        
    }
    return sum;
}

Console.WriteLine(Getsum());