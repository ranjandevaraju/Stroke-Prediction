using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;


namespace diseasePrediction.Admin
{
    public partial class ExistingStaffs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadStaffs();
        }

        //function to load all staffs
        private void LoadStaffs()
        {
            try
            {
                // creating two buffer for temporary storage
                DataTable tab = new DataTable();
                BLL obj = new BLL();    

                int serialNo = 1;              // initialize serial no to start from 1

                tab = obj.GetOtherUsers();                   //tab stores other users other than admin 

                if (tab.Rows.Count > 0)
                {
                    tableStaffs.Rows.Clear();

                    tableStaffs.BorderStyle = BorderStyle.Double;                 // This is to create dynamic table of header row
                    tableStaffs.GridLines = GridLines.Both;
                    tableStaffs.BorderColor = System.Drawing.Color.DarkGray;

                    TableRow mainrow = new TableRow();
                    mainrow.Height = 30;
                    mainrow.ForeColor = System.Drawing.Color.WhiteSmoke;

                    mainrow.BackColor = System.Drawing.Color.SteelBlue;           // till here header row creation

                    TableCell cell1 = new TableCell();                          // creating new cell
                    cell1.Text = "<b>SerialNo</b>";                             // naming the cell
                    mainrow.Controls.Add(cell1);                               // adding it into row

                    TableCell cell21 = new TableCell();
                    cell21.Text = "<b>UserType</b>";
                    mainrow.Controls.Add(cell21);

                    TableCell cell2 = new TableCell();
                    cell2.Text = "<b>Staff Id</b>";
                    mainrow.Controls.Add(cell2);

                    TableCell cell3 = new TableCell();
                    cell3.Text = "<b>Password</b>";
                    mainrow.Controls.Add(cell3);

                    TableCell cell4 = new TableCell();
                    cell4.Text = "<b>EmailId</b>";
                    mainrow.Controls.Add(cell4);

                    TableCell cell5 = new TableCell();
                    cell5.Text = "<b>Edit</b>";
                    mainrow.Controls.Add(cell5);

                    TableCell cell6 = new TableCell();
                    cell6.Text = "<b>Delete</b>";
                    mainrow.Controls.Add(cell6);                       // till here is creating and adding the cell and text

                    tableStaffs.Controls.Add(mainrow);                  // Now put the entire row into dynamic table where
                                                                        // dynamic table is collection of rows and row is a collection of cells


                    for (int i = 0; i < tab.Rows.Count; i++)      // to generate rows dynamical
                    {
                        TableRow row = new TableRow();

                        TableCell cellSerialNo = new TableCell();
                        cellSerialNo.Width = 50;
                        cellSerialNo.Text = serialNo + i + ".";  //1.,2. is generated from this code
                        row.Controls.Add(cellSerialNo);         // This code add the serial no to cell

                        TableCell cellType = new TableCell();
                        cellType.Text = tab.Rows[i]["UserType"].ToString(); // this code add usertype like doctor,receptionist to the cell
                        row.Controls.Add(cellType);

                        TableCell cellUserId = new TableCell();
                        cellUserId.Width = 150;
                        cellUserId.Text = tab.Rows[i]["UserId"].ToString();// this code add usertypes id to the cell
                        row.Controls.Add(cellUserId);

                        TableCell cellPassword = new TableCell();
                        cellPassword.Width = 150;
                        cellPassword.Text = tab.Rows[i]["Password"].ToString();// this code add usertypes password to the cell
                        row.Controls.Add(cellPassword);

                        TableCell cellEmailId = new TableCell();
                        cellEmailId.Width = 200;
                        cellEmailId.Text = tab.Rows[i]["EmailId"].ToString();// this code add usertypes email id to the cell
                        row.Controls.Add(cellEmailId);




                        // generating Edit function dynamically 
                        TableCell cell_edit = new TableCell();    // creating the edit cell
                        LinkButton lbtn_edit = new LinkButton();     // creating edit button inside the cell
                        lbtn_edit.ForeColor = System.Drawing.Color.SteelBlue; // setting property to the cell
                        lbtn_edit.Font.Bold = true;
                        lbtn_edit.Text = "Edit";                              // setting property to the cell
                        lbtn_edit.ID = "Edit~" + tab.Rows[i]["UserId"].ToString(); // id is set to edit symbol of particular user id.
                        lbtn_edit.Click += new EventHandler(lbtn_edit_Click);   // generating edit event of edit button
                        cell_edit.Controls.Add(lbtn_edit);        // now we put that button into cell
                        row.Controls.Add(cell_edit);               // now put that cell into row 


                        // generating delete function dynamically
                        TableCell cell_delete = new TableCell();  // creating the delete cell
                        LinkButton lbtn_delete = new LinkButton(); // creating delete button inside the cell
                        lbtn_delete.ForeColor = System.Drawing.Color.SteelBlue;
                        lbtn_delete.Font.Bold = true;
                        lbtn_delete.Text = "Delete";

                        lbtn_delete.ID = "Delete~" + tab.Rows[i]["UserId"].ToString();
                        lbtn_delete.OnClientClick = "return confirm('Are you sure want to delete this record?')";// alert button is added to confirm to delet or not
                        lbtn_delete.Click += new EventHandler(lbtn_delete_Click);
                        cell_delete.Controls.Add(lbtn_delete);
                        row.Controls.Add(cell_delete);

                        tableStaffs.Controls.Add(row); // finally put entire row into the table.
                    }
                }
                else
                {
                    tableStaffs.Rows.Clear();

                    TableHeaderRow rno = new TableHeaderRow();
                    TableHeaderCell cellno = new TableHeaderCell();
                    cellno.ForeColor = System.Drawing.Color.Red;
                    cellno.Text = "No Staffs Found";

                    rno.Controls.Add(cellno);
                    tableStaffs.Controls.Add(rno);
                }
            }
            catch
            {

            }
        }

        //event to delete staff
        void lbtn_delete_Click(object sender, EventArgs e)
        {
            BLL obj = new BLL();
            LinkButton lbtn = (LinkButton)sender;
            string[] s = lbtn.ID.ToString().Split('~'); // del~3, it puts 3 into the s

            try
            {
                obj.DeleteUser(s[1]); // now s[1] will have 3(primary key)

                ClientScript.RegisterStartupScript(this.GetType(), "Key", "<Script>alert('Staff Deleted Successfully')</script>");// based on key it will delete
                LoadStaffs();// to display the remaining staff we call loadstaffs function

            }
            catch
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Key", "<Script>alert('Server Error!!!')</script>");
            }
        }

        //click event to edit the staff details
        void lbtn_edit_Click(object sender, EventArgs e)
        {
            BLL obj = new BLL();
            LinkButton lbtn = (LinkButton)sender;
            string[] s = lbtn.ID.ToString().Split('~');

            try
            {
                Response.Redirect(string.Format("CreateStaffs.aspx?staffId={0}", s[1])); // when we click on edit it transfer the
                                                                                         // or take the page to create staff of the particular usertype 
            }
            catch
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Key", "<Script>alert('Server Error!!!')</script>");
            }
        }



    }
}