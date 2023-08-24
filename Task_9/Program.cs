Console.WriteLine("Введите все значения массива через пробел и нажмите enter");
int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0 )
    {
        count++;
    }
}
Console.WriteLine("["+string.Join(",",array)+"] -> "+count);
