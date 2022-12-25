/*Задача 23
Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

int getUserValues(string massage)     //Функция ввода данных
{
    Console.WriteLine(massage);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}
void Cube(int number)     // функция вычисления куба чисел от 1 до N
{
    for (int i = 1; i <= number; i++)
    { 
       int cube =  i * i * i;
       Console.Write($"{cube} ");
    }
}
int N = getUserValues("Введите число N ");
Cube(N);