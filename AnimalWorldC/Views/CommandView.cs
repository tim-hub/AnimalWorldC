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
            
            listViewResults.Clear();
            foreach (Element e in model.PlayerList)
            {
                listViewResults.Items.Add(e.ToString());
            }
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
                    elementsUIDict[rb].Text = (j ).ToString();

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

        private void rbScissors_CheckedChanged(object sender, EventArgs e)
        {
            if (rbScissors.Checked)
            {
                DisableAllProperties();
                cbScissorsFlipping.Enabled = true;
            }
        }

        private void rbRock_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRock.Checked)
            {
                DisableAllProperties();
                cmbRockCursor.Enabled = true;

            }
        }

        private void rbPaper_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPaper.Checked)
            {
                DisableAllProperties();
                tbPaperRotation.Enabled = true;

            }
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

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
