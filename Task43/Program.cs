// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.


Console.WriteLine("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
double x = 0;
double y = 0;
x = (b2 - b1) / (k1 -k2);
y = (k1 * b2 - k2 * b1) / (k1 - k2);
if (k1 == k2)
{
   Console.Write("Прямые параллельны"); 
   if (b1 == b2)
   {
    Console.WriteLine(" и совпадают");
   }
   else
   {
    Console.WriteLine(", но не совпадают");
   }
}
else
{
    Console.WriteLine($"Пересечение в точке: ({x};{y})");
}