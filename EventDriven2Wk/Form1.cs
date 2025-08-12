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


namespace EventDriven2Wk
{
    public partial class Form1 : Form
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


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cBox_Program.Items.Add("Bachelor in Science of Information Technology");
            cBox_Program.Items.Add("Bachelor in Science of Computer Science");
            cBox_Program.Items.Add("Bachelor in Science of Business Administration");
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }



        /// 
        /// TextBox Press
        /// 

        private void tBox_StudNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tBox_Age_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void tBox_ContNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void tBox_LName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void tBox_FName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void tBox_MName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            StudentInfoClass.FirstName = tBox_FName.Text.ToString();
            StudentInfoClass.LastName = tBox_LName.Text.ToString();
            StudentInfoClass.MiddleName = tBox_MName.Text.ToString();
            StudentInfoClass.Address = tBox_Address.Text.ToString();
            StudentInfoClass.Program = cBox_Program.Text.ToString();
            StudentInfoClass.Age = (long)Convert.ToDouble(tBox_Age.Text);
            StudentInfoClass.ContactNo = (long)Convert.ToDouble(tBox_ContNo.Text);
            StudentInfoClass.StudentNo = (long)Convert.ToDouble(tBox_StudNum.Text);
            FrmConfirm frm = new FrmConfirm();
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
            }
        }
    }
}
