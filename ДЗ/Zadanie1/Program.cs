// Максимальное, минимальное число.
/*int max = 0;
int min = 0;
Console.Write("Введите первое число ");
int numbersA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int numbersB = Convert.ToInt32(Console.ReadLine());
if (numbersA > numbersB)
{
    max = numbersA;
    min = numbersB;
} 
else
{
    max = numbersB;
    min = numbersA;
}

Console.Write("Максимальное число ");
Console.WriteLine(max);
Console.Write("Минимальное число ");
Console.WriteLine(min);*/
// Максимальное число
/*int max = 0;
Console.Write("Введите первое число ");
int numbersA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int numbersB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число ");
int numbersC = Convert.ToInt32(Console.ReadLine());
if (numbersA > max) max = numbersA;
if (numbersB > max) max = numbersB;
if (numbersC > max) max = numbersC;
Console.Write("Максимальное число ");
Console.WriteLine(max);*/
// Четное, не четное число
Console.WriteLine("Введите число");
int numbersA = Convert.ToInt32(Console.ReadLine());
if(numbersA % 2 == 0)
{
    Console.Write("Число четное");
}
else
{
    Console.Write("Число не четное");
}