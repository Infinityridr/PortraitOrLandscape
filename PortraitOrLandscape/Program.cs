using System;

namespace PortraitOrLandscape
{
    internal class Program
    {
        private static void Main()
        {
            try
            {
                Console.Write("Type the 2 dimensions of the photo:\n\nX)");
                var X = Convert.ToInt64(Console.ReadLine());
                Console.Write("Y)");
                var Y = Convert.ToInt64(Console.ReadLine());
                Max(Y, X);
            }
            catch (Exception)
            {
                Console.WriteLine("\nThat not even a number...");
            }
        }

        public static void Max(long Y, long X)
        {
            var result = (Y > X) ? "\nThis is a portrait" : "\nThis is a Landscape";
            Console.WriteLine(result);
        }
    }
}