using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MotorDrivingSchoolSystemCSharp
{
    public partial class ViewTutor : Form
    {
        public ViewTutor()
        {
            InitializeComponent();
        }

        private void ViewTutor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'drivingDataSet.tutor' table. You can move, or remove it, as needed.
            this.tutorTableAdapter.Fill(this.drivingDataSet.tutor);
            using (SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SPY\Desktop\_42315_333\MotorDrivingSchoolSystemCSharp\MotorDrivingSchoolSystemCSharp\driving.mdf;Integrated Security=True"))
            {

                string str2 = "SELECT * FROM tutor";
                SqlCommand cmd2 = new SqlCommand(str2, con1);
                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = new BindingSource(dt, null);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SPY\Desktop\_42315_333\MotorDrivingSchoolSystemCSharp\MotorDrivingSchoolSystemCSharp\driving.mdf;Integrated Security=True"))
            {

                string str2 = "SELECT * FROM tutor where id='"+textBox1.Text +"'";
                SqlCommand cmd2 = new SqlCommand(str2, con1);
                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = new BindingSource(dt, null);
            }
        }
    }
}
