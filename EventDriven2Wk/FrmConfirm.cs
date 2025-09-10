using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EventDriven2Wk.Code;
namespace EventDriven2Wk
{
    public partial class FrmConfirm : Form
    {

        public StudentInfoClass.DelegateText DelProgram, DelAddress, DelGender;
        public StudentInfoClass.DelegateNumber DelNumAge, DelNumContactNo, DelStudNo;
        public StudentInfoClass.DelegateName DelName;
        private void FrmConfirm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btn_Confirm_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void FrmConfirm_Load(object sender, EventArgs e)
        {
            lbl_Program.Text = DelProgram(StudentInfoClass.SetProgram);
            lbl_LName.Text = DelName(StudentInfoClass.Name);
            lbl_Age.Text = Convert.ToString(DelNumAge(StudentInfoClass._Age));
            lbl_ContNo.Text = Convert.ToString(DelNumContactNo(StudentInfoClass._ContactNo));
            lbl_StudentNo.Text = Convert.ToString(DelStudNo(StudentInfoClass._StudentNo));
            lbl_Gender.Text = DelStudNo(StudentInfoClass.SetGender.ToString());
        }

        public FrmConfirm()
        {
            InitializeComponent();
            DelProgram = new StudentInfoClass.DelegateText(StudentInfoClass.GetProgram);
            DelName = new StudentInfoClass.DelegateName(StudentInfoClass.FullName);
            DelNumAge = new StudentInfoClass.DelegateNumber(StudentInfoClass.GetAge);
            DelNumContactNo = new StudentInfoClass.DelegateNumber(StudentInfoClass.GetContactNo);
            DelStudNo = new StudentInfoClass.DelegateNumber(StudentInfoClass.GetStudentNo);
            DelGender = new StudentInfoClass.DelegateText(StudentInfoClass.GetGender);

        }
    }
}
