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
    public partial class LoginPanel : Form
    {
        /*credintials to login only for admin */
        private string _username = "superuser";
        private string _password = "12345";
        public LoginPanel()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            /*validation for empty filed*/
            if (usernameTxt.Text.Length == 0 || passwordTxt.Text.Length == 0)
            {
                MessageBox.Show("Empty field ditected!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            /*head to main superuser session only if username and pw is correct (👇 for superuser only)*/
            else if (usernameTxt.Text == _username && passwordTxt.Text == _password)
            {
                /*firstly, hide login form*/
                this.Hide();

                /*secondly, launch admin panel*/
                SuperAdmin superpanel = new SuperAdmin();
                superpanel.ShowDialog();

                /*lastly, close login panel*/
                this.Close();

            }
            /*if ! admin, check for employee credintials from xml👇 */
            else if (usernameTxt.Text != _username || passwordTxt.Text != _password)
            {
                /*store username and password from user's input*/
                string userName = getUsrName();
                string usrPassword = getUsrPassword();

                /*process to read and compare nodes from xml*/
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load("C:/Users/gu1us/source/repos/RecreationalCenter_system/credintials.xml");

                XmlNodeList xmlNodes = xmlDoc.SelectNodes("/ArrayOfCredintials/Credintials");
                foreach (XmlNode xmlArr in xmlNodes)
                {
                    string uName = xmlArr["usrName"].InnerText;
                    string pw = xmlArr["confirmPwd"].InnerText;

                    /*check ins each nodes*/
                    if (userName == uName && usrPassword == pw)
                    {
                        /*firstly, hide login form*/
                        this.Hide();

                        /*secondly, open mainform*/
                        EmployeePanel empPanel = new EmployeePanel();
                        empPanel.ShowDialog();

                        /*lastly, close login form*/
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Unauthorized user detected!", "Unauthorized", MessageBoxButtons.RetryCancel,
                            MessageBoxIcon.Error);
                        passwordTxt.Clear();
                    }
                }
            }
            else
            {
                MessageBox.Show("Unauthorized user detected!", "Unauthorized", MessageBoxButtons.RetryCancel,
                    MessageBoxIcon.Error);
            }
        }

        /*method to clear in login fields*/
        private void clearBtn()
        {
            usernameTxt.Clear();
            passwordTxt.Clear();
        }
        /*method to get username*/
        protected string getUsrName()
        {
            return usernameTxt.Text;
        }

        /*method to get user password*/
        protected string getUsrPassword()
        {
            return passwordTxt.Text;
        }

        private void LoginPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
