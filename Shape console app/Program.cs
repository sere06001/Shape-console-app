using System;
namespace Shape_console_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programmet kommer beräkna arean och omkretsen av en rätvinklig triangel eller rektangel där du angett dess höjd och bredd.");
            Console.WriteLine("Skriv endast in tal när du anger höjd och bredd, alltså inte med måttenheten.");
            Console.WriteLine();
            while (true)
            {
                Console.WriteLine("Bestäm vilken figur du vill ha:");
                Console.WriteLine("1. Rätvinklig triangel");
                Console.WriteLine("2. Rektangel");
                Console.WriteLine("3. Cirkel");
                Console.WriteLine();
                Console.Write("Svar: ");
                bool svar = int.TryParse(Console.ReadLine(), out int n);
                while (n > 3 || n < 1 || !svar)
                {
                    Console.WriteLine();
                    Console.WriteLine("Välj figur genom att skriva 1, 2 eller 3.");
                    Console.WriteLine();
                    Console.Write("Svar: ");
                    svar = int.TryParse(Console.ReadLine(), out n);
                }
                Console.Clear();
                Console.WriteLine("Använd kommatecken \",\" om du vill skriva in decimaltal.");
                Console.WriteLine();
                if (n == 1 || n == 2)
                {
                    Console.Write("Ange höjd: ");
                    double height = double.Parse(Console.ReadLine());
                    Console.Write("Ange bredd: ");
                    double width = double.Parse(Console.ReadLine());
                    if (n == 1)
                    {
                        Triangle triangle = new Triangle(width, height);
                        Console.WriteLine($"En triangel med höjden {height} och bredden {width} har en");
                        Console.WriteLine($"Omkrets: {triangle.Circumference()}");
                        Console.WriteLine($"Area: {triangle.Area()}");
                    }
                    else
                    {
                        Rectangle rektangel = new Rectangle(width, height);
                        Console.WriteLine($"En triangel med höjden {height} och bredden {width} har en");
                        Console.WriteLine($"Omkrets: {rektangel.Circumference()}");
                        Console.WriteLine($"Area: {rektangel.Area()}");
                    }
                }
                else
                {
                    Console.Write("Ange radie: ");
                    double radie = double.Parse(Console.ReadLine());
                    Circle circle = new Circle(radie);
                    Console.WriteLine($"En cirkel med radien {radie} har en");
                    Console.WriteLine($"Omkrets: {circle.Circumference()}");
                    Console.WriteLine($"Area: {circle.Area()}");
                }
                Console.WriteLine();



                

                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}