/* Задача 21
Напишите программу, которая принимает 
на вход координаты двух точек и находит расстояние 
между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

 int getUserValue(string massage)
{
    Console.WriteLine(massage);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

double getLengthAB(double x1, double x2, double y1, double y2, double z1, double z2)
    {
       double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
       return result;
    }

int x1 = getUserValue("Введите x для точки А: ");
int y1 = getUserValue("Введите y для точки А: ");
int z1 = getUserValue("Введите z для точки А: ");
int x2 = getUserValue("Введите x для точки B: ");
int y2 = getUserValue("Введите y для точки B: ");
int z2 = getUserValue("Введите z для точки B: ");

double LengthAB =  Math.Round (getLengthAB(x1, x2, y1, y2, z1, z2), 2 );
Console.WriteLine(LengthAB);
