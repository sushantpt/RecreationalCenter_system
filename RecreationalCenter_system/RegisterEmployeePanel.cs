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
using System.Xml.Serialization;


/*this class is used to register new employee. Access is only given to super admin*/

namespace RecreationalCenter_system
{
    public partial class RegisterEmployeePanel : Form
    {
        List<Credintials> signUpCredentials;  // list to store credintials
        XmlSerializer xmlSerializer;    // ensure how xml objects are encoded in xml
        public RegisterEmployeePanel()
        {
            InitializeComponent();
            /*initialize new credintials list to store*/
            signUpCredentials = new List<Credintials>();
            /*initialize new serializer of Credintials.cs's properties*/
            xmlSerializer = new XmlSerializer(typeof(List<Credintials>));
        }

        /*method is called when button is pressed*/
        private void clearFields_Click(object sender, EventArgs e)
        {
            /*first, ask for confirmation (in Dialog box)*/
            /* dialog box for clear all confirmation*/
            DialogResult dialogBox = MessageBox.Show("Clear all fields?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogBox == DialogResult.Yes)
            {
                clearBtn();
            }
            else
            {
                return;
            }
        }

        /*method to clear text fields*/
        private void clearBtn()
        {
            fullNameTxt.Clear();
            userNameTxt.Clear();
            emailTxt.Clear();
            phoneInt.Clear();
            addressTxt.Clear();
            newPwTxt.Clear();
            confirmPwdTxt.Clear();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            /*if there is a employee who is already registered, inform admin*/
            /*process to read and compare nodes from xml*/
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("C:/Users/gu1us/source/repos/RecreationalCenter_system/credintials.xml");

            XmlNodeList xmlNodes = xmlDoc.SelectNodes("/ArrayOfCredintials/Credintials");
            foreach (XmlNode xmlArr in xmlNodes)
            {
                /*main logic to check if there is Credintials and data in it*/
                if (xmlArr["usrFullName"].InnerText.Contains("") || xmlArr["usrName"].InnerText.Contains("")
                    || xmlArr["usrEmail"].InnerText.Contains("") || xmlArr["usrPhoneNo"].InnerText.Contains("")
                    || xmlArr["usrAddress"].InnerText.Contains("") || xmlArr["confirmPwd"].InnerText.Contains("") )
                {
                    DialogResult dialogResult = MessageBox.Show("There is a employee who is already registered. Delete current employee?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(dialogResult == DialogResult.Yes)
                    {
                        File.Delete("C://Users//gu1us//source//repos//RecreationalCenter_system//credintials.xml");
                        MessageBox.Show("Current employee is deleted and new employee will be registered in further steps.", "Deleted and Registered", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

                DialogResult dialogBox2 = MessageBox.Show("Valid information?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogBox2 == DialogResult.Yes)
            {
                /* user clicks yes, system check for basic validation*/
                if (fullNameTxt.Text.Length > 6 && userNameTxt.Text.Length > 4
                    && emailTxt.Text.Length > 8 && phoneInt.Text.Length > 9 && addressTxt.Text.Length > 5)
                {
                    /*check if the new password and the confirm password matched, if matched then head over to login panel*/
                    if (newPwTxt.Text == confirmPwdTxt.Text)
                    {
                        /*Sign up architecture*/

                        /*create or open (if exists) xml document to store credentials*/
                        string xmlPath = "C:\\Users\\gu1us\\source\\repos\\RecreationalCenter_system\\credintials.xml";
                        using (StreamWriter fs = File.AppendText(xmlPath))
                        {

                            //FileStream fileStream = new FileStream("C:/Users/gu1us/source/repos/Coursework1/credintials.xml", 
                            //FileMode.OpenOrCreate, FileAccess.Write);

                            /*initialize Credintials class for its property*/
                            Credintials credintials = new Credintials();
                            /*assign values in credintials's properties*/
                            credintials.usrFullName = fullNameTxt.Text;
                            credintials.usrName = userNameTxt.Text;
                            credintials.usrEmail = emailTxt.Text;
                            credintials.usrPhoneNo = phoneInt.Text;
                            credintials.usrAddress = addressTxt.Text;
                            credintials.usrNewPwd = newPwTxt.Text;
                            credintials.confirmPwd = confirmPwdTxt.Text;

                            signUpCredentials.Add(credintials); // store every credintials in signUpCredintials list

                            xmlSerializer.Serialize(fs, signUpCredentials); // write in file stream (xml doc)
                            fs.Close(); // after all process, close file stream
                        }

                        /*end of sign up architecture*/

                        /*  tell superadmin they have successfully registered new admin*/
                        DialogResult dialogBox5 = MessageBox.Show("New employee has been registered successfully. ", "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        /*clear all fields after succession*/
                        clearBtn();
                    }
                    /* password didnt matched then ...*/
                    else
                    {
                        DialogResult dialogBox3 = MessageBox.Show("Password Unmatched!", "Security",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                }
                /*system check for basic validation, if any thing didn't go as mentioned then show message*/
                else
                {
                    DialogResult dialogBox4 = MessageBox.Show("Please enter valid information!", "Error",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }
            else
            {
                return;
            }
        }

        private void RegisterEmployeePanel_Load(object sender, EventArgs e)
        {

        }
    }
}
