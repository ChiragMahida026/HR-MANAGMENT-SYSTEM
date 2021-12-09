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

    public partial class userlogin : System.Web.UI.Page
    {
                 
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try {
                SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\PC\documents\visual studio 2010\Projects\HR MANAGMENT SYSTEM\HR MANAGMENT SYSTEM\App_Data\Database1.mdf;Integrated Security=True;User Instance=True");
       

                    if (con.State == ConnectionState.Closed) 
                    {
                     con.Open();
 
                    }
                     SqlCommand cmd = new SqlCommand("select * from tbl_Employee where Username='" + TextBox1.Text.Trim() + "' AND Password='" + TextBox2.Text.Trim() + "'", con);
                     SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.HasRows) 
                        {
                                while (dr.Read()) 
                                {
                                    Response.Write("<script>alert('Login Successful');</script>");
                                    Session["Username"] = dr.GetValue(8).ToString();
                                    Session["Password"] = dr.GetValue(9).ToString();
                                    Session["role"] = dr.GetValue(5).ToString();
                                 }
                                Response.Redirect("Homepage.aspx");
                         }
                            
                        else 
                        {
                            Response.Write("<script>alert('Invalid credentials');</script>");
                         }
 
                 }
            catch (Exception ex)
            {

            }

        }
    }
}