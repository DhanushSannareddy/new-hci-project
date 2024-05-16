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
    public partial class HomeTutor : Form
    {
        public HomeTutor()
        {
            InitializeComponent();
        }

        private void UpdateTutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateTutorDetails obj = new UpdateTutorDetails();
            obj.ShowDialog();
        }

        private void ViewAssignedStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewAssignedTutor obj1 = new MotorDrivingSchoolSystemCSharp.ViewAssignedTutor();
            obj1.ShowDialog();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 obj3 = new MotorDrivingSchoolSystemCSharp.Form1();
            obj3.ShowDialog();
        }
    }
}
