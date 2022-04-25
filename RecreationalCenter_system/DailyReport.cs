using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;

namespace RecreationalCenter_system
{
    public partial class DailyReport : Form
    {
        public string path = "C:\\Users\\gu1us\\source\\repos\\RecreationalCenter_system\\csvFile.csv";
        public DailyReport()
        {
            InitializeComponent();
        }

        private void WeeklyReport_Load(object sender, EventArgs e)
        {
            label1.Text = "Showing report of " + (DateTime.Now).ToLongDateString();

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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OverallReport overallReport = new OverallReport();
            overallReport.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            WeeklyReport weeklyReport = new WeeklyReport();
            weeklyReport.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            refereshDataGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            refereshDataGrid();
        }

        /*method to refresh csv data in datagrid view*/
        private void refereshDataGrid()
        {
            string fileLocation = "C:\\Users\\gu1us\\source\\repos\\RecreationalCenter_system\\csvFile.csv";
            DataTable dt = new DataTable();
            string[] lines = System.IO.File.ReadAllLines(fileLocation);
            if (lines.Length > 0)
            {
                /*first line to create header*/
                string firstLine = lines[0];
                string[] headerLabels = firstLine.Split(',');
                foreach (string headerWord in headerLabels)
                {
                    dt.Columns.Add(new DataColumn(headerWord));
                }
                /*For Data*/
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
                dataGridViewDaily.DataSource = dt;
                dataGridView1.DataSource = dt;
                dataGridView2.DataSource = dt;
            }
        }
    }
}
