int Max(int arg1, int arg2, int arg3)     // ФУНКЦИЯ НАХОЖДЕНИЯ МАКСИМАЛЬГО ИЗ 3 ЧИСЕЛ
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
int a1 = 4;
int b1 = 5;
int c1 = 58;

int a2 = 45;
int b2 = 2423;
int c2 = 3343143;

int a3 = 3434;
int b3 = 123;
int c3 = 124135;

// int max1 = Max (a1, b1, c1);          
// int max2 = Max (a2, b2, c2);                     ТОЖЕ САМОЕ ЧТО И НИЖЕ
// int max3 = Max (a3, b3, c3);
// int max = Max (max1, max2, max3);

int max = Max (
    Max (a1, b1, c1),
    Max (a2, b2, c2),
    Max (a3, b3, c3)
    );
Console.WriteLine(max);

