// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.WriteLine("Введите трехзначное число : ");
// string enterNum = Console.ReadLine();
// int num = Convert.ToInt32(enterNum);

// if (num < 100 || num > 999)
// {
//     Console.WriteLine($"Введено не трехзначное число : {num}");
// }
// else 
// {
//     int hundreds = num / 100;
//     int dozens = (num - hundreds*100)/10;
//     Console.WriteLine($"Вторая цифра числа : {dozens}");
// }





// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
//32679 -> 6

// Console.WriteLine("Ведите число : ");
// int num = Convert.ToInt32(Console.ReadLine());
// int num_temp = num;
// int index_max = 1;
// int index_temp = 0;

// while (num_temp > 9)
// {
//     num_temp = num_temp / 10;
//     index_max = index_max + 1;
// }
// Console.WriteLine($"Введите индекс числа с левой стороны, не превышающий число {index_max}: ");
// int index = Convert.ToInt32(Console.ReadLine());
// if (index > index_max)
// {
//     Console.WriteLine("Такой цифры нет!!!");
// }
// else
// {
//      index_temp = index_max - index;
//      double res = num / Math.Pow(10, index_temp);
//      res = Math.Truncate(res);
     
// while (res > 9)
// {
//      res = res - 10;
// }

// Console.WriteLine($"Данному индексу {index}, соответствует число {res}");
// }





// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// Console.WriteLine("Ведите число : ");
// int indexday = Convert.ToInt32(Console.ReadLine());
// if (indexday >= 1 & indexday <= 5) 
// {
//     Console.WriteLine("Рабочий день");
// }
// else if (indexday == 6 || indexday == 7)
// {
//     Console.WriteLine("Выходной день");
// }
// else
// {
//     Console.WriteLine("Такого дня недели еще не придумали)))");
// }




