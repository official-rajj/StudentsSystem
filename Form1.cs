using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnregis_Click(object sender, EventArgs e)
        {
            string constring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Aditya Raj\\source\\repos\\StudentsSystem\\registerdetails.mdf\";Integrated Security=True";
            string query = "INSERT INTO Registration(ID,NAME,BRANCH,SEMESTER,CITY,GENDER,CHOICE) VALUES(@ID,@NAME,@BRANCH,@SEMESTER,@CITY,@GENDER,@CHOICE)";
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@ID",txtid.Text);
            cmd.Parameters.AddWithValue("@NAME", txtname.Text);
            cmd.Parameters.AddWithValue("@BRANCH", txtbranch.Text);
            cmd.Parameters.AddWithValue("@SEMESTER", txtsem.Text);
            cmd.Parameters.AddWithValue("@CITY", txtcity.Text);
            cmd.Parameters.AddWithValue("@GENDER", rbtnmale.Checked ? "Male" : "Female");
            cmd.Parameters.AddWithValue("@CHOICE", rbtnnet.Checked ? "ASP.NET" : "C#");
            cmd.ExecuteNonQuery();
            MessageBox.Show("Register Successfully\nName: ADITYA RAJ\nEnrollment No: 22SOECE11171");
            MessageBox.Show("Name: ADITYA RAJ\nEnrollment No: 22SOECE11171");
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string constring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Aditya Raj\\source\\repos\\StudentsSystem\\registerdetails.mdf\";Integrated Security=True";
            string query = "UPDATE Registration SET NAME=@NAME, BRANCH=@BRANCH, SEMESTER=@SEMESTER, CITY=@CITY, GENDER=@GENDER, CHOICE=@CHOICE WHERE ID=@ID";
            using (SqlConnection con = new SqlConnection(constring))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ID", txtid.Text);
                    cmd.Parameters.AddWithValue("@NAME", txtname.Text);
                    cmd.Parameters.AddWithValue("@BRANCH", txtbranch.Text);
                    cmd.Parameters.AddWithValue("@SEMESTER", txtsem.Text);
                    cmd.Parameters.AddWithValue("@CITY", txtcity.Text);
                    cmd.Parameters.AddWithValue("@GENDER", rbtnmale.Checked ? "Male" : "Female");
                    cmd.Parameters.AddWithValue("@CHOICE", rbtnnet.Checked ? "ASP.NET" : "C#");
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Record Updated Successfully\nName: ADITYA RAJ\nEnrollment No: 22SOECE11171");
            MessageBox.Show("Name: ADITYA RAJ\nEnrollment No: 22SOECE11171");
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            string constring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Aditya Raj\\source\\repos\\StudentsSystem\\registerdetails.mdf\";Integrated Security=True";
            string query = "DELETE FROM Registration WHERE ID=@ID";
            using (SqlConnection con = new SqlConnection(constring))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ID", txtid.Text);
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Record Deleted Successfully\nName: ADITYA RAJ\nEnrollment No: 22SOECE11171");
            MessageBox.Show("Name: ADITYA RAJ\nEnrollment No: 22SOECE11171");
        }

        private void btndisplay_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Registration";
            string constring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Aditya Raj\\source\\repos\\StudentsSystem\\registerdetails.mdf\";Integrated Security=True";
            using (SqlConnection con = new SqlConnection(constring))
            {
                con.Open();
                using (SqlDataAdapter da = new SqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt; 
                }
            }
        }
    }
}
