using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace RecreationalCenter_system
{
    public partial class AboutMe : Form
    {
        public AboutMe()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AboutMe_Load(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            /*process to read and compare nodes from xml*/
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("C:/Users/gu1us/source/repos/RecreationalCenter_system/credintials.xml");

            XmlNodeList xmlNodes = xmlDoc.SelectNodes("/ArrayOfCredintials/Credintials");
            foreach (XmlNode xmlArr in xmlNodes)
            {
                string empFullName = xmlArr["usrFullName"].InnerText;
                string empUsrName = xmlArr["usrName"].InnerText;
                string empEmail = xmlArr["usrEmail"].InnerText;
                string empPhone = xmlArr["usrPhoneNo"].InnerText;

                empNameTxt.Text = empFullName;
                empUsernameTxt.Text = empUsrName;
                empEmailTxt.Text = empEmail;
                empPhoneTxt.Text = empPhone;

                /*when checking, if about me is triggered, inform user or when credintials is not available*/
                if(string.IsNullOrEmpty(empFullName) || string.IsNullOrEmpty(empUsrName) 
                    || string.IsNullOrEmpty(empEmail) || string.IsNullOrEmpty(empPhone))
                {
                    empNameTxt.Text = "?";
                    empUsernameTxt.Text = "?";
                    empEmailTxt.Text = "?";
                    empPhoneTxt.Text = "?";
                    MessageBox.Show("Batchmode is enabled!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }
    }
}
