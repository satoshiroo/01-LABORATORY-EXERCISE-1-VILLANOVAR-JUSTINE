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

        public string FirstName;
        public string LastName;
        public string MiddleName;
        public string Address;
        public string Program;
    }
}
