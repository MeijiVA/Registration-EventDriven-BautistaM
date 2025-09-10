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
        //CUSTOM EXCEPTIONS
        public class WrongNameFormatException : Exception
        {
            public WrongNameFormatException(string message) : base(message)
            {

            }
        }

        public class ContactNumberFormatException : Exception
        {
            public ContactNumberFormatException(string message) : base(message)
            {

            }
        }
        public class MaxAgeException : Exception
        {
            public MaxAgeException(string message) : base(message)
            {

            }
        }

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
            string[] ListOfGender = new string[]
            {
                "Male","Female"
            };

            for (int i = 0; i < 2; i++)
            {
                cbox_Gender.Items.Add(ListOfGender[i].ToString());
            }
            for (int i = 0; i < 6; i++)
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
                //STEP 10
                StudentInfoClass.SetStudentNo = StudentInfoClass.StudentNumber(tBox_StudNum.Text);
                StudentInfoClass.SetProgram = cBox_Program.Text;
                StudentInfoClass.SetGender = cbox_Gender.Text;
                StudentInfoClass.SetBirthday = datePickerBirthday.Value.ToString("yyyy-MM-dd");
                StudentInfoClass.SetContactNo = StudentInfoClass.ContactNo(tBox_ContNo.Text);
                StudentInfoClass.SetFullName = StudentInfoClass.FullName(tBox_LName.Text, tBox_FName.Text, tBox_MName.Text);
                StudentInfoClass.SetAge = StudentInfoClass.Age(tBox_Age.Text);


                if (StudentInfoClass.SetFullName.Equals(""))
                {
                    throw new WrongNameFormatException("Wrong Name Format, please do not apply Special Characters");
                }
                else if (StudentInfoClass.SetContactNo == 0)
                {
                    throw new ContactNumberFormatException("Wrong Contact Number Format");
                }
                else if (StudentInfoClass.SetAge == 0)
                {
                    throw new MaxAgeException("Your Inputted Age is higher than the span of Human Life.");
                }
                else
                {
                    ///Show form
                    FrmConfirm frm = new FrmConfirm();
                    this.Hide();
                    if (frm.ShowDialog().Equals(DialogResult.OK))
                    {
                         tBox_FName.Text = "";
                         tBox_LName.Text = "";
                         tBox_MName.Text = "";
                         cBox_Program.Text = "";
                         tBox_Age.Text = "";
                         tBox_ContNo.Text = "";
                         tBox_StudNum.Text = "";
                         cbox_Gender.Text = "";
                        this.Show();
                    }

                }

            }
            catch(FormatException ex)
            {
                MessageBox.Show("Format is Unavailable");
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show("Arguement is Null");
            }
            catch (OverflowException ex)
            {
                MessageBox.Show("Value of Variable Exceeds the given Data Type");
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show("Chosen Index is more then it's number");
            }
            catch (WrongNameFormatException ex)
            {
                MessageBox.Show(ex.Message);//special message inputted in if statement
            }
            catch (ContactNumberFormatException ex)
            {
                MessageBox.Show(ex.Message); //special message inputted in if statement
            }
            catch (MaxAgeException ex)
            {
                MessageBox.Show(ex.Message);//special message inputted in if statement
            }
            finally
            {
                StudentInfoClass.SetAge = 0;
                StudentInfoClass.SetStudentNo = 0;
                StudentInfoClass.SetContactNo = 0;
                StudentInfoClass.SetFullName = null;
                StudentInfoClass.SetProgram = null;
                StudentInfoClass.SetGender = null;
                StudentInfoClass.SetBirthday = null;
            }



        }














        private void tBox_Address_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
