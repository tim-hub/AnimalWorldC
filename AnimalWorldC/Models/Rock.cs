using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AnimalWorldC
{
    class Rock :Element
    {
        /// <summary>
        /// this is an special attribute for rock
        /// rock has special cursor
        /// </summary>
        private string cursorName;

        public Rock()
        {
            this.id = 1;
            this.name = "Rock";

        }

        /// <summary>
        /// Unique setter and getter for rock only
        /// </summary>
        public string CursorName
        {
            get { return this.cursorName; }
            set
            {
                this.cursorName = value;
            }
        }



        /// <summary>
        /// Comparing ang getting results.
        /// It is unique for each element.
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public override int Comparing(int i)
        {
            if (i == 2)
            {
                return -1;
            }
            else if (i == 0)
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

            
            return Properties.Resources.rock;
        }

        public override string ToString()
        {
            if (this.cursorName == "Default")
            {
                return name + "(" + id + ")" + ", Color: " + this.GetColor() + ", using Default Cursor";

            }
            else
            {
                return name + "(" + id + ")" + ", Color: " + this.GetColor() + ", Using Special Cross Cursor";
            }

        }
    }
}
