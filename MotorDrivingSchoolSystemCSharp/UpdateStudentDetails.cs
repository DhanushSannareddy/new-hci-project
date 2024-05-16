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
    public partial class UpdateStudentDetails : Form
    {
        public UpdateStudentDetails()
        {
            InitializeComponent();
        }

        private void UpdateStudentDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'drivingDataSet3.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.drivingDataSet3.student);
            using (SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SPY\Desktop\_42315_333\MotorDrivingSchoolSystemCSharp\MotorDrivingSchoolSystemCSharp\driving.mdf;Integrated Security=True"))
            {

                string str2 = "SELECT * FROM student";
                SqlCommand cmd2 = new SqlCommand(str2, con1);
                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = new BindingSource(dt, null);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"    LLocalDB;AttachDbFilename=C:\Users\SPY\Desktop\_42315_333\MotorDrivingSchoolSystemCSharp\MotorDrivingSchoolSystemCSharp\driving.mdf;Integrated Security=True");
            con.Open();
            if (textBox1.Text != "")
            {
                try
                {
                    string getCust = "select name,gender,mobile,email,vehicle_type,batch,password from student where id=" + Convert.ToInt32(textBox1.Text) + " ;";

                    SqlCommand cmd = new SqlCommand(getCust, con);
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {                       
                        textBox2.Text = dr.GetValue(0).ToString();
                        if (dr["gender"].ToString() == "Male")
                        {
                            radioButton1.Checked = true;
                        }
                        else
                        {
                            radioButton2.Checked = true;
                        }
                        textBox3.Text = dr.GetValue(2).ToString();
                        textBox4.Text = dr.GetValue(3).ToString();
                        textBox5.Text = dr.GetValue(4).ToString();
                        textBox6.Text = dr.GetValue(5).ToString();
                        textBox7.Text = dr.GetValue(6).ToString();
                    }
                    else
                    {
                        MessageBox.Show(" Sorry, This ID, " + textBox1.Text + " Student Details Record is not Available.   ");
                        textBox1.Text = "";
                    }
                }
                catch (SqlException excep)
                {
                    MessageBox.Show(excep.Message);
                }
                con.Close();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SPY\Desktop\_42315_333\MotorDrivingSchoolSystemCSharp\MotorDrivingSchoolSystemCSharp\driving.mdf;Integrated Security=True");
            con.Open();
            string gen = string.Empty;
            if (radioButton1.Checked)
            {
                gen = "Male";
            }
            else
            {
                gen = "Female";
            }
            try
            {
                string str = " Update student set name='" + textBox2.Text + "',gender='" + gen + "',mobile='" + textBox3.Text + "',email='" + textBox4.Text + "',vehicle_type='" + textBox5.Text + "',batch='" + textBox6.Text + "',password='" + textBox7.Text + "' where id='" + textBox1.Text + "'";

                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();

                string str1 = "select max(id) from student;";

                SqlCommand cmd1 = new SqlCommand(str1, con);
                SqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("" + textBox2.Text + "'s Details is Updated Successfully.. ", "Important Message");
                    textBox2.Text = "";
                    textBox4.Text = "";
                    textBox3.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";
                    textBox1.Text = "";
                    radioButton1.Checked = true;
                    using (SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SPY\Desktop\_42315_333\MotorDrivingSchoolSystemCSharp\MotorDrivingSchoolSystemCSharp\driving.mdf;Integrated Security=True"))
                    {
                        string str2 = "SELECT * FROM student";
                        SqlCommand cmd2 = new SqlCommand(str2, con1);
                        SqlDataAdapter da = new SqlDataAdapter(cmd2);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridView1.DataSource = new BindingSource(dt, null);
                    }
                }
            }
            catch (SqlException excep)
            {
                MessageBox.Show(excep.Message);
            }
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SPY\Desktop\_42315_333\MotorDrivingSchoolSystemCSharp\MotorDrivingSchoolSystemCSharp\driving.mdf;Integrated Security=True");
                con.Open();

                string str = "DELETE FROM student WHERE id = '" + textBox1.Text + "'";

                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Delete Successfully");

                using (SqlConnection newcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SPY\Desktop\_42315_333\MotorDrivingSchoolSystemCSharp\MotorDrivingSchoolSystemCSharp\driving.mdf;Integrated Security=True"))
                {
                    string str1 = @"SELECT * from student";
                    SqlCommand cmd1 = new SqlCommand(str1, newcon);
                    SqlDataAdapter da = new SqlDataAdapter(cmd1);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = new BindingSource(dt, null);

                }
                textBox2.Text = "";
                textBox4.Text = "";
                textBox3.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox1.Text = "";
                radioButton1.Checked = true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("Please Enter student Id");
            }
        }
    }
}
