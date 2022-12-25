/* Задача 19
Напишите программу, которая принимает на 
вход пятизначное число и проверяет, является 
ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

int getUserValues(string massage)     //Функция ввода данных
{
    Console.WriteLine(massage);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}
int number = getUserValues("введите число");
int num = number;
int temp = 0; 
    while (number > 0)
     {
        temp = temp * 10 + number % 10; 
        number = number / 10;
     }
    Console.WriteLine(num == temp ? $"Число {num} -палиндром" : $"Число {num} -не палиндром");
    
   