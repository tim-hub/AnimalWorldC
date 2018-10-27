using System;
using System.Text;
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
    public partial class CommandView :  Form, IBaseView
    {
        private MainModel model;
        private ColorDialog MyDialog = new ColorDialog();

        private int scissorsCount = 0;
        private int rockCount = 0;
        private int paperCount = 0;

        public const int ScissorsLimit = 3;
        public const int RockLimit = 3;
        public const int PaperLimit = 3;

        public Views.RulesForm ruleForm;

        private Dictionary<RadioButton, Label> elementsUIDict;

        /// <summary>
        /// initialize the view and sub view.
        /// </summary>
        public CommandView()
        {
            InitializeComponent();
            ruleForm = new Views.RulesForm();

            // init ui dictionary
            elementsUIDict = new Dictionary<RadioButton, Label>();
            elementsUIDict.Add(rbScissors, labelScissors);
            elementsUIDict.Add(rbRock, labelRock);
            elementsUIDict.Add(rbPaper, labelPaper);


            DisableAllProperties();


        }

        public void SetModel(MainModel model)
        {
            this.model = model;
        }




        /// <summary>
        /// This method can be called through controller.
        /// </summary>

        public void RefreshView()
        {
            scissorsCount = 0;
            rockCount = 0;
            paperCount = 0;

            
            listViewResults.Clear();
            foreach (Element e in model.PlayerList)
            {
                listViewResults.Items.Add(e.ToString());
                if (e.Id == 0)
                {
                    scissorsCount++;
                }else if (e.Id == 1)
                {
                    rockCount++;
                }
                else
                {
                    paperCount++;
                }

                UpdateLabelCount();
            }
        }

        private void UpdateLabelCount()
        {
            labelScissors.Text = (ScissorsLimit - scissorsCount).ToString();
            labelRock.Text = (RockLimit - rockCount).ToString();
            labelPaper.Text = (PaperLimit - paperCount).ToString();
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
        }


        private void CommandView_Load(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
            btnUpdate.Enabled = false;
            btnCreate.Enabled = true;
            listViewResults.View = View.List;

            listViewResults.HeaderStyle = ColumnHeaderStyle.None;

            listViewResults.GridLines = true;

        }





        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void viewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ruleForm.Show();
        }

        private void CreatingValidation(RadioButton rb, Element element)
        {

            int j = 0;
            if (Int32.TryParse( elementsUIDict[rb].Text, out j))
            {
                if (j > 0)
                {
                    j = j - 1;

                    if (MyDialog.Color != null)
                    {
                        element.SetColor(MyDialog.Color);
                    }

                    model.AddOne(element);
                    
                    

                    if (j == 0)
                    {
                        elementsUIDict[rb].Enabled = false;
                        rb.Enabled = false;
                    }

                    // send the data change to the model,
                    // the model will call update views through controller,
                    // UpdateViews will be run after add one.
                }
                else
                {
                    MessageBox.Show("Your are running out of "+element.ToString());
                }
            }
        }

        private void CreateOne()
        {
           
            if (rbPaper.Checked )
            {
                Paper paper;
                paper = new Paper();

                paper.RotatingDegrees = (tbPaperRotation.Value) ;

                CreatingValidation(rbPaper, paper);

            }
            if (rbRock.Checked)
            {
                Rock rock;
                rock = new Rock();
                if (cmbRockCursor.SelectedIndex == 1)
                {
                    rock.CursorName = "Default";
                }
                CreatingValidation(rbRock, rock);

            }
            if (rbScissors.Checked)
            {
                Scissors scissors;
                scissors = new Scissors();
                scissors.Flipping = cbScissorsFlipping.Checked;

                CreatingValidation(rbScissors, scissors);

            }

        }

        private void UpdateTheOne()
        {
            int id =  GetSelectedIndexInListview();
            Element element = model.PlayerList[id];

            // color is the common attribute
            if (MyDialog.Color != null)
            {
                element.SetColor(MyDialog.Color);
            }

            if (element.Id == 0)
            {
                Scissors scissors = (Scissors) element;
                scissors.Flipping = cbScissorsFlipping.Checked;
                
                model.UpdateTheOne(id, scissors);

            }
            else if (element.Id == 1)
            {
                Rock rock = (Rock)element;
                if (cmbRockCursor.SelectedIndex == 1)
                {
                    rock.CursorName = "Default";
                }
               

                model.UpdateTheOne(id, rock);

            }
            else
            {
                Paper paper = (Paper)element;
                paper.RotatingDegrees = tbPaperRotation.Value;

                model.UpdateTheOne(id, paper);
            }

            
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreateOne();
        }

        private void listViewResults_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbOrder_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void tbPaperRotation_Scroll(object sender, EventArgs e)
        {
            if (tbPaperRotation.Value  >=90)
            {
                tbPaperRotation.Value = 180;
            }
            else
            {
                tbPaperRotation.Value = 0;
            }

            lblPaperRotation.Text = "" + tbPaperRotation.Value;
        }

        private void cmbRockCursor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRockCursor.SelectedIndex == 1)
            {
                lblRockCursor.Text = "Mouse";
                
            }
            else
            {
                lblRockCursor.Text = "Cross";
            }
        }

        private void RbScissorsChecked()
        {
            if (rbScissors.Checked)
            {
                DisableAllProperties();
                cbScissorsFlipping.Enabled = true;
            }
        }

        private void rbScissors_CheckedChanged(object sender, EventArgs e)
        {
            RbScissorsChecked();
        }

        private void RbRockChecked()
        {
            if (rbRock.Checked)
            {
                DisableAllProperties();
                cmbRockCursor.Enabled = true;

            }
        }

        private void rbRock_CheckedChanged(object sender, EventArgs e)
        {
            RbRockChecked();
        }

        private void RbPaperChecked()
        {
            if (rbPaper.Checked)
            {
                DisableAllProperties();
                tbPaperRotation.Enabled = true;

            }
        }

        private void rbPaper_CheckedChanged(object sender, EventArgs e)
        {
            RbPaperChecked();
        }

        private void listViewResults_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (listViewResults.FocusedItem.Bounds.Contains(e.Location))
                {
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }

        /// <summary>
        /// return list view index
        /// </summary>
        /// <returns> int index </returns>
        private int GetSelectedIndexInListview()
        {
            return listViewResults.SelectedIndices[0];
        }

        private Element GetSelectedElement(int i)
        {
            return model.PlayerList[i];
        }

        private RadioButton GetRadioButtonOfTheElement(int i)
        {
            Element element = GetSelectedElement(i);
            if (element.Id == 0)
            {
                return rbScissors;
            }else if (element.Id == 1)
            {
                return rbRock;
            }
            else if (element.Id ==2)
            {
                return rbPaper;
            }
            return null;
        }

        private Label GetLabelOfTheElement(int i)
        {
            Element element = GetSelectedElement(i);
            if (element.Id == 0)
            {
                return labelScissors;
            }
            else if (element.Id == 1)
            {
                return labelRock;
            }
            else if (element.Id == 2)
            {
                return labelPaper;
            }
            return null;
        }

        private void GoToUpdateMode()
        {
            btnUpdate.Enabled = true;
            btnCreate.Enabled = false;

            int i = GetSelectedIndexInListview();
            int id = model.PlayerList[i].Id;

            if ( id == 0)
            {
                rbScissors.Checked = true;
                RbScissorsChecked();
            }
            else if (id == 1)
            {
                rbRock.Checked = true;
                RbRockChecked();
            }
            else
            {
                rbPaper.Checked = true;
                RbPaperChecked();
            }


        }

        private void GoToCreateMode()
        {
            btnUpdate.Enabled = false;
            btnCreate.Enabled = true;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine(sender + "" + e);
            //MessageBox.Show(sender + "" + e);

            GoToUpdateMode();
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateTheOne();
            GoToCreateMode();
        }



        private void GoToDelete(int i, Label lbl)
        {

            DialogResult result = MessageBox.Show("Are you sure to delete this one?", "Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                int j = -1;
                Int32.TryParse(lbl.Text, out j);
                j = j + 1;
                if (j >= 0 && j <= 2)
                {
                    model.RemoveById(i);
                    lbl.Text = "" + (j);
                }
                else
                {
                    lbl.Enabled = false;
                }

                if (!lbl.Enabled)
                {
                    lbl.Enabled = true;
                }

            }
            else
            {
                //...
                Console.WriteLine("Stop deleting");
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = GetSelectedIndexInListview();
            GoToDelete(i, GetLabelOfTheElement(i));
        }
    }
}
