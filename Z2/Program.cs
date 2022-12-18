// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3


Console.Write("Введите  число a: ");
int numa = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите  число b: ");
int numb = Convert.ToInt32(Console.ReadLine());

int max = numa;
int min = numb;

if (numa > max) 
{
    max = numa;
    min = numb;
}           
if (numb > max) 
{
    max = numb;
    min = numa;
}
Console.Write("max = ");
Console.WriteLine(max);
Console.Write("min = ");
Console.WriteLine(min);