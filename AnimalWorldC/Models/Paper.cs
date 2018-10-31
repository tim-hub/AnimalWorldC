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
        /// <summary>
        /// this is unique for paper
        /// papaer can be rotated
        /// </summary>
        private int rotatingDegrees;

        public int RotatingDegrees
        {
            get { return this.rotatingDegrees; }
            set { this.rotatingDegrees = value; }
        }

        public Paper()
        {
            // it is better to set properties through config file
            // but hard-coding for now.
            this.id = 2;
            this.name = "Paper";

        }

        /// <summary>
        /// This is unique for paper
        /// It can be rotated
        /// </summary>
        /// <param name="bm"></param>
        /// <returns></returns>
        private Image RotateMySelf(Bitmap bm)
        {
            Bitmap r;
            r = Properties.Resources.paper;
            r.RotateFlip(RotateFlipType.Rotate180FlipNone);
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
            if (i == 0)
            {
                return -1;
            }else if (i == 1)
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
            if (this.rotatingDegrees == 180)
            {
                return  RotateMySelf(Properties.Resources.paper);

            }
            else
            {
                return Properties.Resources.paper;
            }

        }

        public override string ToString()
        {
            if (this.rotatingDegrees == 180)
            {
                return name + "("+id+")"+ ", Color: " + this.GetTheColor() + ", Rotating 180 degrees";

            }
            else
            {
                return name + "(" + id + ")" + ", Color: " + this.GetTheColor() + ", Rotating 0 degrees";
            }
            
        }
    }
}
