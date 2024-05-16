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
    public partial class HomeStudent : Form
    {
        public HomeStudent()
        {
            InitializeComponent();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 obj3 = new MotorDrivingSchoolSystemCSharp.Form1();
            obj3.ShowDialog();
        }

        private void ViewAssignedTutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewAssignedTutor obj2 = new MotorDrivingSchoolSystemCSharp.ViewAssignedTutor();
            obj2.ShowDialog();
        }

        private void UpdateStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateStudentDetails obj1 = new MotorDrivingSchoolSystemCSharp.UpdateStudentDetails();
            obj1.ShowDialog();
        }
    }
}
