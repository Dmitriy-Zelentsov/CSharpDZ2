// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
int [] array = {1,2,3,4,5,6,7};
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if(number == array[5]||number == array[6])
{
   Console.WriteLine("Да,это выходной день");
}
else if(number < 1 || number > 7)
{
     Console.WriteLine("Не соответствует требованию");
}
else
{
     Console.WriteLine("Нет,это не выходной день");
}
