// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

while (number < 9999 || number > 99999)
{
    Console.Write("Вы ввели неправильное число! Введите пятизначное число: ");
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
