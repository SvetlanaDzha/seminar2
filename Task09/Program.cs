// Программа, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа
// 12 -> 2
// 78 -> 8
// 85 -> 8

//Random rand = new Random();

int number = new Random().Next(10, 100);
Console.WriteLine($"Наше случайное {number} число");
int digit2 = number % 10;
int digit1 = number / 10;
if (digit1 > digit2)
{
    Console.Write(digit1);
}
else
{
    Console.Write(digit2);
}
Console.WriteLine(" - наибольшая цифра");