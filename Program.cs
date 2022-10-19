//  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньше
//  a = 5; b = 7 -> max = 7
//   a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
Console.WriteLine("enter number1");
int number_1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("enter number2");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number_1>number2)
{
Console.WriteLine("number_1 max number_2 min");
}
else
{
    Console.WriteLine("number_1min number_2 max");
}