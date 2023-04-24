using MyMath;
using System;

public static class Program
{
    public static void Main(string[] args)
    {
        CustomVector v1 = new CustomVector{ x = 15,y = 30,z = 10 };
        CustomVector v2 = new CustomVector{ x = 5,y = 35,z = 20 };
        CustomVector v3 = v1 + v2;
        CustomVector v4 = v1 - v2;
        CustomVector v5 = v3 * 5;
        CustomVector v6 = v4 / 2;

        Console.WriteLine("1. x = " + v1.x + "; y = " + v1.y + "; z = " + v1.z);
        Console.WriteLine("2. x = " + v2.x + "; y = " + v2.y + "; z = " + v2.z);
        Console.WriteLine("3. x = " + v3.x + "; y = " + v3.y + "; z = " + v3.z);
        Console.WriteLine("4. x = " + v4.x + "; y = " + v4.y + "; z = " + v4.z);
        Console.WriteLine("5. x = " + v5.x + "; y = " + v5.y + "; z = " + v5.z);
        Console.WriteLine("6. x = " + v6.x + "; y = " + v6.y + "; z = " + v6.z);

        Console.ReadKey();
    }
}