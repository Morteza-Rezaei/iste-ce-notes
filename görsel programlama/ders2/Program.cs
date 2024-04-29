using System;
namespace ders2
{
    class Program
    {
        static void Main(string[] args)
        {
            // yarıçapı 10 olan dairenin alanını hesaplayan program
            int radius = 10;
            double area = radius * radius * 3.14;
            Console.WriteLine("Area of circle with radius {0} is {1}", radius, area);

            // Floating-Point
            Console.WriteLine(0.5 - 0.1 - 0.1 - 0.1 - 0.1 - 0.1);
            Console.WriteLine(3.14 + 1e20 - 1e20);
            Console.WriteLine(3.14 + (1e20 - 1e20));

            // Casting
            // tam sayıyı ondalıklı sayıya çevirme
            int x = 10;
            double y = x;
            Console.WriteLine("x = {0}   y = {1}", x, y);
            // ondalıklı sayıyı tam sayıya çevirme
            double a = 10.5;
            // int b = a; // hata verir
            int b = (int)a; // ondalıklı kısmı atar
            Console.WriteLine("a = {0}   b = {1}", a, b);
            


        }
    }
}