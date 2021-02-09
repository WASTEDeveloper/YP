using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kamilla
{
    class Z3
    {
        private Rectangle rect = new Rectangle();
        private Triangle tri = new Triangle();

        public void Start()
        {
            InitPoints();

            Triangles();
        }

        private void InitPoints()
        {
            rect.LeftBottom = new Tochka(-6, -4);
            rect.LeftTop = new Tochka(-6, 4);
            rect.RightBottom = new Tochka(6, -4);
            rect.RightTop = new Tochka(6, 4);

            tri.Top = new Tochka(0, 4);
            tri.Right = new Tochka(6, -4);
            tri.Left = new Tochka(-6, -4);
        }

        private void Triangles()
        {
            double side = Math.Sqrt(Math.Pow(tri.Left.Ox - tri.Top.Ox, 2) + Math.Pow(tri.Left.Oy - tri.Top.Oy, 2));
            double side2 = Math.Abs(rect.LeftTop.Ox - tri.Top.Ox);
            double side3 = Math.Abs(rect.LeftBottom.Oy - rect.LeftTop.Oy);
            double halfP = (side + side2 + side3) / 2;
            Console.WriteLine($"Площадь 1-го кусочка: {Math.Sqrt(halfP * (halfP - side) * (halfP - side2) * (halfP - side3))}");

            side = Math.Sqrt(Math.Pow(tri.Right.Ox - tri.Top.Ox, 2) + Math.Pow(tri.Right.Oy - tri.Top.Oy, 2));
            side2 = Math.Abs(rect.RightTop.Ox - tri.Top.Ox);
            side3 = Math.Abs(rect.RightBottom.Oy - rect.RightTop.Oy);
            halfP = (side + side2 + side3) / 2;
            Console.WriteLine($"Площадь 2-го кусочка: {Math.Sqrt(halfP * (halfP - side) * (halfP - side2) * (halfP - side3))}");
        }
    }
}
