Console.Write("Введите первое число: ");
int firstnumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstnumber == secondNumber * secondNumber)
{
    Console.WriteLine("да, " + firstnumber + " является кв. от числа " + secondNumber);
}
else
{
    Console.WriteLine("нет, " + firstnumber + "  не является кв. от числа " + secondNumber);
}