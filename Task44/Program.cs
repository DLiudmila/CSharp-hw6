// Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int first = 0;
int second = 1;
int sum = 0;
if (number < 1)
{
    Console.WriteLine("Нет такого числа.");
}
else if(number == 1)
{
    Console.Write("Если N = " + number + "-> 1");
}
else
{
    int i = 2;
    Console.Write("Если N = " + number + "-> 0 1 ");
    while ( i < number)
    {
        sum = first + second;
        Console.Write(sum + " ");
        first = second;
        second = sum;
        i++;

    }
}    
Console.WriteLine();