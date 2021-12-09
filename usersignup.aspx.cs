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

    public partial class usersignup : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        { }
            


        protected void Button1_Click(object sender, EventArgs e)
        {

            if (checkMemberExists())
            {

                Response.Write("<script>alert('Member Already Exist with this USER ID, try other ID');</script>");
            }
            else
            {
                signUpNewMember();
            }

            
        }

        bool checkMemberExists()
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\PC\documents\visual studio 2010\Projects\HR MANAGMENT SYSTEM\HR MANAGMENT SYSTEM\App_Data\Database1.mdf;Integrated Security=True;User Instance=True");
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("SELECT * from tbl_Employee where Userid='" + TextBox8.Text.Trim() + "';", con);
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

        void signUpNewMember()
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\PC\documents\visual studio 2010\Projects\HR MANAGMENT SYSTEM\HR MANAGMENT SYSTEM\App_Data\Database1.mdf;Integrated Security=True;User Instance=True");

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                SqlCommand cmd = new SqlCommand("insert into tbl_Employee (Name,Dob,Contact_no,Email_id,Usertype,Qualification,Address,Username,Password) values(@Name,@Dob,@Contact_no,@Email_id,@Usertype,@Qualification,@Address,@Username,@Password)", conn);


                cmd.Parameters.AddWithValue("@Name", TextBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@Dob", TextBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@Contact_no", TextBox3.Text.Trim());
                cmd.Parameters.AddWithValue("@Email_id", TextBox4.Text.Trim());
                cmd.Parameters.AddWithValue("@Usertype", DropDownListSelect.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Qualification", TextBox7.Text.Trim());
                cmd.Parameters.AddWithValue("@Address", TextBox5.Text.Trim());
                cmd.Parameters.AddWithValue("@Username", TextBox8.Text.Trim());
                cmd.Parameters.AddWithValue("@Password", TextBox10.Text.Trim());

                cmd.ExecuteNonQuery();
               
                conn.Close();

                Response.Write("<script>alert('Sign Up Successful. Go to User Login to Login');</script>");
                Response.Redirect("userlogin.aspx");
            }

            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        
        
        
        }

        protected void OnSelected(object sender, EventArgs e)
        {

        }

        protected void DropDownListSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }





}