using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Globalization;
using CsvHelper.Configuration;
using System.Dynamic;
using Newtonsoft.Json;

namespace RecreationalCenter_system
{
    public partial class EmployeePanel : Form
    {
        public string monthlyPath = "C:\\Users\\gu1us\\source\\repos\\RecreationalCenter_system\\montlhy.csv";
        public string weeklyPath = "C:\\Users\\gu1us\\source\\repos\\RecreationalCenter_system\\weekly.csv";
        public string csvPath = "C:\\Users\\gu1us\\source\\repos\\RecreationalCenter_system\\csvFile.csv";
        public StringBuilder stringBuilder = new StringBuilder();
   
        public EmployeePanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*clear all fields*/
            clearBtn();
        }

        /*ticket section's clear button*/
        private void clearBtn()
        {
            adultsNumericUpDown.Value = 1;
            childNumericUpDown.Value = 0;
            durationComboBox.SelectedIndex = 0;
            fullNameTxt.Clear();
            phoneInt.Clear();
            addressTxt.Clear();
        }

        private void EmployeePanel_Load(object sender, EventArgs e)
        {
            /*ToolTip for adult*/
            toolTip1.SetToolTip(label4, "Visitors over 12 are considered as adult.");
            toolTip1.SetToolTip(adultsNumericUpDown, "Visitors over 12 are considered as adult.");

            /*ToolTip for kids*/
            toolTip2.SetToolTip(label5, "Visitors over 5 and under 12 considered as kid.");
            toolTip2.SetToolTip(childNumericUpDown, "Visitors over 5 and under 12 considered as kid.");

            /*ToolTip for duration*/
            toolTip3.SetToolTip(label6, "Select total time period a visitor would like to spend.");

            /*adding combobox item for duration*/
            durationComboBox.Items.Insert(0, "1 Hours");
            durationComboBox.Items.Insert(1, "2 Hours");
            durationComboBox.Items.Insert(2, "3 Hours");
            durationComboBox.Items.Insert(3, "5 Hours");
            durationComboBox.Items.Insert(4, "Unlimited");

            /*validation for time i.e. disable before 9AM and after 6PM*/
            /*ToShortTimeString()*/
            var d1 = "9:00 AM";
            var d2 = "6:00 PM";
            DateTime d11;
            DateTime d22;

            var nineAm = DateTime.TryParse(d1, out d11);
            var sixPm = DateTime.TryParse(d2, out d22);

            if(DateTime.Now < d11 || DateTime.Now > d22)
            {
                MessageBox.Show("System is unavailable before 9:00 AM and after 6:00 AM. Please connect with admin for more.",
                    "System is off.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                updateBtn.Visible = false;
                label8.Text = "System is disable as of right now!";
            }
        }

        public void button2_Click(object sender, EventArgs e)
        {

            /*variables to store from employee*/
            int totalAdults = Convert.ToInt32(adultsNumericUpDown.Value);          /*store total no of adults*/
            int totalKids = Convert.ToInt32(childNumericUpDown.Value);            /*store total no of kids*/
            string fullName = fullNameTxt.Text;                                  /*store full name*/
            string phoneNo = phoneInt.Text;                                     /*store phone no*/
            string address = addressTxt.Text;                                  /*store address*/
            DateTime entryTime;                                               /*store entry time*/
            DateTime expectedExit;                                           /*store expected exit time*/
            DateTime entryDate;                                             /*store the date of visit*/
            int durationOfHours;                                           /*store total duration of hours*/
            int totalCostOfClient;                                        /*store total price*/
            int discountedPercent;                                       /*store discount percent for clients*/
            int disAmt;
            
            string disFor3Path = "C:\\Users\\gu1us\\source\\repos\\RecreationalCenter_system\\admin_folder\\discountFor3.txt";
            string disFor5Path = "C:\\Users\\gu1us\\source\\repos\\RecreationalCenter_system\\admin_folder\\discountFor5.txt";
            string disForAbove7Path = "C:\\Users\\gu1us\\source\\repos\\RecreationalCenter_system\\admin_folder\\discountForAbove5.txt";

            entryTime = DateTime.Now;
            entryDate = DateTime.Now;

            /*validation for empty filed*/
            if (fullName.Length == 0 || phoneNo.Length == 0 || address.Length == 0)
            {
                MessageBox.Show("Please fill all the text box.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                /*expected exist time of visitor will be automatically set after*/
                switch (durationComboBox.SelectedIndex)
                {
                    /*for 1 hour, increase time 1hrs*/
                    case 0:
                        expectedExit = (DateTime.Now.AddHours(1));
                        durationOfHours = 1;
                        break;
                    /*for 2 hour, increase time 2hrs*/
                    case 1:
                        expectedExit = (DateTime.Now.AddHours(2));
                        durationOfHours = 2;
                        break;
                    /*for 3 hour, increase time 3hrs*/
                    case 2:
                        expectedExit = (DateTime.Now.AddHours(3));
                        durationOfHours = 3;
                        break;
                    /*for 4 hour, increase time 4hrs*/
                    case 3:
                        expectedExit = (DateTime.Now.AddHours(4));
                        durationOfHours = 4;
                        break;
                    /*for unlimited option, increase time 6hrs for unlimited*/
                    case 4:
                        expectedExit = (DateTime.Now.AddHours(6));
                        durationOfHours = 6;
                        break;
                    /*default is triggered when nothing is selected*/
                    default:
                        expectedExit = DateTime.Now;
                        durationOfHours = 0;
                        MessageBox.Show("Time duration is not selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        clearBtn();
                        break;
                }

                SuperAdmin superAdmin = new SuperAdmin();

                /*get adult price which is set by admin*/
                int adultPriceFromAdmin = superAdmin.getAdultPrice();
                /*get child price which is set by admin*/
                int childPriceFromAdmin = superAdmin.getChildPrice();

                /*condition to give discount when there is discount ammount set by admin*/
                /*for group of adult above 3*/
                if (totalAdults >= 3 && totalAdults <= 5)
                {
                    discountedPercent = (Convert.ToInt32(File.ReadAllText(disFor3Path))) / 100;
                }
                /*for group of adult above 5*/
                else if (totalAdults > 5 && totalAdults <= 7)
                {
                    discountedPercent = (Convert.ToInt32(File.ReadAllText(disFor5Path))) / 100;
                }
                /*for group of adult above 7*/
                else if (totalAdults > 7)
                {
                    discountedPercent = (Convert.ToInt32(File.ReadAllText(disForAbove7Path))) / 100;
                }
                /*for group of adult less than 3*/
                else if (totalAdults < 3)
                {
                    discountedPercent = 0;
                }
                else
                {
                    return;
                }
                totalCostOfClient = (adultPriceFromAdmin * totalAdults) * durationOfHours +
                    (childPriceFromAdmin * totalKids) * durationOfHours;

                disAmt = discountedPercent * totalCostOfClient;

                int finalCost = totalCostOfClient - disAmt;

                MessageBox.Show(disAmt.ToString());

                /*calculation part to find total cost*/
                

                MessageBox.Show("Rs." + disAmt.ToString() + " has been provided as discount.", "Discount info", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);


                /*logic to calculate total cost*/
                /*1stly, calculate duration of time*/
                //durationOfHours = (int.Parse(expectedExit) - int.Parse(entryTime));
                /*2ndly, calculate price. Discount is automatically set by admin */


                /* upload to csv file from here, then in weekly view open from the same csv file*/
                /*create or open (if exists) xml document to store credentials*/
                var records = new List<CsvProperties>
            {
                /*write in to CsvProperties*/
                new CsvProperties {FullName = fullName,
                                    PhoneNO = phoneNo,
                                    Address = address,
                                    TotalAdults = totalAdults,
                                    TotalKids = totalKids,
                                    EntryTime = entryTime.ToShortTimeString(),
                                    Duration = durationOfHours,
                                    ExpectedExit = expectedExit.ToShortTimeString(),
                                    EntryDate = entryDate.ToShortDateString(),
                                    totalCost = totalCostOfClient,
                                    }
            };


                /*append to exsiting file in new records*/
                var config = new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    /*header is already there so only append data*/
                    HasHeaderRecord = false,
                };

                using (var stream = File.Open(csvPath, FileMode.Append))
                using (var writer = new StreamWriter(stream))
                using (var csv = new CsvWriter(writer, config))
                {
                    csv.WriteRecords(records);
                }

                /*after all the process, let employee know*/
                MessageBox.Show("Ticket has been successfully booked with total cost of Rs." + totalCostOfClient, "Ticket Booked",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearBtn();
            }

        }


        private void aboutMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutMe aboutMe = new AboutMe();
            aboutMe.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
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


        private void addressTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
