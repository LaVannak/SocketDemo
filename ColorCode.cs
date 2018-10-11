using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocketDemo
{
    class ColorCode
    {
        public int red { get; set; }
        public int blue { get; set; }
        public int green { get; set; }
        public int alpha { get; set; }
        public string hexcode { get; set; }

        public ColorCode(int r, int b, int g, int a, string h)
        {
            red = r;
            blue = b;
            green = g;
            alpha = a;
            hexcode = h;
        }
    }
}
