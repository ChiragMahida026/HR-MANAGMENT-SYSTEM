using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HR_MANAGMENT_SYSTEM
{
    public partial class ManageProject : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (checkIfProjectExists())
            {
                Response.Write("<script>alert('Project with this ID already Exist. You cannot add another Project with the same Project ID');</script>");
            }
            else
            {
                addNewProject();
            }
        }

        void addNewProject()
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=F:\HR MANAGMENT SYSTEM\HR MANAGMENT SYSTEM\App_Data\Database1.mdf;Integrated Security=True;User Instance=True");


                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                SqlCommand cmd = new SqlCommand("INSERT INTO tbl_Project(Pid,Pname,Client_name,Client_Contact_no,Budget,Deadlines) values(@Pid,@Pname,@Client_name,@Client_Contact_no,@Budget,@Deadlines)", conn);
                cmd.Parameters.AddWithValue("@Pid", TextBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@Pname", TextBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@Client_name", TextBox3.Text.Trim());
                cmd.Parameters.AddWithValue("@Client_Contact_no", TextBox4.Text.Trim());
                cmd.Parameters.AddWithValue("@Budget", TextBox5.Text.Trim());
                cmd.Parameters.AddWithValue("@Deadlines", TextBox6.Text.Trim());

                cmd.ExecuteNonQuery();
                conn.Close();
                Response.Write("<script>alert('Project added Successfully');</script>");
                clearForm();
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        bool checkIfProjectExists()
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=F:\HR MANAGMENT SYSTEM\HR MANAGMENT SYSTEM\App_Data\Database1.mdf;Integrated Security=True;User Instance=True");

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("SELECT * from tbl_Project where Pid='" + TextBox1.Text.Trim() + "';", con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                if (dt.Rows.Count >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
                return false;
            }
        }

        void clearForm()
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (checkIfProjectExists())
            {
                updateAuthor();
            }
            else
            {
                Response.Write("<script>alert('Project with this ID Not Exist.');</script>");


            }   
        }
        void updateAuthor()
        {
            try
            {

                SqlConnection connn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=F:\HR MANAGMENT SYSTEM\HR MANAGMENT SYSTEM\App_Data\Database1.mdf;Integrated Security=True;User Instance=True");

                if (connn.State == ConnectionState.Closed)
                {
                    connn.Open();
                }

                SqlCommand cmd = new SqlCommand("UPDATE tbl_Project SET Pname=@Pname,Client_name=@Client_name,Client_Contact_no=@Client_Contact_no,Budget=@Budget,Deadlines=@Deadlines WHERE Pid='" + TextBox1.Text.Trim() + "'", connn);

                cmd.Parameters.AddWithValue("@Pname", TextBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@Client_name", TextBox3.Text.Trim());
                cmd.Parameters.AddWithValue("@Client_Contact_no", TextBox4.Text.Trim());
                cmd.Parameters.AddWithValue("@Budget", TextBox5.Text.Trim());
                cmd.Parameters.AddWithValue("@Deadlines", TextBox6.Text.Trim());

                cmd.ExecuteNonQuery();
                connn.Close();
                Response.Write("<script>alert('Updated Successfully');</script>");
                clearForm();
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            if (checkIfProjectExists())
            {
                DeleteProject();

            }
            else
            {
                Response.Write("<script>alert('Author does not exist');</script>");
            }
        }
        void DeleteProject()
        {
            try
            {
                SqlConnection cox = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=F:\HR MANAGMENT SYSTEM\HR MANAGMENT SYSTEM\App_Data\Database1.mdf;Integrated Security=True;User Instance=True");


                if (cox.State == ConnectionState.Closed)
                {
                    cox.Open();
                }

                SqlCommand cmd = new SqlCommand("DELETE from tbl_Project WHERE Pid='" + TextBox1.Text.Trim() + "'", cox);

                cmd.ExecuteNonQuery();
                cox.Close();
                Response.Write("<script>alert('Deleted Successfully');</script>");
                clearForm();
                GridView1.DataBind();

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            getProjectByID();
        }

        void getProjectByID()
        {
            try
            {
                SqlConnection strcon = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=F:\HR MANAGMENT SYSTEM\HR MANAGMENT SYSTEM\App_Data\Database1.mdf;Integrated Security=True;User Instance=True");


                if (strcon.State == ConnectionState.Closed)
                {
                    strcon.Open();
                }

                SqlCommand cmd = new SqlCommand("SELECT * from tbl_Project where Pid='" + TextBox1.Text.Trim() + "';", strcon);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count >= 1)
                {
                    TextBox2.Text = dt.Rows[0][1].ToString();
                    TextBox3.Text = dt.Rows[0][2].ToString();
                    TextBox4.Text = dt.Rows[0][3].ToString();
                    TextBox5.Text = dt.Rows[0][4].ToString();
                    TextBox6.Text = dt.Rows[0][5].ToString();
                }
                else
                {
                    Response.Write("<script>alert('Invalid Project ID');</script>");
                }


            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");

            }
        }

    }
}