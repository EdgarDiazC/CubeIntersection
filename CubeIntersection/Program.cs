using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeIntersection
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1, x2, y1, y2, z1, z2;
            int dim1, dim2;
            bool finish = true;

            while (finish)
            {
                Console.WriteLine("Write the coordinates of the first figure:");
                Console.WriteLine("X:");
                x1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Y:");
                y1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Z:");
                z1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Write the dimension of the first figure:");
                dim1 = int.Parse(Console.ReadLine());
                Cube cube1 = new Cube(x1, y1, z1, dim1);

                Console.WriteLine("Write the coordinates of the second figure:");
                Console.WriteLine("X:");
                x2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Y:");
                y2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Z:");
                z2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Write the dimension of the first figure:");
                dim2 = int.Parse(Console.ReadLine());
                Cube cube2 = new Cube(x2, y2, z2, dim2);

                if (cube1.Collided(cube2))
                {
                    Prism prism = cube1.CalculateCollision(cube2);
                    prism.Display();
                }
                else
                {
                    Console.WriteLine("These two figures don't collide!");
                }
            }
            
        }
    }
}
