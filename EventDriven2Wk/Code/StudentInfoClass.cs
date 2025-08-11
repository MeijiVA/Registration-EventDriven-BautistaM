using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDriven2Wk.Code
{
    internal class StudentInfoClass
    {
        // static var
        static String FirstName = " ";
        static String LastName = " ";
        static String MiddleName = " ";
        static String Address = " ";
        static String Program = " ";
        long Age = 0;
        long ContactNo = 0;
        long StudentNo = 0;

        //delegates

        public delegate long DelegateNumber(long number);
        public delegate string DelegateText(string txt);

       //methods
       static String GetFirstName(string FirstName)
        {
            return FirstName;
        }
        static String GetLastName(string LastName)
        {
            return LastName;
        }
        static String GetMiddleName(string MiddleName)
        {
            return FirstName;
        }
        static String GetAddress(string Address)
        {
            return Address;
        }
        static String GetProgram(string Program)
        {
            return Program;
        }
        static long GetAge(long Age)
        {
            return Age;
        }
        static long GetContactNo(long ContactNo)
        {
            return ContactNo;
        }
        static long GetStudentNo(long StudentNo)
        {
            return StudentNo;
        }
    }
}
