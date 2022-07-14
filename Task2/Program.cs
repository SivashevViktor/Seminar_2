// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine($"Наше случайное число = {number}");
int digit1 = number / 100;
int digit2 = number / 10 % 10;
int digit3 = number % 10;
int result = digit1 * 10 + digit3;
Console.WriteLine(result);
//Console.WriteLine($"Третье число = {digit3}");

