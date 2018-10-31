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
        private ColorDialog MyDialog = new ColorDialog();
        private MainModel model;
        private List<PictureBox> pbs = new List<PictureBox>();
        private List<PictureBox> pbs_ai = new List<PictureBox>();

        private int pbSelected = -1;

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



            DisableAllProperties();
        }


        private void DisableScissorsProperty()
        {
            cbScissorsFlipping.Enabled = false;
        }

        private void DisableRockProperty()
        {
            cmbRockCursor.Enabled = false;
        }

        private void DisablePaperProperty()
        {
            tbPaperRotation.Enabled = false;
        }

        private void DisableAllProperties()
        {
            DisablePaperProperty();
            DisableRockProperty();
            DisableScissorsProperty();

            btnColor.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void EmptyView()
        {
            foreach (PictureBox pb in pbs)
            {
                pb.Image = null;
                pb.BackColor = Color.BurlyWood;
            }

            foreach (PictureBox pb in pbs_ai)
            {
                pb.Image = null;
                pb.BackColor = Color.BurlyWood;
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

                    if (model.PlayerList[i].GetTheColor() != null)
                    {
                        pbs[i].BackColor = model.PlayerList[i].GetTheColor();

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

        private void pb0_Click(object sender, EventArgs e)
        {

        }

        private void pb0_DoubleClick(object sender, EventArgs e)
        {

        }



        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void UpdateTheElement(int i)
        {
            if (i >= 0 && i < model.PlayerList.Count)
            {
                
                Element element = model.PlayerList[i];

                // color is the common attribute
                if (MyDialog.Color != null)
                {
                    element.SetColor(MyDialog.Color);
                }

                if (element.Id == 0)
                {
                    Scissors scissors = (Scissors)element;
                    scissors.Flipping = cbScissorsFlipping.Checked;

                    model.UpdateTheOne(i, scissors);

                }
                else if (element.Id == 1)
                {
                    Rock rock = (Rock)element;
                    if (cmbRockCursor.SelectedIndex == 1)
                    {
                        rock.CursorName = "Default";
                    }


                    model.UpdateTheOne(i, rock);

                }
                else
                {
                    Paper paper = (Paper)element;
                    paper.RotatingDegrees = tbPaperRotation.Value;

                    model.UpdateTheOne(i, paper);
                }
            }


            // reset the picture box selected
            pbSelected = -1;
            DisableAllProperties();
        }



        private void btnUpdate_Click(object sender, EventArgs e)
        {

            UpdateTheElement(pbSelected);
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            // Keeps the user from selecting a custom color.
            MyDialog.AllowFullOpen = false;
            // Allows the user to get help. (The default is false.)
            MyDialog.ShowHelp = true;
            // Sets the initial color select to the current text color.
            MyDialog.Color = lblColor.BackColor;


            // Update the text box color if the user clicks OK 
            if (MyDialog.ShowDialog() == DialogResult.OK)
                lblColor.BackColor = MyDialog.Color;
        }

        private void GoToUpdateMode(int i)
        {
            // get the element from model
            Element e = model.PlayerList[i];

            if (e.Id == 0)
            {
                cbScissorsFlipping.Enabled = true;
            }else if (e.Id ==1) {
                cmbRockCursor.Enabled = true;
            }
            else
            {
                tbPaperRotation.Enabled = true;
            }

            btnColor.Enabled = true;
            btnUpdate.Enabled = true;

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pbSelected != -1)
            {
                GoToUpdateMode(pbSelected);
            }
        }

        private void GoToDelete(int i)
        {

            DialogResult result = MessageBox.Show("Are you sure to delete this one?", "Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                    model.RemoveById(i);
            }
            else
            {
                //...
                Console.WriteLine("Stop deleting");
            }

            pbSelected = -1;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pbSelected != -1)
            {
                GoToDelete(pbSelected);
            }
        }

        /// <summary>
        /// selected is the index of the picture box
        /// </summary>
        /// <param name="selected"></param>
        /// <param name="e"></param>
        private void ShowRightClickMenu(int selected, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // disable all properties, then enable them for spercific component
                DisableAllProperties();

                Console.WriteLine("Right click on picture box " + selected);

                if (selected < model.PlayerList.Count)
                {
                    contextMenuStrip1.Show(Cursor.Position);
                }


            }

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pb0_MouseClick(object sender, MouseEventArgs e)
        {
            pbSelected = 0;
            ShowRightClickMenu(pbSelected, e);
        }

        private void pb1_MouseClick(object sender, MouseEventArgs e)
        {
            pbSelected = 1;
            ShowRightClickMenu(pbSelected, e);
        }



        private void pb2_MouseClick(object sender, MouseEventArgs e)
        {
            pbSelected = 2;
            ShowRightClickMenu(pbSelected, e);
        }

        private void pb3_MouseClick(object sender, MouseEventArgs e)
        {
            pbSelected = 3;
            ShowRightClickMenu(pbSelected, e);
        }

        private void pb4_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void pb4_MouseClick(object sender, MouseEventArgs e)
        {
            pbSelected = 4;
            ShowRightClickMenu(pbSelected, e);
        }

        private void pb5_MouseClick(object sender, MouseEventArgs e)
        {
            pbSelected = 5;
            ShowRightClickMenu(pbSelected, e);
        }

        private void pb6_MouseClick(object sender, MouseEventArgs e)
        {
            pbSelected = 6;
            ShowRightClickMenu(pbSelected, e);
        }

        private void pb7_MouseClick(object sender, MouseEventArgs e)
        {
            pbSelected = 7;
            ShowRightClickMenu(pbSelected, e);
        }

        private void pb8_MouseClick(object sender, MouseEventArgs e)
        {
            pbSelected = 8;
            ShowRightClickMenu(pbSelected, e);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
