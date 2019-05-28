namespace Optimisations
{
    partial class ActualTask
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ExampleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.zedGraphControl2 = new ZedGraph.ZedGraphControl();
            this.zedGraphControl3 = new ZedGraph.ZedGraphControl();
            this.случайноеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExampleToolStripMenuItem,
            this.случайноеToolStripMenuItem,
            this.testToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1095, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ExampleToolStripMenuItem
            // 
            this.ExampleToolStripMenuItem.Name = "ExampleToolStripMenuItem";
            this.ExampleToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.ExampleToolStripMenuItem.Text = "Пример";
            this.ExampleToolStripMenuItem.Click += new System.EventHandler(this.ExampleToolStripMenuItem_Click);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.testToolStripMenuItem.Text = "test";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.zedGraphControl1.Location = new System.Drawing.Point(773, 52);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(310, 252);
            this.zedGraphControl1.TabIndex = 17;
            this.zedGraphControl1.UseExtendedPrintDialog = true;
            // 
            // zedGraphControl2
            // 
            this.zedGraphControl2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.zedGraphControl2.Location = new System.Drawing.Point(773, 310);
            this.zedGraphControl2.Name = "zedGraphControl2";
            this.zedGraphControl2.ScrollGrace = 0D;
            this.zedGraphControl2.ScrollMaxX = 0D;
            this.zedGraphControl2.ScrollMaxY = 0D;
            this.zedGraphControl2.ScrollMaxY2 = 0D;
            this.zedGraphControl2.ScrollMinX = 0D;
            this.zedGraphControl2.ScrollMinY = 0D;
            this.zedGraphControl2.ScrollMinY2 = 0D;
            this.zedGraphControl2.Size = new System.Drawing.Size(310, 257);
            this.zedGraphControl2.TabIndex = 18;
            this.zedGraphControl2.UseExtendedPrintDialog = true;
            // 
            // zedGraphControl3
            // 
            this.zedGraphControl3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.zedGraphControl3.Location = new System.Drawing.Point(773, 573);
            this.zedGraphControl3.Name = "zedGraphControl3";
            this.zedGraphControl3.ScrollGrace = 0D;
            this.zedGraphControl3.ScrollMaxX = 0D;
            this.zedGraphControl3.ScrollMaxY = 0D;
            this.zedGraphControl3.ScrollMaxY2 = 0D;
            this.zedGraphControl3.ScrollMinX = 0D;
            this.zedGraphControl3.ScrollMinY = 0D;
            this.zedGraphControl3.ScrollMinY2 = 0D;
            this.zedGraphControl3.Size = new System.Drawing.Size(310, 257);
            this.zedGraphControl3.TabIndex = 19;
            this.zedGraphControl3.UseExtendedPrintDialog = true;
            // 
            // случайноеToolStripMenuItem
            // 
            this.случайноеToolStripMenuItem.Name = "случайноеToolStripMenuItem";
            this.случайноеToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.случайноеToolStripMenuItem.Text = "Случайное";
            this.случайноеToolStripMenuItem.Click += new System.EventHandler(this.случайноеToolStripMenuItem_Click);
            // 
            // ActualTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 839);
            this.Controls.Add(this.zedGraphControl3);
            this.Controls.Add(this.zedGraphControl2);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.menuStrip1);
            this.MinimumSize = new System.Drawing.Size(1111, 851);
            this.Name = "ActualTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ActualTask";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ExampleToolStripMenuItem;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private ZedGraph.ZedGraphControl zedGraphControl2;
        private ZedGraph.ZedGraphControl zedGraphControl3;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem случайноеToolStripMenuItem;
    }
}