using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coolpc
{
    public class Product
    {
        public string Name { get; set; }

        public int Price { get; set; }

        public bool Hot { get; set; }

        public Color Forecolor { get; set; }

        public override string ToString()
        {
            if (Hot)
            {
                string s = string.Format("{0},${1},熱賣ing", this.Name, this.Price, Forecolor = Color.Red);
                return s;
            }
            else
            {
                string s = string.Format("{0},${1}", this.Name, this.Price, Forecolor = Color.Blue);
                return s;
            }
        }
    }
}