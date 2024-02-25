

using System.Drawing;

namespace Exercise_1_U3
{
    internal class program
    {
        public static void Main(string[] args)
        {
            triangle a = new triangle();
            a.@base(20);

            triangle_2 b = new triangle_2 ();
            b.height_(15);

            Console.WriteLine(b.Area(a));

            
        }
    }
}