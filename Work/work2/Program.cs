// Напишите программу, которая выводит третью 
// цифру заданного числа или сообщает, 
// что третьей цифры нет.


System.Console.WriteLine("Введите число:");
int numberA = Convert.ToInt32(Console.ReadLine()); 
int N = numberA.ToString().Length;
if (N < 3)
{
    System.Console.WriteLine("Третьей цифры нет");
}
else
{
    int A = N - 3;
    int result = numberA / (Convert.ToInt32(Math.Pow(10, A))) % 10;
    System.Console.WriteLine(result);
}
