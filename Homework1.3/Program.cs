Console.WriteLine("Задача 6");
Console.WriteLine("..........................................................");

Console.Write("Ведите целое число ");
int numberA = Convert.ToInt32(Console.ReadLine());

if (numberA % 2 == 0)
{
    Console.Write("Число " + numberA +" Четное");
}
else
{
    Console.Write("Число " + numberA +" Нечетное");
}