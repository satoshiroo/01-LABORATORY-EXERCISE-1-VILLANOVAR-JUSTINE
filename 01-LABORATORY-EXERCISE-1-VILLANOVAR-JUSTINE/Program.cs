using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_LABORATORY_EXERCISE_1_VILLANOVAR_JUSTINE
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

    }

    public class StudentInfoClass
    {
        public delegate long DelegateNumber(long num);
        public delegate string DelegateText(string text);

        public static string FirstName;
        public static string LastName;
        public static string MiddleName;
        public static string Address;
        public static string Program;
        public static long Age;
        public static long ContactNum;
        public static long StudentNum;


        public static string getFirstName(string fName)
        {
            return FirstName;
        }
        public static string getLastName(string fName)
        { return LastName;
        }
        public static string getMiddleName(string mName)
        {
            return MiddleName;
        }
        public static string getAddress(string address)
        {
            return Address;
        }
        public static string getProgram(string program)
        {
            return Program;
        }
        public static long getAge(long age)
        {
            return Age;
        }
        public static long getContactNum(long contactNum)
        {
            return ContactNum;
        }
        public static long getStudentNUm(long studentNum)
        {
            return StudentNum;
        }
    }
}
