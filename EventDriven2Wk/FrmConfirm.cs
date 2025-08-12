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

        public StudentInfoClass.DelegateText DelProgram, DelLastName, DelFirstName, DelMiddleName, DelAddress;
        public StudentInfoClass.DelegateNumber DelNumAge, DelNumContactNo, DelStudNo;
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
            lbl_Program.Text = DelProgram(StudentInfoClass.Program);
            lbl_LName.Text = DelLastName(StudentInfoClass.LastName);
            lbl_FName.Text = DelFirstName(StudentInfoClass.FirstName);
            lbl_MName.Text = DelMiddleName(StudentInfoClass.MiddleName);
            lbl_Address.Text = DelAddress(StudentInfoClass.Address);
            lbl_Age.Text = Convert.ToString(DelNumAge(StudentInfoClass.Age));
            lbl_ContNo.Text = Convert.ToString(DelNumContactNo(StudentInfoClass.ContactNo));
            lbl_StudentNo.Text = Convert.ToString(DelStudNo(StudentInfoClass.StudentNo));
        }

        public FrmConfirm()
        {
            InitializeComponent();
            DelProgram = new StudentInfoClass.DelegateText(StudentInfoClass.GetProgram);
            DelLastName = new StudentInfoClass.DelegateText(StudentInfoClass.GetLastName);
            DelFirstName = new StudentInfoClass.DelegateText(StudentInfoClass.GetFirstName);
            DelMiddleName = new StudentInfoClass.DelegateText(StudentInfoClass.GetMiddleName);
            DelAddress = new StudentInfoClass.DelegateText(StudentInfoClass.GetAddress);
            DelNumAge = new StudentInfoClass.DelegateNumber(StudentInfoClass.GetAge);
            DelNumContactNo = new StudentInfoClass.DelegateNumber(StudentInfoClass.GetContactNo);
            DelStudNo = new StudentInfoClass.DelegateNumber(StudentInfoClass.GetStudentNo);

        }
    }
}
