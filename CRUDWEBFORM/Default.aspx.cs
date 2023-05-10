/*using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Web.UI.WebControls;
using System.Web.Optimization;

namespace CRUDWEBFORM
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            *//*SqlConnection conn = new SqlConnection("Data Source=DESKTOP-7JKTAF5\\MSSQLSERVER01;Initial Catalog=WEBFORM;Integrated Security=True ");
            conn.Open();
            SqlConnection comm = new SqlConnection("Insert into StudentTab values('" + int.Parse(TextBox1.Text) + "','" +TextBox2.Text+ "','"+TextBox3.Text+"','"+TextBox4.Text+"','"+TextBox5.Text+"')",conn);
            comm.ExecuteNonQuery();
           ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert(Successfully Inserted👍);", true);
            conn.Open();*//*

            string con = "Data Source=DESKTOP-7JKTAF5\\MSSQLSERVER01;Initial Catalog =WEBFORM;Integrated Security=True";
            SqlConnection db = new SqlConnection(con);
            db.Open();
            string insert = "insert into tbl_user (StudentID, StudentName, Address, Age, Contact) values ('" + int.Parse(TextBox1.Text) + "','" +TextBox2.Text+ "','"+TextBox3.Text+"','"+TextBox4.Text+"','"+TextBox5.Text+"' )";
            SqlCommand cmd = new SqlCommand(insert, db);
            int m = cmd.ExecuteNonQuery();
            if (m != 0)
            {
                Response.Write("" +
                    "<script>alert('Data Inserted !!')</script>" +
                    "");  
            }
            else
            {
                Response.Write("" +
                    "<script>alert('Data Inserted !!')</script>" +
                    "");  
            }
            db.Close();








            /*SqlCommand comm = new SqlCommand("INSERT INTO StudentInfo_Tab VALUES (@StudentID, @StudentName, @Address, @Age, @Contact)", conn);
            comm.Parameters.AddWithValue("@StudentID", int.Parse(TextBox1.Text));
            comm.Parameters.AddWithValue("@StudentName", TextBox2.Text);
            comm.Parameters.AddWithValue("@Address", TextBox3.Text);
            comm.Parameters.AddWithValue("@Age", TextBox4.Text);
            comm.Parameters.AddWithValue("@Contact", TextBox5.Text);
            comm.ExecuteNonQuery();
            conn.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully Inserted👍');", true);
        }
    }
}
*/
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRUDWEBFORM
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadRecord();
            }
           // Response.AddHeader("Refresh", "3");
        }
        public readonly SqlConnection conn = new SqlConnection("Data Source=DESKTOP-7JKTAF5\\MSSQLSERVER01;Initial Catalog=WEBFORM;Integrated Security=True");
        protected void Button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand comm = new SqlCommand("INSERT INTO students VALUES (@StudentName, @Address, @Age, @Contact)", conn);
            comm.Parameters.AddWithValue("@StudentName", TextBox2.Text);
            comm.Parameters.AddWithValue("@Address", TextBox3.Text);
            comm.Parameters.AddWithValue("@Age", TextBox4.Text);
            comm.Parameters.AddWithValue("@Contact", TextBox5.Text);
            comm.ExecuteNonQuery();
            conn.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script" ,"alert('Successfully Inserted👍');", true);
            LoadRecord();   
        }
        void LoadRecord()
        {
            SqlCommand comm = new SqlCommand("select *from student",conn);
            SqlDataAdapter d=new SqlDataAdapter(comm);
            DataTable dt = new DataTable(); 
            d.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand comm = new SqlCommand("UPDATE students SET StudentName =  (@StudentName, @Address, @Age, @Contact)", conn);
            comm.Parameters.AddWithValue("@StudentName", TextBox2.Text);
            comm.Parameters.AddWithValue("@Address", TextBox3.Text);
            comm.Parameters.AddWithValue("@Age", TextBox4.Text);
            comm.Parameters.AddWithValue("@Contact", TextBox5.Text);
            comm.ExecuteNonQuery();
            conn.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script" ,"alert('Successfully Updated👍');", true);
            LoadRecord();

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            /*SqlConnection comm = new SqlConnection("Delete into Student values where studentID= + int.Parse(TextBox1.Text)", conn);*/
            SqlCommand comm = new SqlCommand("DELETE FROM student WHERE studentID=@studentID", conn);
            comm.Parameters.AddWithValue("@studentName", TextBox2.Text);
            comm.ExecuteNonQuery();
            conn.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully Deleted👍');", true);
            LoadRecord();


        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            SqlCommand comm = new SqlCommand("select *from student where studentID= + int.Parse(TextBox1.Text)", conn);
            SqlDataAdapter d = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            d.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void Button_5Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand comm = new SqlCommand("Select *From student where studentID= + int.Parse(TextBox1.Text)", conn);
            SqlDataReader r= comm.ExecuteReader();
            while(r.Read())
            {
                TextBox2.Text = r.GetValue(1).ToString();
                TextBox3.Text = r.GetValue(2).ToString();
                TextBox4.Text = r.GetValue(3).ToString();
                TextBox5.Text = r.GetValue(4).ToString();

            }
        }
    }
}
