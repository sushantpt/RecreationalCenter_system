namespace RecreationalCenter_system
{
    public partial class SuperAdmin : Form
    {
        public int adultPerPrice;  /*to store adult per price*/
        public int childPerPrice;  /*to store child per price*/

        string adultPricePath = "C:\\Users\\gu1us\\source\\repos\\RecreationalCenter_system\\admin_folder\\adultPrice.txt";
        string kidsPricePath = "C:\\Users\\gu1us\\source\\repos\\RecreationalCenter_system\\admin_folder\\kidsPrice.txt";
        string disFor3Path = "C:\\Users\\gu1us\\source\\repos\\RecreationalCenter_system\\admin_folder\\discountFor3.txt";
        string disFor5Path = "C:\\Users\\gu1us\\source\\repos\\RecreationalCenter_system\\admin_folder\\discountFor5.txt";
        string disForAbove7Path = "C:\\Users\\gu1us\\source\\repos\\RecreationalCenter_system\\admin_folder\\discountForAbove5.txt";
        public SuperAdmin()
        {
            InitializeComponent();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void SuperAdmin_Load(object sender, EventArgs e)
        {
            /*set tooltip in (Per hour*) field*/
            toolTip1.SetToolTip(label4, "Price will be calculated in per hour basis");
        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            /*ask for logging out confirmation*/
            DialogResult dialogResult = MessageBox.Show("Logout from the system?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                /*if yes, close the application completely*/
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        private void registerNewEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*open registration of employee panel*/
            RegisterEmployeePanel registerEmployeePanel = new RegisterEmployeePanel();
            registerEmployeePanel.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*validation for empty filed*/
            if (adultPrice.Text.Length == 0 || childPrice.Text.Length == 0 || group3Dis.Text.Length == 0
                || group5Dis.Text.Length == 0 || groupAbove5Dis.Text.Length == 0)
            {
                MessageBox.Show("Changes will be only made where value is inserted.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            /*ask admin to make changes*/
            DialogResult result = MessageBox.Show("Make the changes?", "Confirmation", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if(result == DialogResult.Yes)
            {
                /*adultPerPrice = int.TryParse(adultPrice.Text, out adultPerPrice); */  /*setting price of adult from admin to system*/
                /*childPerPrice = int.TryParse(childPrice.Text, out childPerPrice);*/   /*setting price of child from admin to system*/


                /*from here, save the changes and store it in a file*/

                StreamWriter sw1 = new StreamWriter(adultPricePath);
                sw1.WriteLine(adultPrice.Text);
                sw1.Close();

                StreamWriter sw2 = new StreamWriter(kidsPricePath);
                sw2.WriteLine(childPrice.Text);
                sw2.Close();

                StreamWriter sw3 = new StreamWriter(disFor3Path);
                sw3.WriteLine(group3Dis.Text);
                sw3.Close();

                StreamWriter sw4 = new StreamWriter(disFor5Path);
                sw4.WriteLine(group5Dis.Text);
                sw4.Close();

                StreamWriter sw5 = new StreamWriter(disForAbove7Path);
                sw5.WriteLine(groupAbove5Dis.Text);
                sw5.Close();

                clearBtn();

                Thread.Sleep(700);
                MessageBox.Show("Changes have been successfully made.", "Confirmation", MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
            }
            else
            {
                return;
            }
            
        }

        /*method to get price of adult from admin in employee panel*/
        public int getAdultPrice()
        {
            adultPerPrice = Convert.ToInt32(File.ReadAllText(adultPricePath));
            return adultPerPrice;
        }

        /*method to get price of child from admin in employee panel*/
        public int getChildPrice()
        {
            childPerPrice = Convert.ToInt32(File.ReadAllText(kidsPricePath));
            return childPerPrice;
        }
        /*method to get discount percent for group of adult 3*/
        public int getDisFor3()
        {
            int disAmt;
            disAmt = Convert.ToInt32(File.ReadAllText(disFor3Path));
            return disAmt;
        }

        /*method to get discount percent for group of adult 5*/
        public int getDisFor5()
        {
            int disAmt;
            disAmt = Convert.ToInt32(File.ReadAllText(disFor5Path));
            return disAmt;
        }
        /*method to get discount percent for group of adult above 7*/
        public int getDisForAbove7()
        {
            int disAmt;
            disAmt = Convert.ToInt32(File.ReadAllText(disForAbove7Path));
            return disAmt;
        }

        private void todaysChartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*open daily report section*/
            DailyReport dailyReport = new DailyReport();
            dailyReport.Show();
        }

        private void weeklyChartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*open weekly report section*/
            WeeklyReport weeklyReport = new WeeklyReport();
            weeklyReport.Show();
        }

        /*clear button for superadmin section*/
        private void clearBtn()
        {
            adultPrice.Clear();
            childPrice.Clear();
            group3Dis.Clear();
            group5Dis.Clear();
            groupAbove5Dis.Clear();
        }

        private void weeklyReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WeeklyReport weeklyReport = new WeeklyReport();
            weeklyReport.ShowDialog();
        }

        private void overallReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OverallReport overallReport = new OverallReport();
            overallReport.ShowDialog();
        }

        private void customerInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustoomerInformation customerInformation = new CustoomerInformation();
            customerInformation.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}