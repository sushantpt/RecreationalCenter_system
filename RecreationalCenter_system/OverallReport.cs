using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecreationalCenter_system
{
    public partial class OverallReport : Form
    {
        public OverallReport()
        {
            InitializeComponent();
        }

        private void OverallReport_Load(object sender, EventArgs e)
        {
            string csvPath = "C:\\Users\\gu1us\\source\\repos\\RecreationalCenter_system\\csvFile.csv";
            dataGridView1.DataSource = File.ReadAllText(csvPath);
            splitRows();

        }

        /*method to manipulate csv*/
        public void splitRows()
        {
            string csvPath = "C:\\Users\\gu1us\\source\\repos\\RecreationalCenter_system\\csvFile.csv";


            /*store rows value in array*/
            string[] csvLines = System.IO.File.ReadAllLines(csvPath);

            /*List to store total no of visitors*/
            var totAdult = new List<int>();
            var totKids = new List<int>();
            var totEntry = new List<string>();

            /*to find total no of entries*/
            for (int i = 0; i < csvLines.Length; i++)
            {
                string[] rowData = csvLines[i].Split(',');
                totEntry.Add(rowData[0]);  /*store 1st row values in totEntry*/
            }
            totEntriesInDB.Text = (totEntry.Count - 1).ToString();


        }



        private void openAndRun(string fileLocation)
        {
            DataTable dt = new DataTable();
            string[] lines = System.IO.File.ReadAllLines(fileLocation);
            if (lines.Length > 0)
            {
                //first line to create header
                string firstLine = lines[0];
                string[] headerLabels = firstLine.Split(',');
                foreach (string headerWord in headerLabels)
                {
                    dt.Columns.Add(new DataColumn(headerWord));
                }
                //For Data
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] dataWords = lines[i].Split(',');
                    DataRow dr = dt.NewRow();
                    int columnIndex = 0;
                    foreach (string headerWord in headerLabels)
                    {
                        dr[headerWord] = dataWords[columnIndex++];
                    }
                    dt.Rows.Add(dr);
                }
            }
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*open daily report panel*/
            DailyReport dailyReport = new DailyReport();
            dailyReport.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*open weekly report panel*/
            WeeklyReport weeklyReport = new WeeklyReport();
            weeklyReport.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string fileLocation = "C:\\Users\\gu1us\\source\\repos\\RecreationalCenter_system\\csvFile.csv";
            DataTable dt = new DataTable();
            string[] lines = System.IO.File.ReadAllLines(fileLocation);
            if (lines.Length > 0)
            {
                //first line to create header
                string firstLine = lines[0];
                string[] headerLabels = firstLine.Split(',');
                foreach (string headerWord in headerLabels)
                {
                    dt.Columns.Add(new DataColumn(headerWord));
                }
                //For Data
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] dataWords = lines[i].Split(',');
                    DataRow dr = dt.NewRow();
                    int columnIndex = 0;
                    foreach (string headerWord in headerLabels)
                    {
                        dr[headerWord] = dataWords[columnIndex++];
                    }
                    dt.Rows.Add(dr);
                }
            }
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textBox1.Text = openFileDialog1.FileName;
            openAndRun(textBox1.Text);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            /*open weekly report panel*/
            WeeklyReport weeklyReport = new WeeklyReport();
            weeklyReport.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            /*open weekly report panel*/
            DailyReport dailyReport = new DailyReport();
            dailyReport.ShowDialog();
        }
    }
}
