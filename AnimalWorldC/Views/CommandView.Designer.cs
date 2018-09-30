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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("a");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("b");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("c");
            this.listViewResults = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listViewResults
            // 
            this.listViewResults.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.listViewResults.Location = new System.Drawing.Point(12, 12);
            this.listViewResults.Name = "listViewResults";
            this.listViewResults.Size = new System.Drawing.Size(362, 305);
            this.listViewResults.TabIndex = 0;
            this.listViewResults.UseCompatibleStateImageBehavior = false;
            // 
            // CommandView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 506);
            this.Controls.Add(this.listViewResults);
            this.Name = "CommandView";
            this.Text = "CommandView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewResults;
    }
}