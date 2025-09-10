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
        public long _StudentNo;
        public long _ContactNo;
        public string _FullName;
        public int _Age;
        public static String FirstName = " ";
        public static String LastName = " ";
        public static String MiddleName = " ";
        public static String Address = " ";
        public static String Program = " ";

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

        //REGEX MUTATORS
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


    }
}
