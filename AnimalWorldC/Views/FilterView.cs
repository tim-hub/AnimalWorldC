using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalWorldC
{
    public partial class FilterView : Form, IBaseView
    {
        private MainModel model;
        public FilterView()
        {
            InitializeComponent();
        }
        public void RefreshView()
        {
            listViewResults.Clear();
            foreach (Element e in model.PlayerList)
            {
                if (cmbType.SelectedIndex == e.Id || cmbType.SelectedItem == null)
                {
                    listViewResults.Items.Add(e.Name + e.GetColor());
                }
            }
        }
        public void SetModel(MainModel model)
        {
            this.model = model;
        }

        private void FilterView_Load(object sender, EventArgs e)
        {

        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            model.UpdateViews();
        }
    }
}
