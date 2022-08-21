Console.WriteLine("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
if (number1 > number2)
{
    Console.WriteLine($"Наибольшее число = {number1}");
    Console.WriteLine($"Наименьшее число = {number2}");
}
else
{
    Console.WriteLine($"Наибольшее число = {number2}");
     Console.WriteLine($"Наименьшее число = {number1}");
}