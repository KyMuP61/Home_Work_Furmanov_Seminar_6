/*
 Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3

*/

int GetNumber(string messange)
{
    int result = 0;
    Console.WriteLine(messange);
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Вы не ввели число. Введите число");
        }

    }
    return result;
}



void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}

int[] GetArray(int number)
{
    int result = 0;
    int[] array = new int[5];



    for (int i = 0; i < array.Length; i++)
    {


        array[i] = GetNumber("Enter number");


    }

    return array;
}


int FindPositivNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;

}

int[] array = GetArray(1);
PrintArray(array);
Console.WriteLine();
int result = FindPositivNumbers(array);
Console.WriteLine($"Колличество чисел больше 0  -  {result}");