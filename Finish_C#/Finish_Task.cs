Console.WriteLine("Введите элементы массива через пробел:");
string input = Console.ReadLine();
string[] inputArray = input.Split();

if (inputArray.Length > 0)
{
    string[] newArray = inputArray.Where(element => element.Length <= 3).ToArray();

    if (newArray.Length > 0)
    {
        Console.WriteLine("Новый массив, состоящий из строк, длина которых меньше или равна 3:");
        string arrayAsString = $"[{string.Join(", ", newArray.Select(element => $"\"{element}\""))}]";
        Console.WriteLine(arrayAsString);
    }
    else
    {
        Console.WriteLine("Нет элементов, удовлетворяющих условию.");
    }
}
else
{
    Console.WriteLine("Введенный массив пуст.");
}
