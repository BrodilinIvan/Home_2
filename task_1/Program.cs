// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число : ");
string enterNum = Console.ReadLine();
int num = Convert.ToInt32(enterNum);

if (num < 100 || num > 999)
{
    Console.WriteLine($"Введено не трехзначное число : {num}");
}
else 
{
    int hundreds = num / 100;
    int dozens = (num - hundreds*100)/10;
    Console.WriteLine($"Вторая цифра числа : {dozens}");
}
    
