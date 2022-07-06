using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Web.UI.DataVisualization.Charting;

namespace diseasePrediction.Doctor
{
    public partial class _Compare : System.Web.UI.Page
    {
        Dictionary<string, double> testData = new Dictionary<string, double>();

        protected override void OnLoad(EventArgs e)
        {
            try
            {
                _ComparativeAnalysis();

                base.OnLoad(e);

                if (!IsPostBack)
                {
                    // bind chart type names to ddl
                    ddlChartType.DataSource = Enum.GetNames(typeof(SeriesChartType));
                    ddlChartType.DataBind();

                    //cbUse3D.Checked = true;
                }

                DataBind();

            }
            catch
            {

            }
        }

        protected override void OnDataBinding(EventArgs e)
        {
            base.OnDataBinding(e);
            testData.Clear();


            testData.Add("KNN", _percentageKNN);
            testData.Add("NB", _percentageNB);

            cTestChart.Series["Testing"].Points.DataBind(testData, "Key", "Value", string.Empty);
        }

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);

            // update chart rendering           
            cTestChart.Series["Testing"].ChartTypeName = "Column";

            cTestChart.ChartAreas[0].Area3DStyle.Enable3D = cbUse3D.Checked;
            cTestChart.ChartAreas[0].Area3DStyle.Inclination = Convert.ToInt32(rblInclinationAngle.SelectedValue);

            cTestChart.Visible = true;
        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            cTestChart.Visible = true;

            OnDataBinding(e);
            OnPreRender(e);
        }

        static double _percentageKNN, _percentageNB;

        private void _ComparativeAnalysis()
        {
            BLL obj = new BLL();

            DataTable tabActual = new DataTable();
            tabActual = obj.GetActualDataset();

            int _ActualCnt = tabActual.Rows.Count;

            Table3.Rows.Clear();

            Table3.BorderStyle = BorderStyle.Double;
            Table3.GridLines = GridLines.Both;
            Table3.BorderColor = System.Drawing.Color.DarkGray;

            //mainrow
            TableRow mainrow = new TableRow();
            mainrow.Height = 30;
            mainrow.ForeColor = System.Drawing.Color.WhiteSmoke;

            mainrow.BackColor = System.Drawing.Color.Orange;

            TableCell cell1 = new TableCell();
            cell1.Width = 350;
            cell1.Text = "<b>Constraint</b>";
            mainrow.Controls.Add(cell1);

            TableCell cell2 = new TableCell();
            cell2.Width = 200;
            cell2.Text = "<b>KNN</b>";
            mainrow.Controls.Add(cell2);

            TableCell cell4 = new TableCell();
            cell4.Width = 200;
            cell4.Text = "<b>Naive Bayes</b>";
            mainrow.Controls.Add(cell4);

            Table3.Controls.Add(mainrow);

            //1st row
            TableRow row1 = new TableRow();

            TableCell cellAcc = new TableCell();
            cellAcc.Text = "<b>Accuracy</b>";
            row1.Controls.Add(cellAcc);

            double _outcomeKNN = double.Parse(Session["KNN_Result"].ToString());

            TableCell cellAccKNN = new TableCell();
            _percentageKNN = (_outcomeKNN / _ActualCnt) * 100;
            cellAccKNN.Text = _percentageKNN.ToString() + "%";
            row1.Controls.Add(cellAccKNN);

            double _outcomeNB = double.Parse(Session["NB_Result"].ToString());

            TableCell cellAccNB = new TableCell();
            //cal
            _percentageNB = (_outcomeNB / _ActualCnt) * 100;
            cellAccNB.Text = _percentageNB.ToString() + "%";
            row1.Controls.Add(cellAccNB);

            Table3.Controls.Add(row1);

            //2nd row           
            TableRow row2 = new TableRow();

            TableCell cellTime = new TableCell();
            cellTime.Text = "<b>Time (milli secs)</b>";
            row2.Controls.Add(cellTime);



            TableCell cellTimeKNN = new TableCell();
            cellTimeKNN.Text = Session["KNN_Time"].ToString();
            row2.Controls.Add(cellTimeKNN);


            TableCell cellTimeNB = new TableCell();
            cellTimeNB.Text = Session["NB_Time"].ToString(); ;
            row2.Controls.Add(cellTimeNB);

            Table3.Controls.Add(row2);

            //3rd row           
            TableRow row3 = new TableRow();

            TableCell cellCorrect = new TableCell();
            cellCorrect.Text = "<b>Correctly Classified</b>";
            row3.Controls.Add(cellCorrect);



            TableCell cellCorrectKNN = new TableCell();
            cellCorrectKNN.Text = _percentageKNN.ToString() + "%";
            row3.Controls.Add(cellCorrectKNN);



            TableCell cellCorrectNB = new TableCell();
            cellCorrectNB.Text = _percentageNB.ToString() + "%";
            row3.Controls.Add(cellCorrectNB);

            Table3.Controls.Add(row3);

            //4th row           
            TableRow row4 = new TableRow();

            TableCell cellInCorrect = new TableCell();
            cellInCorrect.Text = "<b>InCorrectly Classified</b>";
            row4.Controls.Add(cellInCorrect);

            TableCell cellInCorrectKNN = new TableCell();
            cellInCorrectKNN.Text = (100 - _percentageKNN).ToString() + "%";
            row4.Controls.Add(cellInCorrectKNN);

            TableCell cellInCorrectNB = new TableCell();
            cellInCorrectNB.Text = (100 - _percentageNB).ToString() + "%";
            row4.Controls.Add(cellInCorrectNB);



            Table3.Controls.Add(row4);
        }
    }
}