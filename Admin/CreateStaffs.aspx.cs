using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace diseasePrediction.Admin
{
    public partial class CreateStaffs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                txtUserId.Focus();

                if (Request.QueryString["staffId"] == null)
                {

                }
                else
                {
                    loadStaff();
                }
            }

        }

        //function to load staff details
        // pseudocode
        // loadstaff(){
        // fetch all staffs
        // select * from tblusers 
        //store the data using buffer(dataTable- tab)
        //if(tab.rows.count>0){
        //read the data from buffer and display using dynamic table
        //else{ no staff found;}
        private void loadStaff()
        {
            BLL obj = new BLL();
            DataTable tab = new DataTable();
            tab = obj.GetUserById(Request.QueryString["staffId"]);

            Session["staffId"] = null;
            Session["staffId"] = Request.QueryString["staffId"];

            if (tab.Rows.Count > 0)
            {
                txtUserId.Text = tab.Rows[0]["UserId"].ToString();
                txtPassword.Text = tab.Rows[0]["Password"].ToString();
               
                txtEmailId.Text = tab.Rows[0]["EmailId"].ToString();

                string dataTextField = DropDownListType.Items.FindByValue(tab.Rows[0]["UserType"].ToString()).ToString();

                ListItem item = new ListItem(dataTextField, dataTextField);
                int index = DropDownListType.Items.IndexOf(item);

                if (index != -1)

                    DropDownListType.SelectedIndex = index;       
            }



            btnSubmit.Text = "Update";
        }


        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            BLL obj = new BLL();

            if (btnSubmit.Text.Equals("Submit"))// checks pressed button submit or not
            {
                try
                {
                    if (obj.CheckUserId(txtUserId.Text))  //checks userid if doesnt exist 
                    {
                        obj.InsertUser(txtUserId.Text, txtPassword.Text, DropDownListType.SelectedValue, txtEmailId.Text);// if user id not exist executes insert query

                        //Emails.MailSender.SendEmail(" ", " ", txtEmailId.Value, "Credentials", "User Id=" + txtUserId.Value + "and Pwd=" + txtPassword.Value, " ");

                        ClientScript.RegisterStartupScript(this.GetType(), "Key", "<Script>alert('New Staff Added Successfully')</script>");// after insert query it display
                                                                                                                                            // the message added successfully
                        txtEmailId.Text = string.Empty;    // after succesful addition it claers the field
                        txtPassword.Text = string.Empty;    // to add new staff
                        txtUserId.Text = string.Empty;                       

                    }
                    else
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "Key", "<Script>alert('UserId Exists!!!')</script>");// if it is already exists it comes to this part
                    }
                }
                catch
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "Key", "<Script>alert('Server Error!')</script>");
                }
            }


            // Updation takes place with two types
            //1. using user Id
            //2. without user id
            else if (btnSubmit.Text.Equals("Update")) // checks pressed button update  or not
            {
                // With user Id
                if (txtUserId.Text.Equals(Session["staffId"].ToString()))
                {
                    try
                    {
                        obj.UpdateUser(txtUserId.Text, txtPassword.Text, DropDownListType.SelectedValue, txtEmailId.Text, Session["staffId"].ToString());

                        //Emails.MailSender.SendEmail(" ", " ", txtEmailId.Value, "Credentials", "User Id=" + txtUserId.Value + "and Pwd=" + txtPassword.Value, " ");

                        ClientScript.RegisterStartupScript(this.GetType(), "Key", "<Script>alert('User Updated Successfully')</script>");
                        txtEmailId.Text = string.Empty;
                        txtPassword.Text = string.Empty;
                        txtUserId.Text = string.Empty;                       

                        btnSubmit.Text = "Submit";  // after updating this code changes to submit

                    }
                    catch
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "Key", "<Script>alert('Server Error!')</script>");
                    }
                }
                else
                {
                     // without user id
                    if (obj.CheckUserId(txtUserId.Text))
                    {
                        try
                        {
                            obj.UpdateUser(txtUserId.Text, txtPassword.Text, DropDownListType.SelectedValue, txtEmailId.Text, Session["staffId"].ToString());

                            //Emails.MailSender.SendEmail(" ", " ", txtEmailId.Value, "Credentials", "User Id=" + txtUserId.Value + "and Pwd=" + txtPassword.Value, " ");

                            ClientScript.RegisterStartupScript(this.GetType(), "Key", "<Script>alert('User Updated Successfully')</script>");
                            txtEmailId.Text = string.Empty;
                            txtPassword.Text = string.Empty;
                            txtUserId.Text = string.Empty;                           

                            btnSubmit.Text = "Submit";

                        }
                        catch
                        {
                            ClientScript.RegisterStartupScript(this.GetType(), "Key", "<Script>alert('Server Error!')</script>");
                        }
                    }
                    else
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "Key", "<Script>alert('UserId Exists')</script>");
                    }
                }
            }
        }

    }
}