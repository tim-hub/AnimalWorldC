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

        }
        public void SetModel(MainModel model)
        {
            this.model = model;
        }

        private void FilterView_Load(object sender, EventArgs e)
        {

        }
    }
}
