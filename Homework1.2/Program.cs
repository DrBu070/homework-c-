Console.WriteLine("Задача 4");
Console.WriteLine("..........................................................");

Console.Write("Ведите первое целое число ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите второе целое число ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите третье целое число ");
int numberC = Convert.ToInt32(Console.ReadLine());
int max = numberA;

if (max < numberB);
{
    max = numberB;
}
if (max < numberC);
{
    max = numberC;
}
Console.WriteLine("Максимальным из трех чисел(" + numberA +", " + numberB + ", " + numberC + ") являеться число " + max);