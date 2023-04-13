Console.WriteLine("Введите число в КМ");
int km = Convert.ToInt32 (Console.Read());
Console.WriteLine("Введите число в футах");
int ft = Convert.ToInt32 (Console.Read());
Double ftt = ft * 0.30;
if (km < ftt)
    {
    Console.WriteLine("Растояние в КМ меньше");
    }
else
{
    Console.WriteLine($"Растояние в футах меньше = {ftt}");
}
