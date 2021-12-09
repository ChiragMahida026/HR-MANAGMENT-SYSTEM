using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HR_MANAGMENT_SYSTEM
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["role"].Equals(""))
                {
                    LinkButton1.Visible = true;
                    LinkButton2.Visible = true;

                    LinkButton3.Visible = false;
                    LinkButton7.Visible = false;

                    LinkButton11.Visible = false;
                    LinkButton12.Visible = false;
                    LinkButton8.Visible = false;
                    LinkButton9.Visible = false;

                }
                else if (Session["role"].Equals("Employee"))
                {
                    LinkButton1.Visible = false; 
                    LinkButton2.Visible = false; 

                    LinkButton3.Visible = true; 
                    LinkButton7.Visible = true; 
                    LinkButton7.Text = "Hello " + Session["Username"].ToString() + "(Employee)";


                   
                    LinkButton11.Visible = false; 
                    LinkButton12.Visible = false; 
                    LinkButton8.Visible = false; 
                    LinkButton9.Visible = false; 
                }
                else if (Session["role"].Equals("HR"))
                {
                    LinkButton1.Visible = false; 
                    LinkButton2.Visible = false; 

                    LinkButton3.Visible = true; 
                    LinkButton7.Visible = true; 
                    LinkButton7.Text = "Hello "+ Session["Username"].ToString()+"(HR)";


                    LinkButton11.Visible = true; 
                    LinkButton12.Visible = true; 
                    LinkButton8.Visible = true; 
                    LinkButton9.Visible = true; 
                }
            }
            catch (Exception ex)
            {

            }


        }


        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("userlogin.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("usersignup.aspx");
        }


        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Session["username"] = "";
            Session["fullname"] = "";
            Session["role"] = "";
            Session["status"] = "";

            LinkButton1.Visible = true; 
            LinkButton2.Visible = true; 

            LinkButton3.Visible = false; 
            LinkButton7.Visible = false; 


            
            LinkButton11.Visible = false;
            LinkButton12.Visible = false; 
            LinkButton8.Visible = false; 
            LinkButton9.Visible = false; 
        }

        protected void LinkButton11_Click(object sender, EventArgs e)
        {
            Response.Redirect("ManageEmployee.aspx");
        }
    }
}