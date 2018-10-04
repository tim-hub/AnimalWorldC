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
    public partial class CommandView :  Form, IBaseView
    {
        private MainModel model;
        private ColorDialog MyDialog = new ColorDialog();
        public Views.RulesForm ruleForm;

        List<Element> elements;

        /// <summary>
        /// initialize the view and sub view.
        /// </summary>
        public CommandView()
        {
            InitializeComponent();
            ruleForm = new Views.RulesForm();
            
        }

        public void SetModel(MainModel model)
        {
            this.model = model;
        }

        public void RefreshView()
        {
            listViewResults.Clear();
            foreach (Element e in model.PlayerList)
            {
                listViewResults.Items.Add(e.name + e.color);
            }
        }

        private void CommandView_Load(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
            btnCreate.Enabled = true;
            listViewResults.View = View.List;

            listViewResults.HeaderStyle = ColumnHeaderStyle.None;



            listViewResults.Items.Add(
                    new ListViewItem(  "aasd" )
                );
            listViewResults.Items.Add(
                new ListViewItem( "1adads")
            );

            listViewResults.GridLines = true;

        }

        private void rbRock_CheckedChanged(object sender, EventArgs e)
        {

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

        private void CreateOne()
        {
            Paper paper;
            if (rbPaper.Checked)
            {
                paper =new Paper();

                if (MyDialog.Color != null)
                {
                    paper.SetColor(MyDialog.Color);
                }

                model.AddOne(paper);
            }

            RefreshView();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreateOne();
        }
    }
}
