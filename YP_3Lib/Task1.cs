using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YP_3Lib
{
    public class Task1
    {
        private List<Point> points = new List<Point>();

        public void Start()
        {
            InitPoints();

            Output();

            CountInside();
        }

        private void InitPoints()
        {
            var rand = new Random();

            /*int count = rand.Next(0, 51);
            while(count > 0)
            {
                points.Add(new Point(rand.Next(10, 100), rand.Next(10, 100)));
                count--;
            }*/

            points.Add(new Point(1, 1));
            points.Add(new Point(5, 2));
            points.Add(new Point(3, 2));
            points.Add(new Point(4, 2));
            points.Add(new Point(2, 2));

        }

        private void Output()
        {
            foreach (var item in points)
            {
                Console.WriteLine($"[x: {item.X}, y: {item.Y}]");
            }
        }

        private void CountInside()
        {
            var LastPoint = points.Last();
            int cout = 0;

            foreach (var item in points)
            {
                if (Math.Pow(item.Y - LastPoint.Y, 2) + Math.Pow(item.X - LastPoint.X, 2) <= 4)
                {
                    cout++;
                }
            }

            Console.WriteLine($"В окружность вокруг послдней точки и радиусом в 2 ед. входит: {cout - 1} точек(ки)");
        }
    }
}
