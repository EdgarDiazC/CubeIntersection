using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeIntersection
{
    /**
     * Concrete class of decorator pattern
     * */
    public class Cube : Figure
    {

        public int Center_x { get; }
        public int Center_y { get; }
        public int Center_z { get; }
        public int Dimensions { get; }

        public Cube(int x, int y, int z, int dimensions)
        {
            Center_x = x;
            Center_y = y;
            Center_z = z;
            Dimensions = dimensions;
        }

        public override void Display()
        {
            Console.WriteLine("Cube figure:");
            Console.WriteLine("- dimensions: {0}x{0}x{0}", Dimensions);
            Console.WriteLine("- coord.: ({0}, {1}, {2})", Center_x, Center_y, Center_z);
        }

        public bool Collided(Cube cube2)
        {
            bool collided = false;
            //Possible collision x coordinate
            if ((cube2.Center_x >= Center_x && 
                cube2.Center_x - (cube2.Dimensions / 2) < Center_x + Dimensions / 2) ||
                (cube2.Center_x <= Center_x &&
                cube2.Center_x + (cube2.Dimensions / 2) > Center_x - Dimensions / 2))
            {

                //Possible collision x and y coordinates
                if ((cube2.Center_y >= Center_y &&
                    cube2.Center_y - (cube2.Dimensions / 2) < Center_y + Dimensions / 2) ||
                    (cube2.Center_y <= Center_y &&
                    cube2.Center_y + (cube2.Dimensions / 2) > Center_y - Dimensions / 2))
                {
                    //Final condition for collision
                    if ((cube2.Center_z >= Center_z &&
                        cube2.Center_z - (cube2.Dimensions / 2) < Center_z + Dimensions / 2) ||
                        (cube2.Center_z <= Center_z &&
                        cube2.Center_z + (cube2.Dimensions / 2) > Center_z - Dimensions / 2))
                    {
                        collided = true;
                    }
                }
            }

            return collided;
        }

        public Prism CalculateCollision(Cube cube2)
        {
            decimal b, h, w;

            //Calculate base
            if(cube2.Center_x >= Center_x)
            {
                b = (Center_x + Dimensions / 2) - (cube2.Center_x - cube2.Dimensions / 2);
            }
            else
            {
                b = (cube2.Center_x + cube2.Dimensions / 2) - (Center_x - Dimensions / 2);
            }
            //Calculate height
            if (cube2.Center_y >= Center_y)
            {
                h = (Center_y + Dimensions / 2) - (cube2.Center_y - cube2.Dimensions / 2);
            }
            else
            {
                h = (cube2.Center_y + cube2.Dimensions / 2) - (Center_y - Dimensions / 2);
            }

            //Calculate width
            if (cube2.Center_z >= Center_z)
            {
                w = (Center_z + Dimensions / 2) - (cube2.Center_z - cube2.Dimensions / 2);
            }
            else
            {
                w = (cube2.Center_z + cube2.Dimensions / 2) - (Center_z - Dimensions / 2);
            }

            Prism result = new Prism(b/2,h/2,w/2,b,h,w);
            return result;
        }
    }
}
