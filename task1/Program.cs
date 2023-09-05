// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] CreateArray()
{
    
    Console.WriteLine("insert the quantity of numbers");
    int M = Convert.ToInt32(Console.ReadLine());
    int[] arr = new int[M];
    for (int i = 0; i < M; i++)
    {
        Console.WriteLine("insert number");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

void printarray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1 ) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]} ");

    }
    Console.Write("]");
}

int countmore0(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]>0)
        {
            count++;
        }
    }
    return count;
}

int[] array = CreateArray();
printarray(array);
Console.WriteLine();
Console.WriteLine($"thera are {countmore0(array)} more than 0");