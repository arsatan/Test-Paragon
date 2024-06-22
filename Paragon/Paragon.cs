using static System.Math;

namespace Paragon
{
    public abstract class Area
    {
        public double GetArea(double r)
        {
            const double pi = PI;
            return pi*Pow(r, 2);
        }
    }

    public class AreaOnSides : Area
    {
        double a = 10;
        double b = 10;
        double c = 10;
        public double AreaOnSidesCalc()
        {
            double p = (a+b+c​)/2;
            double s = Sqrt(p*(p-a)*(p-b)*(p-c));
            return s;
        }
    }
    public class Triangle90 : AreaOnSides
    {
        public static string IsTriangle90(double a, double b, double c)
        {
            if ((a*a+b*b == c*c) || (a*a+c*c == b*b) || (c*c+b*b == a*a))
                return "да";
            else return "нет";
        }
    }
}
