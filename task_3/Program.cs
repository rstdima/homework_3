// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.Write("Введите пятизначное число: ");
string? number = Convert.ToString(Console.ReadLine()); // записываем число в переменную number

char[] rev = number.ToCharArray(); // создаем массив  .ToCharArray - конвертируем текст
Array.Reverse(rev);// переворачиваем массив

string stringrev = new string(rev); // создаем новую строку для сравнения введенного числа 

if (number == stringrev) {
   Console.Write("да");
} else {
   Console.Write("нет");
}
