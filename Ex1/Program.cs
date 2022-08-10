// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
int n = Math.Abs ((number) % 100) / 10;
Console.WriteLine(n);

//Решение задачи через строки
//string str_number = Math.Abs (number).ToString();
//char dig1 = str_number[1];
//Console.WriteLine(dig1);345
