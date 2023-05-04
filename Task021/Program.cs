// Задача №21
// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.
// А(3, 6, 8); В(2, 1, -7) -> 15.84
// A(7, -5, 0); B(1, -1, 9) -> 11.53
Console.Write("\n Введите координату x1 точки А: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("\n Введите координату y1 точки A: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("\n Введите координату z1 точки A: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("\n Введите координату x2 точки B: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("\n Введите координату y2 точки B: ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.Write("\n Введите координату z2 точки B: ");
int z2 = Convert.ToInt32(Console.ReadLine());

int squareX = (x2 - x1)*(x2 - x1);
int squareY = (y2 - y1)*(y2 - y1);
int squareZ = (z1 - z2)*(z1 - z2);

double lenth = Math.Sqrt(squareX + squareY + squareZ);
Console.WriteLine($"Расстояние между точками A и B = {(lenth):F2}");