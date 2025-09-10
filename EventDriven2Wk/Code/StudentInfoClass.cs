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
        //given instance variables
        public static long _StudentNo;
        public static long _ContactNo;
        public static string _FullName;
        public static int _Age;
        //SetVar
        public static String SetFullName;
        public static long SetStudentNo;
        public static String SetProgram;
        public static String SetGender;
        public static long SetContactNo;
        public static int SetAge;
        public static String SetBirthday;

        //delegates

        public delegate long DelegateNumber(long number);
        public delegate string DelegateText(string txt);

        //methods
        public static String GetBirthDate(string BirthDate)
        {
            return BirthDate;
        }
        public static String GetFullName(string _FullName)
        {
            return _FullName;
        }
        public static String GetProgram(string Program)
        {
            return Program;
        }
        public static String GetGender(string Gender)
        {
            return Gender;
        }
        public static long GetAge(long Age)
        {
            return Age;
        }

        public static long GetStudentNo(long _StudentNo)
        {
            return _StudentNo;
        }
        public static long GetContactNo(long _ContactNo)
        {
            return _ContactNo;
        }

        ///INSTANCE VARIABLES

        //REGEX MUTATORS
        static public long StudentNumber(string studNum)
        {

            _StudentNo = long.Parse(studNum);

            return _StudentNo;
        }

        static public long ContactNo(string Contact)
        {
            if (Regex.IsMatch(Contact, @"^[0-9]{10,11}$"))
            {
                _ContactNo = long.Parse(Contact);
            }

            return _ContactNo;
        }

        static public string FullName(string LastName, string FirstName, string MiddleInitial)
        {
            if (Regex.IsMatch(LastName, @"^[a-zA-Z]+$") || Regex.IsMatch(FirstName, @"^[a-zA-Z]+$") || Regex.IsMatch(MiddleInitial, @"^[a-zA-Z]+$"))
            {
                _FullName = LastName + ", " + FirstName + ", " + MiddleInitial;
            }

            return _FullName;
        }

        static public int Age(string age)
        {
            if (Regex.IsMatch(age, @"^[0-9]{1,3}$"))
            {
                _Age = Int32.Parse(age);
            }

            return _Age;
        }

    }
}
