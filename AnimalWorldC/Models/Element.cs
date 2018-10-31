using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace AnimalWorldC
{
    public class ColorHolder
    {
        public System.Drawing.Color Value { get; set; }

        public ColorHolder(int a, int r, int g, int b)
        {
            Value = Color.FromArgb(a, r, g, b);
        }
    }

    public abstract class Element
    {
        protected int id;

        protected string name ;
        public ColorHolder theColorHolder;
        
        public int Id
        {
            get { return id; }
        }
        public string Name
        {
            get { return name; }
        }

        public Color GetTheColor()
        {

            return Color.FromArgb(
                    theColorHolder.Value.A,
                    theColorHolder.Value.R,
                    theColorHolder.Value.G,
                    theColorHolder.Value.B
                    );
            
        }


        public ColorHolder TheColorHolder()
        {
            
            return this.theColorHolder;
        }

        public void SetColor(ColorHolder c)
        {
            
            this.theColorHolder = c;
        }

        public void SetColor(Color c)
        {
            this.theColorHolder = new ColorHolder(c.A, c.R, c.G, c.B);
        }

        public override string ToString()
        {
            return name;
        }
        public abstract int Comparing(int i);
        public abstract Image GetImage();
    }
}
