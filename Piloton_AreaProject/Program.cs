using System;

namespace PilotonAreaProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int lenght;
            int width;

            int area;

            Console.WriteLine("Enter lenght: ");
            lenght = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter width: ");
            width = int.Parse(Console.ReadLine());

            area = (lenght * width);

            Console.WriteLine($"area: {area}");
        }
    }
}