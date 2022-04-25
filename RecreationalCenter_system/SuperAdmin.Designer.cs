namespace RecreationalCenter_system
{
    partial class SuperAdmin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuperAdmin));
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerNewEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todaysChartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.overallReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.weeklyReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupAbove5Dis = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.group5Dis = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.group3Dis = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.childPrice = new System.Windows.Forms.TextBox();
            this.adultPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Help;
            this.label3.Font = new System.Drawing.Font("Algerian", 25.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(31, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(622, 48);
            this.label3.TabIndex = 9;
            this.label3.Text = "Xyz Recreational Center";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(718, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerNewEmployeeToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.logoutToolStripMenuItem1});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // registerNewEmployeeToolStripMenuItem
            // 
            this.registerNewEmployeeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("registerNewEmployeeToolStripMenuItem.Image")));
            this.registerNewEmployeeToolStripMenuItem.Name = "registerNewEmployeeToolStripMenuItem";
            this.registerNewEmployeeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.registerNewEmployeeToolStripMenuItem.Size = new System.Drawing.Size(301, 26);
            this.registerNewEmployeeToolStripMenuItem.Text = "Register new Employee";
            this.registerNewEmployeeToolStripMenuItem.Click += new System.EventHandler(this.registerNewEmployeeToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.todaysChartToolStripMenuItem,
            this.overallReportToolStripMenuItem,
            this.weeklyReportToolStripMenuItem,
            this.customerInformationToolStripMenuItem});
            this.logoutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("logoutToolStripMenuItem.Image")));
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(301, 26);
            this.logoutToolStripMenuItem.Text = "View Report";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // todaysChartToolStripMenuItem
            // 
            this.todaysChartToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("todaysChartToolStripMenuItem.Image")));
            this.todaysChartToolStripMenuItem.Name = "todaysChartToolStripMenuItem";
            this.todaysChartToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.todaysChartToolStripMenuItem.Text = "Daily Chart";
            this.todaysChartToolStripMenuItem.Click += new System.EventHandler(this.todaysChartToolStripMenuItem_Click);
            // 
            // overallReportToolStripMenuItem
            // 
            this.overallReportToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("overallReportToolStripMenuItem.Image")));
            this.overallReportToolStripMenuItem.Name = "overallReportToolStripMenuItem";
            this.overallReportToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.overallReportToolStripMenuItem.Text = "Overall Report";
            this.overallReportToolStripMenuItem.Click += new System.EventHandler(this.overallReportToolStripMenuItem_Click);
            // 
            // weeklyReportToolStripMenuItem
            // 
            this.weeklyReportToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("weeklyReportToolStripMenuItem.Image")));
            this.weeklyReportToolStripMenuItem.Name = "weeklyReportToolStripMenuItem";
            this.weeklyReportToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.weeklyReportToolStripMenuItem.Text = "Weekly Report";
            this.weeklyReportToolStripMenuItem.Click += new System.EventHandler(this.weeklyReportToolStripMenuItem_Click);
            // 
            // customerInformationToolStripMenuItem
            // 
            this.customerInformationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("customerInformationToolStripMenuItem.Image")));
            this.customerInformationToolStripMenuItem.Name = "customerInformationToolStripMenuItem";
            this.customerInformationToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.customerInformationToolStripMenuItem.Text = "Customer Information";
            this.customerInformationToolStripMenuItem.Click += new System.EventHandler(this.customerInformationToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem1
            // 
            this.logoutToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("logoutToolStripMenuItem1.Image")));
            this.logoutToolStripMenuItem1.Name = "logoutToolStripMenuItem1";
            this.logoutToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.logoutToolStripMenuItem1.Size = new System.Drawing.Size(301, 26);
            this.logoutToolStripMenuItem1.Text = "Logout";
            this.logoutToolStripMenuItem1.Click += new System.EventHandler(this.logoutToolStripMenuItem1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.groupAbove5Dis);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.group5Dis);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.group3Dis);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.childPrice);
            this.panel1.Controls.Add(this.adultPrice);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(98, 157);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 270);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupAbove5Dis
            // 
            this.groupAbove5Dis.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupAbove5Dis.Location = new System.Drawing.Point(235, 172);
            this.groupAbove5Dis.MaxLength = 2;
            this.groupAbove5Dis.Name = "groupAbove5Dis";
            this.groupAbove5Dis.Size = new System.Drawing.Size(50, 27);
            this.groupAbove5Dis.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(8, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(219, 22);
            this.label7.TabIndex = 9;
            this.label7.Text = "Discount % for group above 7:";
            // 
            // group5Dis
            // 
            this.group5Dis.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.group5Dis.Location = new System.Drawing.Point(236, 133);
            this.group5Dis.MaxLength = 2;
            this.group5Dis.Name = "group5Dis";
            this.group5Dis.Size = new System.Drawing.Size(50, 27);
            this.group5Dis.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(35, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 22);
            this.label6.TabIndex = 7;
            this.label6.Text = "Discount % for group of 5:";
            // 
            // group3Dis
            // 
            this.group3Dis.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.group3Dis.Location = new System.Drawing.Point(235, 92);
            this.group3Dis.MaxLength = 2;
            this.group3Dis.Name = "group3Dis";
            this.group3Dis.Size = new System.Drawing.Size(50, 27);
            this.group3Dis.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(35, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Discount % for group of 3:";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(298, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // childPrice
            // 
            this.childPrice.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.childPrice.Location = new System.Drawing.Point(235, 55);
            this.childPrice.MaxLength = 4;
            this.childPrice.Name = "childPrice";
            this.childPrice.Size = new System.Drawing.Size(50, 27);
            this.childPrice.TabIndex = 3;
            // 
            // adultPrice
            // 
            this.adultPrice.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.adultPrice.Location = new System.Drawing.Point(235, 19);
            this.adultPrice.MaxLength = 4;
            this.adultPrice.Name = "adultPrice";
            this.adultPrice.Size = new System.Drawing.Size(50, 27);
            this.adultPrice.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(114, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Set child price:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(114, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Set adult price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.OliveDrab;
            this.label4.Location = new System.Drawing.Point(98, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "(Per Hour Rate*)";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(98, 88);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // SuperAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(718, 506);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(745, 560);
            this.MinimumSize = new System.Drawing.Size(736, 553);
            this.Name = "SuperAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Panel";
            this.Load += new System.EventHandler(this.SuperAdmin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem registerNewEmployeeToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem1;
        private Panel panel1;
        private TextBox childPrice;
        private TextBox adultPrice;
        private Label label2;
        private Label label1;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private ToolTip toolTip1;
        private TextBox groupAbove5Dis;
        private Label label7;
        private TextBox group5Dis;
        private Label label6;
        private TextBox group3Dis;
        private Label label5;
        private ToolStripMenuItem todaysChartToolStripMenuItem;
        private ToolStripMenuItem overallReportToolStripMenuItem;
        private ToolStripMenuItem weeklyReportToolStripMenuItem;
        private ToolStripMenuItem customerInformationToolStripMenuItem;
    }
}