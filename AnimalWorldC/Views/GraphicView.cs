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
    public partial class GraphicView : Form, IBaseView
    {
        private MainModel model;
        private List<PictureBox> pbs = new List<PictureBox>();
        private List<PictureBox> pbs_ai = new List<PictureBox>();

        public GraphicView()
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

            pbs_ai.Add(ai0);
            pbs_ai.Add(ai1);
            pbs_ai.Add(ai2);
            pbs_ai.Add(ai3);
            pbs_ai.Add(ai4);
            pbs_ai.Add(ai5);
            pbs_ai.Add(ai6);
            pbs_ai.Add(ai7);
            pbs_ai.Add(ai8);


            

        }

        private void EmptyView()
        {
            foreach (PictureBox pb in pbs)
            {
                pb.Image = null;
            }

            foreach (PictureBox pb in pbs_ai)
            {
                pb.Image = null;
            }
        }

        public void RefreshView()
        {
            EmptyView();

            for(int i = 0; i < 9; i++)
            {
                if (i < model.PlayerList.Count)
                {
                    pbs[i].Image = model.PlayerList[i].GetImage();

                    if (model.PlayerList[i].GetColor() != null)
                    {
                        pbs[i].BackColor = model.PlayerList[i].GetColor();

                        if (model.PlayerList[i].GetType() == typeof(Rock) )
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

        public void SetModel(MainModel model)
        {
            this.model = model;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pb7_Click(object sender, EventArgs e)
        {

        }

        private void GraphicView_Load(object sender, EventArgs e)
        {
            EmptyView();
        }
    }
}
