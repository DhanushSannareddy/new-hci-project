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
    public partial class AssignTutor : Form
    {
        public AssignTutor()
        {
            InitializeComponent();
        }

        private void AssignTutor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'drivingDataSet5.assign_tutor' table. You can move, or remove it, as needed.
            this.assign_tutorTableAdapter.Fill(this.drivingDataSet5.assign_tutor);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SPY\Desktop\_42315_333\MotorDrivingSchoolSystemCSharp\MotorDrivingSchoolSystemCSharp\driving.mdf;Integrated Security=True");
            con.Open();
            
            try
            {
                string str = "INSERT INTO assign_tutor(student_id,name,date,vehicle_type,start_date,end_date,tutor_name,batch,time) VALUES('" + textBox1.Text + "','" + textBox2.Text  + "','" + textBox4.Text + "','" + textBox3.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "'); ";

                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();

                string str1 = "select max(Id) from assign_tutor;";

                SqlCommand cmd1 = new SqlCommand(str1, con);
                SqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Inserted Assign Tutor Information Successfully..");
                    textBox2.Text = "";
                    textBox1.Text = "";
                    textBox4.Text = "";
                    textBox3.Text = "";
                    textBox8.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";
                    textBox8.Text = "";
                    textBox9.Text = "";
                    textBox10.Text = "";
                }
            }
            catch (SqlException excep)
            {
                MessageBox.Show(excep.Message);
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox1.Text = "";
            textBox4.Text = "";
            textBox3.Text = "";
            textBox8.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
        }
    }
}
