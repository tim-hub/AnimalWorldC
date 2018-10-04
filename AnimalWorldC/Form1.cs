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
    public partial class Form1 : Form
    {

        private MainModel mainModel;
        private MainController mainController;
        private CommandView cView;
        private GraphicView gView;
        private FilterView fView;

        public Form1()
        {
            InitializeComponent();
        }

        private void Init()
        {
            mainController = new MainController();
            mainModel = new MainModel(mainController);

            cView = new CommandView();
            gView = new GraphicView();
            fView = new FilterView();

            mainController.AddView(cView);
            mainController.AddView(gView);
            mainController.AddView(fView);

            //show views

            cView.Show();

            gView.Show();

            fView.Show();

        }

        private void btnInit_Click(object sender, EventArgs e)
        {

            Init();
        }
    }
}
