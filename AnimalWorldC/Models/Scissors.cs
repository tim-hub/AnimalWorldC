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
        /// <summary>
        /// the unique attribute for scissors
        /// </summary>
        private bool flipping;


        public bool Flipping
        {
            get { return this.flipping; }
            set { this.flipping = value; }
        }


        public Scissors()
        {
            this.id = 0;
            this.name = "Scissors";

        }

        /// <summary>
        /// the unique method for scissors
        /// </summary>
        /// <param name="bm"></param>
        /// <returns></returns>

        private Bitmap FlipMySelf(Bitmap bm)
        {

            Bitmap r;
            r = Properties.Resources.scissors;
            r.RotateFlip(RotateFlipType.RotateNoneFlipX);
            return r;
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
        /// It overrides abstract method from parent class
        /// </summary>
        /// <returns>Image</returns>
        public override Image GetImage()
        {


            if (this.flipping)
            {
                return FlipMySelf(Properties.Resources.scissors);
            }
            else
            {
                return Properties.Resources.scissors;
            }
           
        }

        public override string ToString()
        {
            if (this.flipping)
            {
                return name + "(" + id + ")" + ", Color: " + this.GetTheColor() + ", Flipping";

            }
            else
            {
                return name + "(" + id + ")" + ", Color: " + this.GetTheColor() + ", Not Flipping";
            }

        }


    }
}
