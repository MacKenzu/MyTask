// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void FillArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
        {
            array [i] = new Random().Next(100);
        }
}
int sum(int [] array )
{
 int max = 0;
 int min = 0;
 for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        else (array[i] < min)
        {
            min = array[i];
        }
        int result = max - min;
        return result;
    }

}
int [] myArray = new int [new Random().Next(20)];
FillArray(myArray);
Console.WriteLine("["+ String.Join(",", myArray)+ "]");
Console.WriteLine(sum(myArray));