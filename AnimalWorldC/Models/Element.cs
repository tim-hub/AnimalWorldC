using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace AnimalWorldC
{
    public abstract class Element
    {
        protected int id;

        protected string name ;
        public Color color;
        
        public int Id
        {
            get { return id; }
        }
        public string Name
        {
            get { return name; }
        }

        public void SetColor(Color c)
        {
            this.color = c;
        }
        public override string ToString()
        {
            return name;
        }
        public abstract int Comparing(int i);
        public abstract Image GetImage();
    }
}
