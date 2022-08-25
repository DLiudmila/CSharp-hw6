// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// (использовать рекурсию)


Console.WriteLine("Введите число: ");
int Num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(GetFactorial(Num));


int GetFactorial(int n)
{
    if (n == 1 || n == 0)
    { 
        return 1;
    }
    else 
    {
        return n * GetFactorial(n - 1);
    }
}