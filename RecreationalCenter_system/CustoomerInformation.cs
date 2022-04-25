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
    public partial class CustoomerInformation : Form
    {
        public CustoomerInformation()
        {
            InitializeComponent();
        }

        private void EmployeeInformation_Load(object sender, EventArgs e)
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
                dataGridView1.DataSource = dt;
            }
        }
    }
}
