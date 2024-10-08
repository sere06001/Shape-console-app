﻿using System;
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
                Console.WriteLine();
                Console.Write("Svar: ");
                bool svar = int.TryParse(Console.ReadLine(), out int n);
                while (n > 2 || n < 1 || !svar)
                {
                    Console.WriteLine();
                    Console.WriteLine("Välj figur genom att skriva 1 eller 2.");
                    Console.WriteLine();
                    Console.Write("Svar: ");
                    svar = int.TryParse(Console.ReadLine(), out n);
                }
                Console.Clear();
                Console.WriteLine("Använd kommatecken \",\" om du vill skriva in decimaltal.");
                Console.WriteLine();
                Console.Write("Ange höjd: ");
                double height = double.Parse(Console.ReadLine());
                Console.Write("Ange bredd: ");
                double width = double.Parse(Console.ReadLine());
                Console.WriteLine();

                Shape shape;
                string shapeType;

                if (n == 1)
                {
                    shape = new Triangle(width, height);
                    shapeType = "triangel";
                }
                else
                {
                    shape = new Rectangle(width, height);
                    shapeType = "rektangel";
                }
                
                Console.WriteLine($"En {shapeType} med höjden {height} och bredden {width} har en");
                Console.WriteLine($"Omkrets: {shape.Circumference(width, height)}");
                Console.WriteLine($"Area: {shape.Area(width, height)}");

                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}