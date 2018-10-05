using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AnimalWorldC
{
    class Scissors:Element
    {
        public Scissors()
        {
            this.id = 0;
            this.name = "Scissors";

        }



        /// <summary>
        /// Comparing ang getting results.
        /// It is unique for each element.
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public override int Comparing(int i)
        {
            if (i == 1)
            {
                return -1;
            }
            else if (i == 2)
            {
                return 1;
            }
            return 0;
        }
        /// <summary>
        /// this is for showing image in view
        /// </summary>
        /// <returns></returns>
        public override Image GetImage()
        {
            return Properties.Resources.scissors;
        }


    }
}
