using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data;
using System.IO;
using System.Collections;
using System.Threading;
using System.Configuration;

namespace diseasePrediction.Receptionist
{
    public partial class SearchPatient : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtUserId.Focus();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            BLL obj = new BLL();
            DataTable tab = new DataTable();

            tab = obj.GetTrainingDataById(int.Parse(txtUserId.Text));

            if (tab.Rows.Count > 0)
            {
                DetailsView1.DataSource = tab;
                DetailsView1.DataBind();
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "key", "<script>alert('Data Not Found!!!')</script>");
            }
        }
    }
}