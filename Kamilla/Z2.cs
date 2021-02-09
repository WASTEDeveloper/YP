using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kamilla
{
    class Z2
    {
        private List<Tochka> dots = new List<Tochka>();

        public void Start()
        {
            InitPoints();

            Output();

            Triangles();
        }

        private void InitPoints()
        {
            var rand = new Random();

            int count = rand.Next(0, 51);
            while (count > 0)
            {
                dots.Add(new Tochka(rand.Next(-100, 100), rand.Next(-100, 100)));
                count--;
            }

        }

        private void Output()
        {
            foreach (var item in dots)
            {
                Console.WriteLine($"[x: {item.Ox}, y: {item.Oy}]");
            }
        }

        private void Triangles()
        {
            if (dots.Count < 3)
            {
                Console.WriteLine("Нехватает точек!");
            }

            double side;
            double side2;
            double side3;

            for (int i = 0; i < dots.Count - 2; i++)
            {
                for (int j = i + 1; j < dots.Count - 1; j++)
                {
                    for (int k = j + 1; k < dots.Count; k++)
                    {
                        if (dots[i].Ox < 0 && dots[i].Oy > 0 && dots[j].Ox < 0 && dots[j].Oy > 0 && dots[k].Ox < 0 && dots[k].Oy > 0)
                        {
                            side = Math.Sqrt(Math.Pow(dots[i].Ox - dots[j].Ox, 2) + Math.Pow(dots[i].Oy - dots[j].Oy, 2));
                            side2 = Math.Sqrt(Math.Pow(dots[j].Ox - dots[k].Ox, 2) + Math.Pow(dots[j].Oy - dots[k].Oy, 2));
                            side3 = Math.Sqrt(Math.Pow(dots[k].Ox - dots[i].Ox, 2) + Math.Pow(dots[k].Oy - dots[i].Oy, 2));
                            if (side + side2 > side3 || side2 + side3 > side || side3 + side > side2)
                            {
                                if (side != side2 && side2 != side3 && side3 != side)
                                {
                                    Console.WriteLine($"Треугольник: \n\tx{dots[i].Ox}, y{dots[i].Oy};\n\tx{dots[j].Ox}, y{dots[j].Oy};\n\tx{dots[k].Ox}, y{dots[k].Oy}");
                                    return;
                                }
                            }
                        }
                    }
                }
            }

            Console.WriteLine("Такого треугольника не существует!");
        }
    }
}
