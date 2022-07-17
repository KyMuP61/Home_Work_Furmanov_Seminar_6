/*

Напишите программу, которая найдёт точку пересечения двух прямых,
 заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
 значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)_ * опечатка в варинате

*/
//  x=(b2-b1)/(k1-k2) , y=k1(b2-b1)/(k1-k2)+b1
//  k2 * x + b2 =  k1 * x + b1


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


// int b1 = GetNumber("Enter b1: ");
// int k1 = GetNumber("Enter k1: ");
// int b2 = GetNumber("Enter b2: ");
// int k2 = GetNumber("Enter k2: ");

double b1 = 2;
double k1 = 5;
double b2 = 4;
double k2 = 9;



double x = (b2-b1)/(k1-k2);
double y = k1*(b2-b1)/(k1-k2)+b1;


if ( x == y)
Console.WriteLine($"прямые пересекаются в точке ({x}, {y})");
else
Console.WriteLine($"прямые не пересекаются");



