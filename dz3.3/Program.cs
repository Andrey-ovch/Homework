// Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве

double Dist(double[] a, double[] b)
{
    double da = Math.Pow(a[0] - b[0], 2);
    double db = Math.Pow(a[1] - b[1], 2);
    double dc = Math.Pow(a[2] - b[2], 2);
    return Math.Sqrt(da + db + dc);
}
double[] x = {5, -7, 9};
double[] y = {43, -6, 32};
Console.WriteLine($"distance = {Dist(x, y)}");