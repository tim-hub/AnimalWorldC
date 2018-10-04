using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWorldC
{
    public class MainModel
    {
        private ArrayList playerList;
        private LinkedList<Element> AIList;

        private MainController mainController;

        /// <summary>
        /// the model for all elements
        /// </summary>
        /// <param name="controller"></param>
        public MainModel(MainController controller)
        {
            this.mainController = controller;
            this.playerList = new ArrayList();
        }

        private void updateViews()
        {
            this.mainController.UpdateViews();
        }

        /// <summary>
        /// the get property for player list
        /// </summary>
        public ArrayList PlayerList
        {
            get
            {
                return this.playerList;
            }
        }

        public ArrayList getAIList()
        {
            return null;
        }

        public void AddOne(Element element)
        {
            this.playerList.Add(element);
            updateViews();
        }

        public void RemoveOne(Element element)
        {
            this.playerList.Remove(element);
            updateViews();
        } 
    }

    
}
