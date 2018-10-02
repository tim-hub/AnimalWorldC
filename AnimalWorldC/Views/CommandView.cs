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
    public partial class CommandView : Form, IElementalView
    {
        List<Element> elements;

        public CommandView()
        {
            InitializeComponent();
        }

        public void RefreshView()
        {

        }

        private void CommandView_Load(object sender, EventArgs e)
        {
            listViewResults.View = View.List;
            


            listViewResults.HeaderStyle = ColumnHeaderStyle.None;

            elements = new List<Element>();

            elements.Add(new Paper());
            elements.Add(new Paper());

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

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            // Keeps the user from selecting a custom color.
            MyDialog.AllowFullOpen = false;
            // Allows the user to get help. (The default is false.)
            MyDialog.ShowHelp = true;
            // Sets the initial color select to the current text color.
            MyDialog.Color = textBox1.ForeColor;

            // Update the text box color if the user clicks OK 
            if (MyDialog.ShowDialog() == DialogResult.OK)
                textBox1.ForeColor = MyDialog.Color;
        }
    }
}
