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
    public class Prism : Figure
    {
        private decimal _center_x;
        private decimal _center_y;
        private decimal _center_z;
        private decimal _dimensions_b;
        private decimal _dimensions_h;
        private decimal _dimensions_w;

        public Prism(decimal x, decimal y, decimal z, decimal b, decimal height, decimal width)
        {
            _center_x = x;
            _center_y = y;
            _center_z = z;
            _dimensions_b = b;
            _dimensions_h = height;
            _dimensions_w = width;
        }

        public override void Display()
        {
            Console.WriteLine("Prism figure:");
            Console.WriteLine("- dimensions: {0}x{1}x{2}", _dimensions_b, _dimensions_h, _dimensions_w);
            Console.WriteLine("- coord.: ({0}, {1}, {2})", _center_x, _center_y, _center_z);
        }
    }
}
