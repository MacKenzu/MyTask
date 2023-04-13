// С начала суток часовая стрелка повернулась на y градусов (0 ≤ y ≤ 360, y — вещественное число). 
// Определить число полных часов и число полных минут, прошедших с начала суток.
Console.WriteLine("Введите градусы: ");
double Radian = Convert.ToDouble(Console.ReadLine());
double OneMinutRad = 0.5;                  
double TimeMinut1 = Radian / OneMinutRad;        // Общее количество минут 
int TimeMinut = Convert.ToInt32(TimeMinut1);
int Time = TimeMinut / 60;                       // Количество часов 
int RealTime = Time * 60;
int Minut = TimeMinut - RealTime;
Console.WriteLine(Time+ " часов");
Console.WriteLine(Minut+ " минут");























// 1 час = 30 градусов
// 1 минута = 0.5 градуса 