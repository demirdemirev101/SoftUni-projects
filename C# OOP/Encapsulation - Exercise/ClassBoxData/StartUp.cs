using System;

namespace ClassBoxData
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            double length=double.Parse(Console.ReadLine());
            double width=double.Parse(Console.ReadLine());
            double height=double.Parse(Console.ReadLine());

            try
            {
                Box box = new Box(length, width, height);
                double sufaceArea = box.SurfaceArea();
                Console.WriteLine($"Surface Area - {sufaceArea:f2}");

                double lateralSurfaceArea = box.LateralSurfaceArea();
                Console.WriteLine($"Lateral Surface Area - {lateralSurfaceArea:f2}");

                double volume=box.Volume();
                Console.WriteLine($"Volume - {volume:f2}");
            }
            catch (ArgumentException ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
