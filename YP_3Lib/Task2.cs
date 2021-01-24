using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YP_3Lib
{
    public class Task2
    {
        private List<Point> points = new List<Point>();

        public void Start()
        {
            InitPoints();

            Output();

            Console.WriteLine(Triangles());
        }

        private void InitPoints()
        {
            var rand = new Random();

            int count = rand.Next(0, 51);
            while(count > 0)
            {
                points.Add(new Point(rand.Next(10, 100), rand.Next(10, 100)));
                count--;
            }

        }

        private void Output()
        {
            foreach (var item in points)
            {
                Console.WriteLine($"[x: {item.X}, y: {item.Y}]");
            }
        }

        private bool Triangles()
        {
            if (points.Count < 3)
            {
                return false;
            }

            List<double> Squares = new List<double>();

            double side;
            double side2;
            double side3;
            double halfP;

            for (int i = 0; i < points.Count - 2; i++)
            {
                for (int j = i + 1; j < points.Count - 1; j++)
                {
                    for (int k = j + 1; k < points.Count; k++)
                    {
                        side = Math.Sqrt(Math.Pow(points[i].X - points[j].X, 2) + Math.Pow(points[i].Y - points[j].Y, 2));
                        side2 = Math.Sqrt(Math.Pow(points[j].X - points[k].X, 2) + Math.Pow(points[j].Y - points[k].Y, 2));
                        side3 = Math.Sqrt(Math.Pow(points[k].X - points[i].X, 2) + Math.Pow(points[k].Y - points[i].Y, 2));
                        if (side + side2 > side3 || side2 + side3 > side || side3 + side > side2)
                        {
                            halfP = (side + side2 + side3) / 2;
                            Squares.Add(Math.Sqrt(halfP * (halfP - side) * (halfP - side2) * (halfP - side3)));
                        }
                    }
                }
            }

            var result = Squares.GroupBy(x => x).Where(g => g.Count() > 1).Select(g => g.Key).ToList();
            
            if (result.Count >= 2)
                return true;
            else
                return false;
        } 
    }
}
