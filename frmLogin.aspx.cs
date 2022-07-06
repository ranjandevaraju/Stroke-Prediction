﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace diseasePrediction
{
    public partial class frmLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)

                txtUserId.Focus();
        }

        protected void btnLogin_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                BLL obj = new BLL();
                DataTable tab = new DataTable(); // buffer used to store select query

                tab = obj.CheckUserLogin(txtUserId.Text, txtPassword.Text);

                if (tab.Rows.Count > 0)
                {
                    if (DropDownListType.SelectedIndex == 1 && tab.Rows[0]["UserType"].ToString().Equals("Admin"))
                    {
                        Session["AdminId"] = txtUserId.Text;
                        Response.Redirect("~/Admin/CreateStaffs.aspx");
                    }
                    else if (DropDownListType.SelectedIndex == 2 && tab.Rows[0]["UserType"].ToString().Equals("Receptionist"))
                    {
                        Session["StaffId"] = txtUserId.Text;
                        Response.Redirect("~/Receptionist/Dataset.aspx");
                    }
                    else if (DropDownListType.SelectedIndex == 3 && tab.Rows[0]["UserType"].ToString().Equals("Doctor"))
                    {
                        Session["StaffId"] = txtUserId.Text;
                        Response.Redirect("~/Doctor/TestingDataset.aspx");
                    }
                }
                else
                {
                    if (DropDownListType.SelectedIndex == 4)
                    {
                        if (obj.CheckPatientLoginn(int.Parse(txtUserId.Text),float.Parse(txtPassword.Text)))
                        {
                            Session["PatientId"] = txtUserId.Text;
                            Response.Redirect("~/Patient/frmPatientHome.aspx");
                        }
                        else
                        {
                            ClientScript.RegisterStartupScript(this.GetType(), "key", "<script>alert('Patient Credentials Incorrect')</script>");

                        }
                    }

                    ClientScript.RegisterStartupScript(this.GetType(), "key", "<script>alert('User Credentials Incorrect')</script>");
                }

                
            }
            catch
            {

            }
        }
    }
}