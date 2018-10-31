using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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

        private int i = 0;
        int x = 0;
        int y = 0;


        public Form1()
        {
            InitializeComponent();

            x = label2.Location.X;
            y = label2.Location.Y;

        }

        private void Init()
        {
            mainController = new MainController();
            mainModel = new MainModel(mainController);

            cView = new CommandView();
            gView = new GraphicView();
            fView = new FilterView();

            cView.SetModel(mainModel);
            gView.SetModel(mainModel);
            fView.SetModel(mainModel);

            mainController.AddView(cView);
            mainController.AddView(gView);
            mainController.AddView(fView);

            //show views



            fView.Show();

            gView.Show();
            cView.Show();


        }

        private void btnInit_Click(object sender, EventArgs e)
        {

            Init();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            
        }



        private void ThreadJob()
        {
            
            for (i = 0; i < 50; i++)
            {
                if (i == 49)
                {
                    i = 0;
                    this.LabelMove(new Point(x, y));
                }

                Point point= new Point(x - i * 10, y);
                this.LabelMove(point);
                
                Thread.Sleep(200);
            }
            
        }

        delegate void LabelMoving(Point point);
        private void LabelMove(Point point)
        {
            if (label2.InvokeRequired)
            {
                LabelMoving d = new LabelMoving(LabelMove);
                this.Invoke(d, new object[] { point });
            }
            else
            {
                label2.Location = point;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThreadStart job = new ThreadStart(ThreadJob);
            Thread thread = new Thread(job);
            thread.Start();
        }
    }
}
