// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
string str_number = Math.Abs(number).ToString();
if (str_number.Length > 2)
{
Console.WriteLine(str_number[2]);
}
else
{
  Console.WriteLine("Третьей цифры нет");  
}

