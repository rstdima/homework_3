// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите x1: ");
double x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите x2: ");
double x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите y1: ");
double y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите y2: ");
double y2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите z1: ");
double z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите z2: ");
double z2 = Convert.ToInt32(Console.ReadLine());

double rez = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1 ), 2));
Console.WriteLine(rez);


// Формула для нахождения расстояния между двумя точками A(xa, ya, za) и B(xb, yb, zb) в пространстве: {d=\sqrt{{(x_b — x_a)}^2 + {(y_b — y_a)^2} + {(z_b — z_a)^2}}}, где xa, ya и za — координаты первой точки A, xb, yb и zb — координаты второй точки B
