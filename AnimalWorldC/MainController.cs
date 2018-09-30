using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWorldC
{
    class MainController
    {
        private ArrayList views;
        
        /// <summary>
        /// constructor
        /// </summary>
        public MainController()
        {
            views = new ArrayList();
        }
        /// <summary>
        /// add a view
        /// </summary>
        /// <param name="view"></param>
        public void AddView(IElementalView view)
        {
            views.Add(view);
        }

        /// <summary>
        /// update all views
        /// </summary>
        public void UpdateViews()
        {
            foreach (IElementalView view in views)
            {
                view.RefreshView();
            }
        }
    }
}
