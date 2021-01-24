using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YP_3Lib
{
    public class Task3
    {
        private List<Point> PointsOfLines = new List<Point>();
        private List<Point> Rectangle = new List<Point>();

        public void Start()
        {
            MakeRectangle();
            MakeLines();

            Output();

            CheckPoints();
        }

        private void MakeRectangle()
        {
            /*var rand = new Random();

            Rectangle.Add(new Point(rand.Next(-10, 11), rand.Next(-10, 11)));
            Rectangle.Add(new Point(rand.Next(-10, 11), rand.Next(-10, 11)));*/

            Rectangle.Add(new Point(-6, -4));
            Rectangle.Add(new Point(6, 4));
        }

        private void MakeLines()
        {
            var rand = new Random();
            int count = rand.Next(0, 100);

            while(count > 0)
            {
                PointsOfLines.Add(new Point(rand.Next(-10, 11), rand.Next(-10, 11)));
                count--;
            }
        }

        private void Output()
        {
            foreach (var item in Rectangle)
            {
                Console.WriteLine($"[x: {item.X}, y: {item.Y}]");
            }

            Console.WriteLine("Линии: ");

            foreach (var item in PointsOfLines)
            {
                Console.WriteLine($"[x: {item.X}, y: {item.Y}]");
            }
        }

        private void CheckPoints()
        {
            Console.WriteLine("Точки пересечения: ");
            int i = 0;
            foreach (var item in PointsOfLines)
            {
                if (Rectangle.First().X <= item.X && Rectangle.First().Y <= item.Y && Rectangle.Last().X >= item.X && Rectangle.Last().Y >= item.Y)
                {
                    Console.WriteLine($"Линия {i + 1}: [x: {item.X}, y: {Rectangle.First().Y}], [x: {item.X}, y: {Rectangle.Last().Y}]");
                }
                i++;
            }
        }
    }
}
