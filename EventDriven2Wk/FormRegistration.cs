using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using EventDriven2Wk.Code;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace EventDriven2Wk
{
    public partial class FormRegistration : Form
    {

        public Point mouseLoc;
        public Point bottleMouse;
        private void lbl_textRegisMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)//checks if left mouse button is held or pressed : D
            {
                Point mousePose = Control.MousePosition;//point var of mouse cursor from topleft corner of sccreen
                mousePose.Offset(mouseLoc.X, mouseLoc.Y);//translates point depending on the location of mouseLoc
                Location = mousePose;//forms location is moved depending on the location of the point variable 
            }
        }

        private void lbl_textRegisDown(object sender, MouseEventArgs e)
        {
            mouseLoc = new Point(-e.X, -e.Y);
        }


        public FormRegistration()
        {
            InitializeComponent();
        }

        public long _StudentNo;
        public long _ContactNo;
        public string _FullName;
        public int _Age;
        ///INSTANCE VARIABLES

        //REGEX GIVEN
        public long StudentNumber(string studNum)
        {

            _StudentNo = long.Parse(studNum);

            return _StudentNo;
        }

        public long ContactNo(string Contact)
        {
            if (Regex.IsMatch(Contact, @"^[0-9]{10,11}$"))
            {
                _ContactNo = long.Parse(Contact);
            }

            return _ContactNo;
        }

        public string FullName(string LastName, string FirstName, string MiddleInitial)
        {
            if (Regex.IsMatch(LastName, @"^[a-zA-Z]+$") || Regex.IsMatch(FirstName, @"^[a-zA-Z]+$") || Regex.IsMatch(MiddleInitial, @"^[a-zA-Z]+$"))
            {
                _FullName = LastName + ", " + FirstName + ", " + MiddleInitial;
            }

            return _FullName;
        }

        public int Age(string age)
        {
            if (Regex.IsMatch(age, @"^[0-9]{1,3}$"))
            {
                _Age = Int32.Parse(age);
            }

            return _Age;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //STEP 8
            string[] ListOfProgram = new string[]
            {
                "BS Information Technology",
                "BS Computer Science",
                "BS Information Systems",
                "BS in Accountancy",
                "BS in Hospitality Management",
                "BS in Tourism Management"
            };

            for(int i = 0; i < 6; i++)
            {
                cBox_Program.Items.Add(ListOfProgram[i].ToString());
            }

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }



        /// 
        /// TextBox Press
        /// 


        private void btn_Next_Click(object sender, EventArgs e)
        {
            //StudentNumber,  FullName, Age Methods are missing, insert this

            //CHALLENGE STEP 13 
            try
            {
                StudentInfoClass.FirstName = tBox_FName.Text.ToString();
                StudentInfoClass.LastName = tBox_LName.Text.ToString();
                StudentInfoClass.MiddleName = tBox_MName.Text.ToString();
                StudentInfoClass.Address = tBox_Address.Text.ToString();
                StudentInfoClass.Program = cBox_Program.Text.ToString();
                StudentInfoClass.Age = (long)Convert.ToDouble(tBox_Age.Text);
                StudentInfoClass.ContactNo = (long)Convert.ToDouble(tBox_ContNo.Text);
                StudentInfoClass.StudentNo = (long)Convert.ToDouble(tBox_StudNum.Text);
            }
            catch(Exception ex)
            {

            }
            finally
            {

            }

            FrmConfirm frm = new FrmConfirm();
            this.Hide();
            if(frm.ShowDialog().Equals(DialogResult.OK))
            {
                tBox_FName.Text = "";
                tBox_LName.Text = "";
                tBox_MName.Text = "";
                tBox_Address.Text = "";
                cBox_Program.Text = "";
                tBox_Age.Text = "";
                tBox_ContNo.Text = "";
                tBox_StudNum.Text = "";
                this.Show();
            }
        }














        private void tBox_Address_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
