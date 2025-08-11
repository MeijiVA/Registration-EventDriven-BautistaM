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
        public delegate long DelegateNumber(long number);
        public delegate string DelegateText(string txt);

       
    }
}
