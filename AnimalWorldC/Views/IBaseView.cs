using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWorldC
{
    public interface IBaseView
    {
        void RefreshView();
        void SetModel(MainModel model);
  
    }
}
