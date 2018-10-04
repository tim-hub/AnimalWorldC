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
        public int id;

        
        public string name ;
        public Color color;
        

        public abstract int Comparing(int i);
        
    }
}
