// Задача 25 Напишите цикл, который принимает  на вход два числа (А и В)
// возводит число А в натуральную степень В

Console.WriteLine("введите число A");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число B");
int b = Convert.ToInt32(Console.ReadLine());
int step = a;

for (int i = 1; i < b; i++)
{
step = step * a;
}
Console.WriteLine("A в степени B равно: " + step);


// Задача 27 Напишите программу , которая принимает на вход число и выдает
// сумму цифр  в числе


Console.WriteLine("введите число");
int index = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (index > 0)
{
int num = index % 10;
index = index / 10;
sum = sum + num;
}
Console.WriteLine("сумма всех цифр в числе равна: " + sum);



// Задача 29 Напишите программу, которая задает массив из 8 элементов
// и выводит их на экран


int [] numbers = new int[8];
Console.Write("[");

for (int i = 0; i < numbers.Length; i++)
 {
    numbers [i] = new Random().Next(0, 11);
    Console.Write(" " + Method (i) + " ");
 }
Console.Write("]");


int Method (int a)
{
    return numbers[a];
}    


