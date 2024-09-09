using System;

namespace project;


class Program
{
    static void CartesianToPolar(double x, double y, int precision)
    {
        double r = Math.Sqrt(x * x + y * y);
        double phi = Math.Atan2(y, x);
        Console.WriteLine($"ρ = {Math.Round(r, precision)}, φ = {Math.Round(phi, precision)} rad");
    }

    static void PolarToCartesian(double r, double phi, int precision)
    {
        double x = r * Math.Cos(phi);
        double y = r * Math.Sin(phi);
        Console.WriteLine($"x = {Math.Round(x, precision)}, y = {Math.Round(y, precision)}");
    }

    static void CartesianToSpherical(double x, double y, double z, int precision)
    {
        double r = Math.Sqrt(x * x + y * y + z * z);
        double theta = Math.Acos(z / Math.Sqrt(x * x + y * y + z * z));
        double phi = Math.Atan(y / x);
        Console.WriteLine($"ρ = {Math.Round(r, precision)}, θ = {Math.Round(theta, precision)}, " +
                          $"φ = {Math.Round(phi, precision)}");
    }

    static void SphericalToCartesian(double r, double theta, double phi, int precision)
    {
        double x = r * Math.Sin(theta) * Math.Cos(phi);
        double y = r * Math.Sin(theta) * Math.Sin(phi);
        double z = r * Math.Cos(theta);
        Console.WriteLine($"x = {Math.Round(x, precision)}, y = {Math.Round(y, precision)}, " +
                          $"z = {Math.Round(z, precision)}");
    }

    static void CartesianToСylindrical(double x, double y, double z, int precision)
    {
        double r = Math.Sqrt(x * x + y * y);
        double phi = Math.Atan(y / x);
        Console.WriteLine($"ρ = {Math.Round(r, precision)}, φ = {Math.Round(phi, precision)}, " +
                         $"z = {Math.Round(z, precision)}");
    }

    static void СylindricalToCartesian(double r, double phi, double z, int precision)
    {
        double x = r * Math.Cos(phi);
        double y = r * Math.Sin(phi);
        Console.WriteLine($"x = {Math.Round(x, precision)}, y = {Math.Round(y, precision)}, " +
                          $"z = {Math.Round(z, precision)}");
    }

    static void Main()
    {
        Console.WriteLine("Выберите опцию: \n1 - из декартовых координат в полярные \n" +
                          "2 - из полярных координат в декартовые \n" +
                          "3 - из декартовых в сферические \n" +
                          "4 - из сферических в декартовы \n" +
                          "5 - из декартовых в цилиндрические \n" +
                          "6 - из цилиндрических в декартовы");
        int choice = int.Parse(Console.ReadLine());
        double x, y, z, r, theta, phi;
        int precision;

        switch (choice)
        {
            case 1:
                Console.Write("Коордианата x = ");
                x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Коордианата y = ");
                y = Convert.ToDouble(Console.ReadLine());
                Console.Write("Точность = ");
                precision = Convert.ToInt32(Console.ReadLine());
                CartesianToPolar(x, y, precision);
                break;

            case 2:
                Console.Write("ρ = ");
                r = Convert.ToDouble(Console.ReadLine());
                Console.Write("θ = ");
                phi = Convert.ToDouble(Console.ReadLine());
                Console.Write("Точность = ");
                precision = Convert.ToInt32(Console.ReadLine());
                PolarToCartesian(r, phi, precision);
                break;

            case 3:
                Console.Write("Коордианата x = ");
                x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Коордианата y = ");
                y = Convert.ToDouble(Console.ReadLine());
                Console.Write("Коордианата z = ");
                z = Convert.ToDouble(Console.ReadLine());
                Console.Write("Точность = ");
                precision = Convert.ToInt32(Console.ReadLine());
                CartesianToSpherical(x, y, z, precision);
                break;
            case 4:
                Console.Write("ρ = ");
                r = Convert.ToDouble(Console.ReadLine());
                Console.Write("θ = ");
                theta = Convert.ToDouble(Console.ReadLine());
                Console.Write("φ = ");
                phi = Convert.ToDouble(Console.ReadLine());
                Console.Write("Точность = ");
                precision = Convert.ToInt32(Console.ReadLine());
                SphericalToCartesian(r, theta, phi, precision);
                break;
            
            case 5:
                Console.Write("Коордианата x = ");
                x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Коордианата y = ");
                y = Convert.ToDouble(Console.ReadLine());
                Console.Write("Коордианата z = ");
                z = Convert.ToDouble(Console.ReadLine());
                Console.Write("Точность = ");
                precision = Convert.ToInt32(Console.ReadLine());
                CartesianToСylindrical(x, y, z, precision);
                break;
            case 6:
                Console.Write("ρ = ");
                r = Convert.ToDouble(Console.ReadLine());
                Console.Write("θ = ");
                theta = Convert.ToDouble(Console.ReadLine());
                Console.Write("z = ");
                z = Convert.ToDouble(Console.ReadLine());
                Console.Write("Точность = ");
                precision = Convert.ToInt32(Console.ReadLine());
                СylindricalToCartesian(r, theta, z, precision);
                break;
        }
    }
}