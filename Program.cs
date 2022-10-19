// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4 8 -> 2, 4, 6, 8
Console.WriteLine("enter number");
int number = Convert.ToInt32(Console.ReadLine());
 int numberMin = 2;
while(numberMin <= number)
{
    Console.WriteLine(numberMin);
numberMin= numberMin + 2;
}