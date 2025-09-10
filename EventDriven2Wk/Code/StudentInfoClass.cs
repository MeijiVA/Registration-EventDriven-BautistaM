using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        //SetVar
        public static String SetFullName;
        public static long SetStudentNo;
        public static String SetProgram;
        public static String SetGender;
        public static String SetContactNo;
        public static String SetAge;
        public static String SetBirthDay;

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
            return MiddleName;
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

        public static long GetStudentNo(long StudentNo)
        {
            return StudentNo;
        }

        ///INSTANCE VARIABLES



    }
}
