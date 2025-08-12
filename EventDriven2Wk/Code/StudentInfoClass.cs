using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDriven2Wk.Code
{
    public class StudentInfoClass
    {
        // static var
        public static String FirstName = " ";
        public static String LastName = " ";
        public static String MiddleName = " ";
        public static String Address = " ";
        public static String Program = " ";
        public static long Age = 0;
        public static long ContactNo = 0;
        public static long StudentNo = 0;

        //delegates

        public delegate long DelegateNumber(long number);
        public delegate string DelegateText(string txt);

       //methods
       public static String GetFirstName(string FirstName)
        {
            return FirstName;
        }
        public static String GetLastName(string LastName)
        {
            return LastName;
        }
        public static String GetMiddleName(string MiddleName)
        {
            return FirstName;
        }
        public static String GetAddress(string Address)
        {
            return Address;
        }
        public static String GetProgram(string Program)
        {
            return Program;
        }
        public static long GetAge(long Age)
        {
            return Age;
        }
        public static long GetContactNo(long ContactNo)
        {
            return ContactNo;
        }
        public static long GetStudentNo(long StudentNo)
        {
            return StudentNo;
        }
    }
}
