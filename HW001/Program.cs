// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.WriteLine(
    "Введите координаты точек А(xa,ya,za) и В(xb,yb,zb)");
    Console.WriteLine("A()");
Console.Write("xa = ");
double xa = Convert.ToDouble(Console.ReadLine());
Console.Write("ya = ");
double ya = Convert.ToDouble(Console.ReadLine());
Console.Write("za = ");
double za = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("B()");
Console.Write("xb = ");
double xb = Convert.ToDouble(Console.ReadLine());
Console.Write("yb = ");
double yb = Convert.ToDouble(Console.ReadLine());
Console.Write("zb = ");
double zb = Convert.ToDouble(Console.ReadLine());
//решение
double sumAB=Math.Sqrt(Math.Pow(xb-xa,2)+Math.Pow(yb-ya,2)+Math.Pow(zb-za,2));
Console.WriteLine($"расстояние = {sumAB} ");
Console.ReadLine();