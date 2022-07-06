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
using System.Data;

namespace diseasePrediction.Doctor
{
    public partial class TestingDataset : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["StaffId"] == null)
            {
                Session.Abandon();
                Response.Redirect("~/frmLogin.aspx");
            }
            else
            {
                LoadTestingDataset();
            }

        }

        //function to load all patients
        private void LoadTestingDataset()
        {
            DataTable tab = new DataTable();
            BLL obj = new BLL();

            tab = obj.GetTestingDataset();

            if (tab.Rows.Count > 0)
            {
                tablePatients.Rows.Clear();

                tablePatients.BorderStyle = BorderStyle.Double;
                tablePatients.GridLines = GridLines.Both;
                tablePatients.BorderColor = System.Drawing.Color.DarkGray;

                TableRow mainrow = new TableRow();
                mainrow.Height = 30;
                mainrow.ForeColor = System.Drawing.Color.WhiteSmoke;

                mainrow.BackColor = System.Drawing.Color.SteelBlue;

                TableCell cell1 = new TableCell();
                cell1.Text = "<b>Id</b>";
                mainrow.Controls.Add(cell1);

                TableCell cell2 = new TableCell();
                cell2.Text = "<b>Name</b>";
                mainrow.Controls.Add(cell2);

                TableCell cell3 = new TableCell();
                cell3.Text = "<b>gender</b>";
                mainrow.Controls.Add(cell3);

                TableCell cell4 = new TableCell();
                cell4.Text = "<b>age</b>";
                mainrow.Controls.Add(cell4);

                TableCell cell5 = new TableCell();
                cell5.Text = "<b>hypertension</b>";
                mainrow.Controls.Add(cell5);

                TableCell cell6 = new TableCell();
                cell6.Text = "<b>heartdisease</b>";
                mainrow.Controls.Add(cell6);

                TableCell cell7 = new TableCell();
                cell7.Text = "<b>evermarried</b>";
                mainrow.Controls.Add(cell7);

                TableCell cell8 = new TableCell();
                cell8.Text = "<b>familyhistory</b>";
                mainrow.Controls.Add(cell8);

                TableCell cell9 = new TableCell();
                cell9.Text = "<b>worktype</b>";
                mainrow.Controls.Add(cell9);

                TableCell cell10 = new TableCell();
                cell10.Text = "<b>residencetype</b>";
                mainrow.Controls.Add(cell10);

                TableCell cell101 = new TableCell();
                cell101.Text = "<b>avgglucoselevel</b>";
                mainrow.Controls.Add(cell101);

                TableCell cell1011 = new TableCell();
                cell1011.Text = "<b>bmi</b>";
                mainrow.Controls.Add(cell1011);

                TableCell cell1012 = new TableCell();
                cell1012.Text = "<b>smokingstatus</b>";
                mainrow.Controls.Add(cell1012);

                TableCell cell1013 = new TableCell();
                cell1013.Text = "<b>alcohol</b>";
                mainrow.Controls.Add(cell1013);

                TableCell cell1014 = new TableCell();
                cell1014.Text = "<b>diabetes</b>";
                mainrow.Controls.Add(cell1014);

                TableCell cell1015 = new TableCell();
                cell1015.Text = "<b>bpsystolic</b>";
                mainrow.Controls.Add(cell1015);

                TableCell cell1016 = new TableCell();
                cell1016.Text = "<b>bpdiastolic</b>";
                mainrow.Controls.Add(cell1016);

                TableCell cell1017 = new TableCell();
                cell1017.Text = "<b>cholesterol</b>";
                mainrow.Controls.Add(cell1017);

                TableCell cell1018 = new TableCell();
                cell1018.Text = "<b>WhiteBloodCellCount</b>";
                mainrow.Controls.Add(cell1018);

                TableCell cell1019 = new TableCell();
                cell1019.Text = "<b>RedBloodCellCount</b>";
                mainrow.Controls.Add(cell1019);
                                                
                //TableCell cell11 = new TableCell();
                //cell11.Text = "<b>Edit</b>";
                //mainrow.Controls.Add(cell11);

                //TableCell cell12 = new TableCell();
                //cell12.Text = "<b>Delete</b>";
                //mainrow.Controls.Add(cell12);

                tablePatients.Controls.Add(mainrow);

                for (int i = 0; i < tab.Rows.Count; i++)
                {
                    TableRow row = new TableRow();

                    TableCell cellId = new TableCell();
                    cellId.Text = tab.Rows[i]["PatientId"].ToString();
                    row.Controls.Add(cellId);

                    TableCell cellName = new TableCell();
                    cellName.Text = tab.Rows[i]["Name"].ToString();
                    row.Controls.Add(cellName);

                    TableCell cellAge = new TableCell();
                    cellAge.Text = tab.Rows[i]["gender"].ToString();
                    row.Controls.Add(cellAge);

                    TableCell cellBP = new TableCell();
                    cellBP.Text = tab.Rows[i]["age"].ToString();
                    row.Controls.Add(cellBP);

                    TableCell cellSpecificGravity = new TableCell();
                    cellSpecificGravity.Text = tab.Rows[i]["hypertension"].ToString();
                    row.Controls.Add(cellSpecificGravity);

                    TableCell cellAlbumin = new TableCell();
                    cellAlbumin.Text = tab.Rows[i]["heartdisease"].ToString();
                    row.Controls.Add(cellAlbumin);

                    TableCell cellSugar = new TableCell();
                    cellSugar.Text = tab.Rows[i]["evermarried"].ToString();
                    row.Controls.Add(cellSugar);

                    TableCell cellRedBloodCells = new TableCell();
                    cellRedBloodCells.Text = tab.Rows[i]["familyhistory"].ToString();
                    row.Controls.Add(cellRedBloodCells);

                    TableCell cellPusCell = new TableCell();
                    cellPusCell.Text = tab.Rows[i]["worktype"].ToString();
                    row.Controls.Add(cellPusCell);

                    TableCell cellPusCellClumps = new TableCell();
                    cellPusCellClumps.Text = tab.Rows[i]["residencetype"].ToString();
                    row.Controls.Add(cellPusCellClumps);

                    TableCell cellBacteria = new TableCell();
                    cellBacteria.Text = tab.Rows[i]["avgglucoselevel"].ToString();
                    row.Controls.Add(cellBacteria);

                    TableCell cellBloodGlucoseRandom = new TableCell();
                    cellBloodGlucoseRandom.Text = tab.Rows[i]["bmi"].ToString();
                    row.Controls.Add(cellBloodGlucoseRandom);

                    TableCell cellBloodUrea = new TableCell();
                    cellBloodUrea.Text = tab.Rows[i]["smokingstatus"].ToString();
                    row.Controls.Add(cellBloodUrea);

                    TableCell cellSerumCreatinine = new TableCell();
                    cellSerumCreatinine.Text = tab.Rows[i]["alcohol"].ToString();
                    row.Controls.Add(cellSerumCreatinine);

                    TableCell cellSodium = new TableCell();
                    cellSodium.Text = tab.Rows[i]["diabetes"].ToString();
                    row.Controls.Add(cellSodium);

                    TableCell cellPotassium = new TableCell();
                    cellPotassium.Text = tab.Rows[i]["bpsystolic"].ToString();
                    row.Controls.Add(cellPotassium);

                    TableCell cellHemoglobin = new TableCell();
                    cellHemoglobin.Text = tab.Rows[i]["bpdiastolic"].ToString();
                    row.Controls.Add(cellHemoglobin);

                    TableCell cellPackedCellVolume = new TableCell();
                    cellPackedCellVolume.Text = tab.Rows[i]["cholesterol"].ToString();
                    row.Controls.Add(cellPackedCellVolume);

                    TableCell cellWhiteBloodCellCount = new TableCell();
                    cellWhiteBloodCellCount.Text = tab.Rows[i]["whitebloodcellcount"].ToString();
                    row.Controls.Add(cellWhiteBloodCellCount);

                    TableCell cellRedBloodCellCount = new TableCell();
                    cellRedBloodCellCount.Text = tab.Rows[i]["redbloodcellcount"].ToString();
                    row.Controls.Add(cellRedBloodCellCount);

                                      
                    //TableCell cell_edit = new TableCell();
                    //LinkButton lbtn_edit = new LinkButton();
                    //lbtn_edit.ForeColor = System.Drawing.Color.SteelBlue;
                    //lbtn_edit.Text = "Edit";
                    //lbtn_edit.Font.Bold = true;
                    //lbtn_edit.ID = "Edit~" + tab.Rows[i]["PatientId"].ToString();
                    //lbtn_edit.Click += new EventHandler(lbtn_edit_Click);
                    //cell_edit.Controls.Add(lbtn_edit);
                    //row.Controls.Add(cell_edit);

                    //TableCell cell_delete = new TableCell();
                    //LinkButton lbtn_delete = new LinkButton();
                    //lbtn_delete.ForeColor = System.Drawing.Color.SteelBlue;
                    //lbtn_delete.Text = "Delete";
                    //lbtn_delete.Font.Bold = true;
                    //lbtn_delete.ID = "Delete~" + tab.Rows[i]["PatientId"].ToString();
                    //lbtn_delete.OnClientClick = "return confirm('Are you sure want to delete this record?')";
                    //lbtn_delete.Click += new EventHandler(lbtn_delete_Click);
                    //cell_delete.Controls.Add(lbtn_delete);
                    //row.Controls.Add(cell_delete);

                    tablePatients.Controls.Add(row);
                }
            }
            else
            {
                tablePatients.Rows.Clear();
                tablePatients.GridLines = GridLines.None;
                tablePatients.BorderStyle = BorderStyle.None;

                TableHeaderRow rno = new TableHeaderRow();
                TableHeaderCell cellno = new TableHeaderCell();
                cellno.ForeColor = System.Drawing.Color.Red;
                cellno.Text = "No Testing Dataset Found!!!";

                rno.Controls.Add(cellno);
                tablePatients.Controls.Add(rno);
            }
        }

        //event to delete patient
        void lbtn_delete_Click(object sender, EventArgs e)
        {
            BLL obj = new BLL();
            LinkButton lbtn = (LinkButton)sender;
            string[] s = lbtn.ID.ToString().Split('~');

            try
            {
                obj.DeleteTestingData(int.Parse(s[1].ToString()));

                ClientScript.RegisterStartupScript(this.GetType(), "Key", "<Script>alert('Record Deleted Successfully!!!')</script>");
                LoadTestingDataset();

            }
            catch
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Key", "<Script>alert('Server Error!!!')</script>");
            }
        }

        //click event to edit the patient details
        void lbtn_edit_Click(object sender, EventArgs e)
        {
            BLL obj = new BLL();
            LinkButton lbtn = (LinkButton)sender;
            string[] s = lbtn.ID.ToString().Split('~');

            Session["Id"] = null;
            Session["Id"] = s[1];

            DataTable tab = new DataTable();
            tab = obj.GetTestingDataById(int.Parse(s[1]));

            if (tab.Rows.Count > 0)
            {
                txtPatientName.Text = tab.Rows[0]["Name"].ToString();

                string dataTextField = DropDownList1.Items.FindByValue(tab.Rows[0]["gender"].ToString()).ToString();

                ListItem item = new ListItem(dataTextField, dataTextField);
                int index = DropDownList1.Items.IndexOf(item);

                if (index != -1)

                    DropDownList1.SelectedIndex = index;

                txtAge.Text = tab.Rows[0]["Age"].ToString();
                txtHT.Text = tab.Rows[0]["hypertension"].ToString();
                txtHD.Text = tab.Rows[0]["heartdisease"].ToString();
                txtEM.Text = tab.Rows[0]["evermarried"].ToString();
                txtfamilyhistory.Text = tab.Rows[0]["familyhistory"].ToString();

                txtworktype.Text = tab.Rows[0]["worktype"].ToString();
                txtresidencetype.Text = tab.Rows[0]["residencetype"].ToString();
                txtavgglucoselevel.Text = tab.Rows[0]["avgglucoselevel"].ToString();
                txtBMI.Text = tab.Rows[0]["bmi"].ToString();
                txtsmokingstatus.Text = tab.Rows[0]["smokingstatus"].ToString();
                txtalcohol.Text = tab.Rows[0]["alcohol"].ToString();
                txtdiabetes.Text = tab.Rows[0]["diabetes"].ToString();

                txtbpsystolic.Text = tab.Rows[0]["bpsystolic"].ToString();
                txtbpdiastolic.Text = tab.Rows[0]["bpdiastolic"].ToString();
                txtcholesterol.Text = tab.Rows[0]["cholesterol"].ToString();
                txtWhiteBloodCellCount.Text = tab.Rows[0]["whitebloodcellcount"].ToString();
                txtRedBloodCellCount.Text = tab.Rows[0]["redbloodcellcount"].ToString();              
            }

            btnSubmit.Text = "Update";
        }

        //function to clear the textbox contents
        private void ClearTxtboxes()
        {
            txtAge.Text = txtalcohol.Text = txtavgglucoselevel.Text = txtBMI.Text = txtbpdiastolic.Text = txtbpsystolic.Text =
               txtcholesterol.Text = txtdiabetes.Text = txtEM.Text = txtfamilyhistory.Text = txtHD.Text = txtHT.Text = txtPatientName.Text = txtRedBloodCellCount.Text =
               txtresidencetype.Text = txtsmokingstatus.Text = txtWhiteBloodCellCount.Text = txtworktype.Text = txtWhiteBloodCellCount.Text = string.Empty;
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            BLL obj = new BLL();

            if (btnSubmit.Text.Equals("Submit"))
            {
                try
                {
                    obj.InsertTestingData(txtPatientName.Text, double.Parse(DropDownList1.SelectedValue), double.Parse(txtAge.Text),
                        double.Parse(txtHT.Text), double.Parse(txtHD.Text), double.Parse(txtEM.Text), double.Parse(txtfamilyhistory.Text),
                        double.Parse(txtworktype.Text), double.Parse(txtresidencetype.Text), double.Parse(txtavgglucoselevel.Text), double.Parse(txtBMI.Text),
                        double.Parse(txtsmokingstatus.Text), double.Parse(txtalcohol.Text), double.Parse(txtdiabetes.Text), double.Parse(txtbpsystolic.Text),
                        double.Parse(txtbpdiastolic.Text), double.Parse(txtcholesterol.Text), double.Parse(txtWhiteBloodCellCount.Text), double.Parse(txtRedBloodCellCount.Text));

                    ClientScript.RegisterStartupScript(this.GetType(), "Key", "<Script>alert('Data Added Successfully!!!')</script>");
                    ClearTxtboxes();
                    LoadTestingDataset();
                }
                catch
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "Key", "<Script>alert('Server Error!')</script>");
                }
            }
            else if (btnSubmit.Text.Equals("Update"))
            {

                obj.UpdateTestingData(txtPatientName.Text, double.Parse(DropDownList1.SelectedValue), double.Parse(txtAge.Text),
                        double.Parse(txtHT.Text), double.Parse(txtHD.Text), double.Parse(txtEM.Text), double.Parse(txtfamilyhistory.Text),
                        double.Parse(txtworktype.Text), double.Parse(txtresidencetype.Text), double.Parse(txtavgglucoselevel.Text), double.Parse(txtBMI.Text),
                        double.Parse(txtsmokingstatus.Text), double.Parse(txtalcohol.Text), double.Parse(txtdiabetes.Text), double.Parse(txtbpsystolic.Text),
                        double.Parse(txtbpdiastolic.Text), double.Parse(txtcholesterol.Text), double.Parse(txtWhiteBloodCellCount.Text), double.Parse(txtRedBloodCellCount.Text),
                        int.Parse(Session["Id"].ToString()));


                btnSubmit.Text = "Submit";
                ClearTxtboxes();
                LoadTestingDataset();
                ClientScript.RegisterStartupScript(this.GetType(), "Key", "<script>alert('Data Updated Successfully!!!')</script>");
            }
        }
               
    }
}