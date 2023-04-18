// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());
int temp = 1;

for (int i = 1; i<=num; i++)
{
    temp=temp*i;
}
Console.WriteLine(temp);