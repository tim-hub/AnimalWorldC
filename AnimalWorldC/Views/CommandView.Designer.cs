namespace AnimalWorldC
{
    partial class CommandView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listViewResults = new System.Windows.Forms.ListView();
            this.rbScissors = new System.Windows.Forms.RadioButton();
            this.rbPaper = new System.Windows.Forms.RadioButton();
            this.rbRock = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelPaper = new System.Windows.Forms.Label();
            this.labelRock = new System.Windows.Forms.Label();
            this.labelScissors = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbOrder = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblColor = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewResults
            // 
            this.listViewResults.Location = new System.Drawing.Point(12, 27);
            this.listViewResults.Name = "listViewResults";
            this.listViewResults.Size = new System.Drawing.Size(362, 213);
            this.listViewResults.TabIndex = 0;
            this.listViewResults.UseCompatibleStateImageBehavior = false;
            this.listViewResults.View = System.Windows.Forms.View.Tile;
            // 
            // rbScissors
            // 
            this.rbScissors.AutoSize = true;
            this.rbScissors.Location = new System.Drawing.Point(82, 12);
            this.rbScissors.Name = "rbScissors";
            this.rbScissors.Size = new System.Drawing.Size(64, 17);
            this.rbScissors.TabIndex = 1;
            this.rbScissors.TabStop = true;
            this.rbScissors.Text = "Scissors";
            this.rbScissors.UseVisualStyleBackColor = true;
            // 
            // rbPaper
            // 
            this.rbPaper.AutoSize = true;
            this.rbPaper.Location = new System.Drawing.Point(80, 146);
            this.rbPaper.Name = "rbPaper";
            this.rbPaper.Size = new System.Drawing.Size(53, 17);
            this.rbPaper.TabIndex = 2;
            this.rbPaper.TabStop = true;
            this.rbPaper.Text = "Paper";
            this.rbPaper.UseVisualStyleBackColor = true;
            // 
            // rbRock
            // 
            this.rbRock.AutoSize = true;
            this.rbRock.Location = new System.Drawing.Point(79, 80);
            this.rbRock.Name = "rbRock";
            this.rbRock.Size = new System.Drawing.Size(51, 17);
            this.rbRock.TabIndex = 3;
            this.rbRock.TabStop = true;
            this.rbRock.Text = "Rock";
            this.rbRock.UseVisualStyleBackColor = true;
            this.rbRock.CheckedChanged += new System.EventHandler(this.rbRock_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelPaper);
            this.panel1.Controls.Add(this.labelRock);
            this.panel1.Controls.Add(this.labelScissors);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.rbScissors);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.rbPaper);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.rbRock);
            this.panel1.Location = new System.Drawing.Point(12, 278);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 180);
            this.panel1.TabIndex = 4;
            // 
            // labelPaper
            // 
            this.labelPaper.AutoSize = true;
            this.labelPaper.Location = new System.Drawing.Point(56, 147);
            this.labelPaper.Name = "labelPaper";
            this.labelPaper.Size = new System.Drawing.Size(13, 13);
            this.labelPaper.TabIndex = 9;
            this.labelPaper.Text = "3";
            // 
            // labelRock
            // 
            this.labelRock.AutoSize = true;
            this.labelRock.Location = new System.Drawing.Point(56, 84);
            this.labelRock.Name = "labelRock";
            this.labelRock.Size = new System.Drawing.Size(13, 13);
            this.labelRock.TabIndex = 8;
            this.labelRock.Text = "3";
            // 
            // labelScissors
            // 
            this.labelScissors.AutoSize = true;
            this.labelScissors.Location = new System.Drawing.Point(56, 16);
            this.labelScissors.Name = "labelScissors";
            this.labelScissors.Size = new System.Drawing.Size(13, 13);
            this.labelScissors.TabIndex = 6;
            this.labelScissors.Text = "3";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::AnimalWorldC.Properties.Resources.Rock_paper_scissors__paper_;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 130);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AnimalWorldC.Properties.Resources.rock;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(0, 66);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::AnimalWorldC.Properties.Resources.scissors;
            this.pictureBox3.InitialImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cards You Have";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(210, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Order";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cmbOrder
            // 
            this.cmbOrder.FormattingEnabled = true;
            this.cmbOrder.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cmbOrder.Location = new System.Drawing.Point(191, 278);
            this.cmbOrder.Name = "cmbOrder";
            this.cmbOrder.Size = new System.Drawing.Size(81, 21);
            this.cmbOrder.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(213, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Color";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(197, 379);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(75, 23);
            this.btnColor.TabIndex = 16;
            this.btnColor.Text = "PickColor";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(67, 471);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 20;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(253, 471);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(213, 408);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(40, 13);
            this.lblColor.TabIndex = 22;
            this.lblColor.Text = "           ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(386, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // viewHelpToolStripMenuItem
            // 
            this.viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            this.viewHelpToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.viewHelpToolStripMenuItem.Text = "View Help";
            this.viewHelpToolStripMenuItem.Click += new System.EventHandler(this.viewHelpToolStripMenuItem_Click);
            // 
            // CommandView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 506);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbOrder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listViewResults);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CommandView";
            this.Text = "CommandView";
            this.Load += new System.EventHandler(this.CommandView_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewResults;
        private System.Windows.Forms.RadioButton rbScissors;
        private System.Windows.Forms.RadioButton rbPaper;
        private System.Windows.Forms.RadioButton rbRock;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelPaper;
        private System.Windows.Forms.Label labelRock;
        private System.Windows.Forms.Label labelScissors;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbOrder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
    }
}