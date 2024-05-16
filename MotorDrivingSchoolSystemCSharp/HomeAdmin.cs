using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotorDrivingSchoolSystemCSharp
{
    public partial class HomeAdmin : Form
    {
        public HomeAdmin()
        {
            InitializeComponent();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 obj3 = new MotorDrivingSchoolSystemCSharp.Form1();
            obj3.ShowDialog();
        }

        private void AddTutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTutor obj = new MotorDrivingSchoolSystemCSharp.AddTutor();
            obj.ShowDialog();
        }

        private void AddStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudent obj1 = new MotorDrivingSchoolSystemCSharp.AddStudent();
            obj1.ShowDialog();
        }

        private void AssignTutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AssignTutor obj4 = new MotorDrivingSchoolSystemCSharp.AssignTutor();
            obj4.ShowDialog();
        }

        private void ViewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewStudent obj5 = new MotorDrivingSchoolSystemCSharp.ViewStudent();
            obj5.ShowDialog();
        }

       
        private void ViewTutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewTutor obj6 = new ViewTutor();
            obj6.ShowDialog();
        }
    }
}
