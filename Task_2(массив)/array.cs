// int Max(int arg1, int arg2, int arg3)     // ФУНКЦИЯ НАХОЖДЕНИЯ МАКСИМАЛЬГО ИЗ 3 ЧИСЕЛ
// {
//     int result = arg1;
//     if (arg2 > result) result = arg2;
//     if (arg3 > result) result = arg3;
//     return result;
// }

// int [] array = {12,243,3331,431,455,664,7231,835,9111};

// // int max = Max (
// //     Max (array[0], array[1], array[2]),
// //     Max (array[3], array[4], array[5]),
// //     Max (array[6], array[7], array[8])
// //     );
// Console.WriteLine(max);
// while (size.Len)

int [] array = {1,2,3,4,5,6,6,7,8,9345,345,23,4246,57,234,235,56,24,2,4326,245,246,563,3466,23,426,57,45,72,25,346,3,634,53,52,3};

int size = array.Length;
int find = 3;

int index = 0; 

while(index < size)                 // Поиск значения массива
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    
    index++;
    
}
