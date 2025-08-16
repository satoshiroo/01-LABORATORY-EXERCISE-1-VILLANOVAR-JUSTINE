using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static _01_LABORATORY_EXERCISE_1_VILLANOVAR_JUSTINE.StudentInfoClass;


namespace _01_LABORATORY_EXERCISE_1_VILLANOVAR_JUSTINE
{
    public partial class Form2 : Form
    {
        private DelegateText DelProgram, DelLastName, DelFirstName, DelMiddleName, DelAddress;
        private DelegateNumber DelNumAge, DelNumContactNo, DelStudNo;

        public Form2()
        {
            InitializeComponent();
            DelProgram = new DelegateText(StudentInfoClass.getProgram);
            DelLastName = new DelegateText(StudentInfoClass.getLastName);
            DelFirstName = new DelegateText(StudentInfoClass.getFirstName);
            DelMiddleName = new DelegateText(StudentInfoClass.getMiddleName);
            DelAddress = new DelegateText(StudentInfoClass.getAddress);

            DelNumAge = new DelegateNumber(StudentInfoClass.getAge);
            DelNumContactNo = new DelegateNumber(StudentInfoClass.getContactNum);
            DelStudNo = new DelegateNumber(StudentInfoClass.getStudentNUm);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
