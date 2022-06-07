/*
29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int[] getRandomArray(int length)
{
    int[] res = new int[length];
    for (var i = 0; i < length; i++)
    {
        res[i] = new Random().Next(0, 10);
    }
    return res;
}

void printArray(int[] arrayToPrint)
{
    Console.Write("[");
    for (var i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(arrayToPrint[i]);
        if (i != arrayToPrint.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

int[] randomArray = getRandomArray(8);
printArray(randomArray);
