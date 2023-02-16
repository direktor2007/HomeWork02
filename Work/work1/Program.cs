// Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа.

Random rand = new Random ();
int number =  new Random().Next (100, 1000);
System.Console.WriteLine($"Случайное число:{number}");

//System.Console.WriteLine($"{number / 100}{number % 10}");
number = ((number % 100)) - (number % 10);

System.Console.WriteLine($"{number}");




