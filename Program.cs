// Console.Write("Введите первое число: ");
// int firstnumber = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());

// if (firstnumber == secondNumber * secondNumber)
// {
    // Console.WriteLine("да, " + firstnumber + " является кв. от числа " + secondNumber);
// }
// else
// {
    // Console.WriteLine("нет, " + firstnumber + "  не является кв. от числа " + secondNumber);
// }

// Задание 2. 
// Семинар 1. Знакомство с языками программирования
// Напишите программу, которая на вход принимает
// целое число N, а на выходе показывает все целые
// числа в промежутке от -N до N.
// Примеры
// 4 => -4, -3, -2, -1, 0, 1, 2, 3, 4
// 2 => -2, -1, 0, 1, 2

 Console.Write("Введите число N ");
int N = Convert.ToInt32(Console.ReadLine());
// N = 4
if (N < 0) // как нам из -5 сделать 5? умножаем -5 на -1 (-5 * -1 = 5)
{
    Console.Write("Введено отрицательное число N ");
    N = N * -1; 
}
int negativeN = N * -1; // -4

while (negativeN <= N) // -3 -2 -1 0 1 2 3 (3 = negativeN <= N)
{
Console.Write(negativeN + " ");
negativeN++; // negativeN = negativeN + 1
}

// int a = 10;
//a--; (Декремент) / a = a - 1












