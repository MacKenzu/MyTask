void FillArray (int [] collection)
  {
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 1000);
        index++;

    }

  }
void PrintArray (int[] col)
 {
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
 } 

int[] array = new int [100];
FillArray(array);
int index = 1;
int max = array[0];
int min = array[0];
int size = array.Length;
while (index < size)
{   
    if (max < array[index])
        max = array[index];
    else
    {
        if (min > array[index])
            min = array[index];
    }
    index++;
}
Console.WriteLine("===============");
Console.WriteLine($"Max = {max}");
Console.WriteLine("===============");
Console.WriteLine($"Min = {min}");
Console.WriteLine("===============");
PrintArray(array);
