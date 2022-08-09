// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
string str_number = number.ToString();
char dig1 = str_number[1];
Console.WriteLine(dig1);