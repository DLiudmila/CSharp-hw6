// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.


Console.WriteLine("Введите количество элементов массива: ");
int M = Convert.ToInt32(Console.ReadLine());
int[] array = new int[M];
int count = 0;
for (int i = 0; i < array.Length; i++)
{ 
    Console.WriteLine($"Введите элемент массива под индексом {i}:  ");
    array[i] = Convert.ToInt32(Console.ReadLine());

    if (array[i] > 0)
    {
        count++;
    }
}
 
Console.WriteLine("Кол-во элементов > нуля: " + count);

