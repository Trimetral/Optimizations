namespace Optimisations
{
    partial class ApproxForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.minTB = new System.Windows.Forms.TextBox();
            this.maxTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.koefaTB = new System.Windows.Forms.TextBox();
            this.koefbTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.stepTB = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.посчитатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.посчитатьсвоиТочкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zedGraphControl1.Location = new System.Drawing.Point(12, 28);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(776, 410);
            this.zedGraphControl1.TabIndex = 4;
            this.zedGraphControl1.UseExtendedPrintDialog = true;
            // 
            // minTB
            // 
            this.minTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.minTB.Location = new System.Drawing.Point(82, 456);
            this.minTB.Name = "minTB";
            this.minTB.Size = new System.Drawing.Size(100, 20);
            this.minTB.TabIndex = 5;
            this.minTB.Text = "-50";
            // 
            // maxTB
            // 
            this.maxTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.maxTB.Location = new System.Drawing.Point(266, 456);
            this.maxTB.Name = "maxTB";
            this.maxTB.Size = new System.Drawing.Size(100, 20);
            this.maxTB.TabIndex = 6;
            this.maxTB.Text = "50";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 459);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "X минимум";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 459);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "X максимум";
            // 
            // koefaTB
            // 
            this.koefaTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.koefaTB.Location = new System.Drawing.Point(649, 454);
            this.koefaTB.Name = "koefaTB";
            this.koefaTB.Size = new System.Drawing.Size(100, 20);
            this.koefaTB.TabIndex = 9;
            // 
            // koefbTB
            // 
            this.koefbTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.koefbTB.Location = new System.Drawing.Point(649, 480);
            this.koefbTB.Name = "koefbTB";
            this.koefbTB.Size = new System.Drawing.Size(100, 20);
            this.koefbTB.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(629, 456);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "a";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(629, 483);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "b";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 483);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Шаг";
            // 
            // stepTB
            // 
            this.stepTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.stepTB.Location = new System.Drawing.Point(82, 480);
            this.stepTB.Name = "stepTB";
            this.stepTB.Size = new System.Drawing.Size(100, 20);
            this.stepTB.TabIndex = 14;
            this.stepTB.Text = "2";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.посчитатьToolStripMenuItem,
            this.посчитатьсвоиТочкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // посчитатьToolStripMenuItem
            // 
            this.посчитатьToolStripMenuItem.Name = "посчитатьToolStripMenuItem";
            this.посчитатьToolStripMenuItem.Size = new System.Drawing.Size(184, 20);
            this.посчитатьToolStripMenuItem.Text = "Посчитать (случайные точки)";
            this.посчитатьToolStripMenuItem.Click += new System.EventHandler(this.ПосчитатьToolStripMenuItem_Click);
            // 
            // посчитатьсвоиТочкиToolStripMenuItem
            // 
            this.посчитатьсвоиТочкиToolStripMenuItem.Name = "посчитатьсвоиТочкиToolStripMenuItem";
            this.посчитатьсвоиТочкиToolStripMenuItem.Size = new System.Drawing.Size(149, 20);
            this.посчитатьсвоиТочкиToolStripMenuItem.Text = "Посчитать (свои точки)";
            this.посчитатьсвоиТочкиToolStripMenuItem.Click += new System.EventHandler(this.ПосчитатьсвоиТочкиToolStripMenuItem_Click);
            // 
            // ApproxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 546);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.stepTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.koefbTB);
            this.Controls.Add(this.koefaTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maxTB);
            this.Controls.Add(this.minTB);
            this.Controls.Add(this.zedGraphControl1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(568, 584);
            this.Name = "ApproxForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Безусловная оптимизация";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.TextBox minTB;
        private System.Windows.Forms.TextBox maxTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox koefaTB;
        private System.Windows.Forms.TextBox koefbTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox stepTB;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem посчитатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem посчитатьсвоиТочкиToolStripMenuItem;
    }
}

