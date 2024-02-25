using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1_U3
{
    internal class triangle_2:triangle
    {
        private int height;

        public int Height { get => height; set => height = value; }

        public void height_ (int _height)
        {
            height = _height;
        }

        public int Area (int area)
        {
            return ( (_base * height) / 2);
        }
    }
}
