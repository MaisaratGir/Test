// Задача 6. Напишите программу, которая принимает на вход
// число и выдает, является ли число четным

Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine("Четное число");
}
else
{
    Console.WriteLine("Нечетное число");
}


// Задача 8. Нфпишите программу, которая на вход принимает число (N),
// а на выходе показывает все четные числа от 1 до N


Console.Clear();
Console.Write("Введите N: ");
int N = int.Parse(Console.ReadLine());

int i = 1;
while (i <= N)
{
    if (i % 2 == 0)
    {
        Console.Write($"{i} ");
    }
    i++;
}
Console.WriteLine();


// Задача 4. Напишите программу, которая принимает на вход
// три числа и выдает максимальное из этих чисел

Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int number3 = int.Parse(Console.ReadLine());

int max = number1;
if (max < number2)
{
    max = number2;
}
if (max < number3)
{
    max = number3;
}

Console.WriteLine($"максимальное число = {max}");




// Задача 2. Напишите программу, которая на в ход принимает 2 числа  и выдает, 
//  какое число больше, какое меньше. 



Console.Write("Введите num 1 : ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите num 2 : ");
int num2 = int.Parse(Console.ReadLine());

if (num1 > num2)
   Console.WriteLine("number 1 больше numder 2");
else if (num1 < num2)
      Console.WriteLine("num 2 больше num 1");

else
      Console.WriteLine("num 1 равно num 2");
      



    




