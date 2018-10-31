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
        

        private List<Element> playerList;
        private List<Element> AIList;

        private MainController mainController;

        /// <summary>
        /// the model for all elements
        /// </summary>
        /// <param name="controller"></param>
        public MainModel(MainController controller)
        {
            this.mainController = controller;
            this.playerList = new List<Element>();
        }

        public void UpdateViews()
        {
            this.mainController.UpdateViews();
        }

        /// <summary>
        /// the get property for player list
        /// </summary>
        public List<Element> PlayerList
        {
            get
            {
                return this.playerList;
            }
        }

        public void UpdatePlayerList(List<Element> elements)
        {
            ClearList();
            foreach(Element element in elements)
            {
                this.playerList.Add(element);
            }
            UpdateViews();
        }

        public List<Element> getAIList()
        {
            return null;
        }

        public void AddOne(Element element)
        {
            this.playerList.Add(element);
            UpdateViews();
        }

        public void UpdateTheOne(int i, Element element)
        {
            this.playerList[i] = element;
            UpdateViews();
        }

        public void ClearList()
        {
            this.playerList.Clear();
        }

        public void RemoveOne(Element element)
        {
            this.playerList.Remove(element);
            UpdateViews();
        } 

       public void RemoveById(int i)
        {
            this.playerList.RemoveAt(i);
            UpdateViews();
        }
    }

    
}
