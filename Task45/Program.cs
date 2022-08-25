// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.


const int ARRAY_SIZE = 5; 
const int LEFT_RANGE = -10;
const int RIGHT_RANGE = 10;
int[] arrayFir = FillArray(ARRAY_SIZE, LEFT_RANGE, RIGHT_RANGE);
PrintArray(arrayFir);
// int[] arraySec = ArrayCopy(arrayFir);
int[] arraySec = new int[arrayFir.Length];
CopyArrays(arrayFir, arraySec);
PrintArray(arraySec);


void CopyArrays(int[] arrayF, int[] arrayS)
{
    for (int i = 0; i < arrayF.Length; i ++)
    {
        arrayS[i] = arrayF[i];
    }
}


// int[] ArrayCopy(int[] array)
// {
//     int[] newArray = new int[array.Length];
//     for (int i = 0; i < array.Length; i ++)
//     {
//         newArray[i] = array[i];
//     }
//     return newArray;
// }

int[] FillArray(int size, int leftRange, int rightRange)
{
    Random rand = new Random(); 
    int[] a = new int [size];
    for (int i = 0; i < a.Length; i++)
    {
        a[i] = rand.Next(leftRange,rightRange + 1);
    }
    return a;
}

void PrintArray(int[] array)
{
    int i = 0;
    Console.Write("[");
    while (i < array.Length)
    {
        Console.Write(array[i]);
        if(i != array.Length-1)
        {
            Console.Write(",");
        }
        i++;
    }
    Console.WriteLine("]");
}