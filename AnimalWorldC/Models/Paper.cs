using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AnimalWorldC
{
    class Paper:Element
    { 

        public Paper()
        {
            id = 2;
            name = "Paper";

        }

        public void SetColor(Color c)
        {
            this.color = c;
        }

        public override int Comparing(int i)
        {
            if (i == 0)
            {
                return -1;
            }else if (i == 1)
            {
                return 1;
            }
            return 0;
        }
    }
}
