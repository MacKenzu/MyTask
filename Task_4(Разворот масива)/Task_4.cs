void FillArray (int [] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
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

void ReverseArray (int [] myArray)
{
    int size = myArray.Length/2-1;
    int index = 0;
    int qwe = 0;
    while (index <= size)
    {
        qwe = myArray[index];
        myArray[index] = myArray[myArray.Length-index-1];
        myArray[myArray.Length-index-1] = qwe;
        index++;
    }
}
    

int [] array = new int [10];
FillArray(array);
PrintArray(array);

Console.WriteLine("===============");

ReverseArray(array);
PrintArray(array);
