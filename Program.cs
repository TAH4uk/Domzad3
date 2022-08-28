// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите положительное пятизначное число: ");
int number = int.Parse(Console.ReadLine());

while (number < 9999 || number > 99999)
{
    Console.Write("Вы ввели неправильное число! Введите положительное пятизначное число: ");
    number = int.Parse(Console.ReadLine());
}

string result = number.ToString();
int result0 = result[0];
int result1 = result[1];
int result3 = result[3];
int result4 = result[4];

if (result0 == result4 & result1 == result3)
{
    Console.WriteLine($"Число {number} является полиндромом");
}
else
{
    Console.WriteLine($"Число {number} НЕ является полиндромом");
}

// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.Write("Введите координату X1: ");
double x1 = double.Parse(Console.ReadLine());
Console.Write("Введите координату Y1: ");
double y1 = double.Parse(Console.ReadLine());
Console.Write("Введите координату Z1: ");
double z1 = double.Parse(Console.ReadLine());
Console.Write("Введите координату X2: ");
double x2 = double.Parse(Console.ReadLine());
Console.Write("Введите координату Y2: ");
double y2 = double.Parse(Console.ReadLine());
Console.Write("Введите координату Z2: ");
double z2 = double.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow ((x2 - x1), 2) + Math.Pow ((y2 - y1), 2) + Math.Pow ((z2 - z1), 2));

Console.WriteLine($"Расстояние между двумя точками с координатами ({x1}, {y1}, {z1}) и ({x2}, {y2}, {z2}) равно {result}");

// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите положительное число N: ");
int N = int.Parse(Console.ReadLine());

while (N < 0)
{
    Console.Write("Вы ввели неправильное число! Введите положительное число N: ");
    N = int.Parse(Console.ReadLine());
}

for (int i = 1; i <= N; i++)
{
    Console.Write($"{i * i * i}, ");
}