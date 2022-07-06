﻿using System;
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

namespace diseasePrediction.Doctor
{
    public partial class Results_KNN : System.Web.UI.Page
    {
        double _outcomeCntNB = -1;
        string _timeNB = null;
        int _ActualCnt = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                _Results();
            }
            catch
            {

            }
        }

        private void _Results()
        {
            Table1.Rows.Clear();

            Table1.BorderStyle = BorderStyle.Double;
            Table1.GridLines = GridLines.Both;
            Table1.BorderColor = System.Drawing.Color.Black;

            //mainrow
            TableRow mainrow = new TableRow();
            mainrow.Height = 30;
            mainrow.ForeColor = System.Drawing.Color.Black;

            mainrow.BackColor = System.Drawing.Color.Green;

            TableCell cell1 = new TableCell();
            cell1.Width = 350;
            cell1.Text = "<b>Constraint</b>";
            mainrow.Controls.Add(cell1);

            TableCell cell2 = new TableCell();
            cell2.Width = 200;
            cell2.Text = "<b>KNN Algorithm</b>";
            mainrow.Controls.Add(cell2);

            Table1.Controls.Add(mainrow);

            CompareResults();

            //1st row
            TableRow row1 = new TableRow();

            TableCell cellAcc = new TableCell();
            cellAcc.Text = "<b>Accuracy</b>";
            row1.Controls.Add(cellAcc);

            TableCell cellAccNB = new TableCell();
            //cal
            double _percentageNB = (_outcomeCntNB / _ActualCnt) * 100;
            cellAccNB.Text = _percentageNB.ToString() + "%";
            row1.Controls.Add(cellAccNB);

            Table1.Controls.Add(row1);

            //2nd row           
            TableRow row2 = new TableRow();

            TableCell cellTime = new TableCell();
            cellTime.Text = "<b>Time (milli secs)</b>";
            row2.Controls.Add(cellTime);

            TableCell cellTimeNB = new TableCell();
            cellTimeNB.Text = _timeNB;
            row2.Controls.Add(cellTimeNB);

            Table1.Controls.Add(row2);

            //3rd row           
            TableRow row3 = new TableRow();

            TableCell cellCorrect = new TableCell();
            cellCorrect.Text = "<b>Correctly Classified</b>";
            row3.Controls.Add(cellCorrect);

            TableCell cellCorrectNB = new TableCell();
            cellCorrectNB.Text = _percentageNB.ToString() + "%";
            row3.Controls.Add(cellCorrectNB);

            Table1.Controls.Add(row3);

            //4th row           
            TableRow row4 = new TableRow();

            TableCell cellInCorrect = new TableCell();
            cellInCorrect.Text = "<b>InCorrectly Classified</b>";
            row4.Controls.Add(cellInCorrect);

            TableCell cellInCorrectNB = new TableCell();
            cellInCorrectNB.Text = (100 - _percentageNB).ToString() + "%";
            row4.Controls.Add(cellInCorrectNB);

            Table1.Controls.Add(row4);
        }

        private void CompareResults()
        {            
            BLL obj = new BLL();
            DataTable dt = new DataTable();
            dt = obj.GetActualDataset();

            if (dt.Rows.Count > 0)
            {
                _ActualCnt = dt.Rows.Count;

                string[] _PResult = Session["Output"].ToString().Split(',');

                _timeNB = _PResult[0];

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["Result"].ToString().Equals(_PResult[i + 1]))
                    {
                        ++_outcomeCntNB;
                    }
                }

                Session["KNN_Result"] = _outcomeCntNB;

            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Key", "<Script>alert('No Actual Dataset Found!!!')</script>");
            }           

        }
    }
}