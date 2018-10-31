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
        private List<PictureBox> pbs = new List<PictureBox>();

        public FilterView()
        {
            InitializeComponent();

            pbs.Add(pb0);
            pbs.Add(pb1);
            pbs.Add(pb2);
            pbs.Add(pb3);
            pbs.Add(pb4);
            pbs.Add(pb5);
            pbs.Add(pb6);
            pbs.Add(pb7);
            pbs.Add(pb8);
            EmptyView();
        }       

        private void EmptyView()
        {
            foreach (PictureBox pb in pbs)
            {
                pb.Image = null;
            }
        }

        private void UpdatePBs()
        {
            for (int i = 0; i < 9; i++)
            {
                if (i < model.PlayerList.Count)
                {
                    pbs[i].Image = model.PlayerList[i].GetImage();

                    if (model.PlayerList[i].GetTheColor() != null)
                    {
                        pbs[i].BackColor = model.PlayerList[i].GetTheColor();

                        if (model.PlayerList[i].GetType() == typeof(Rock))
                        {
                            Rock r = (Rock)model.PlayerList[i];

                            if (r.CursorName != "Default")
                            {
                                pbs[i].Cursor = Cursors.Cross;
                            }
                        }
                    }
                }

            }
        }

        private void UpdatePBs( int j)
        {
            for (int i = 0; i < 9; i++)
            {
                if (i < model.PlayerList.Count)
                {
                    if (model.PlayerList[i].Id == j)
                    {
                        pbs[i].Image = model.PlayerList[i].GetImage();
                        if (model.PlayerList[i].GetTheColor() != null)
                        {
                            pbs[i].BackColor = model.PlayerList[i].GetTheColor();
                            if (model.PlayerList[i].GetType() == typeof(Rock))
                            {
                                Rock r = (Rock)model.PlayerList[i];
                                if (r.CursorName != "Default")
                                {
                                    pbs[i].Cursor = Cursors.Cross;
                                }
                            }
                        }
                    }
                    else
                    {
                        pbs[i].Image = null;
                        pbs[i].BackColor = SystemColors.Control;
                    }
                    
                }


            }
        }

        public void RefreshView()
        {
            
            if (cmbType.SelectedIndex == -1)
            {
                EmptyView();
                UpdatePBs();
            }
            else
            {
                EmptyView();
                UpdatePBs(cmbType.SelectedIndex);
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
