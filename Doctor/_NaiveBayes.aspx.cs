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

namespace diseasePrediction.Doctor
{
    public partial class _NaiveBayes : System.Web.UI.Page
    {               
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                LoadTestingDataset();
            }
            catch
            {

            }
        }

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


                tablePatients.Controls.Add(mainrow);

                for (int i = 0; i < tab.Rows.Count; i++)
                {
                    TableRow row = new TableRow();

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

      
        protected void btnPrediction_Click(object sender, EventArgs e)
        {
            try
            {

                BLL obj = new BLL();
                DataTable tabTestingDS = new DataTable();
                tabTestingDS = obj.GetTestingDataset();

                int slNo = 1;

                if (tabTestingDS.Rows.Count > 0)
                {
                    Session["Output"] = null;

                    string _Predictedoutput = null;
                    string _timeNB = null;

                    tablePrediction.Rows.Clear();

                    tablePrediction.BorderStyle = BorderStyle.Double;
                    tablePrediction.GridLines = GridLines.Both;
                    tablePrediction.BorderColor = System.Drawing.Color.Black;

                    TableRow mainrow = new TableRow();
                    mainrow.Height = 30;
                    mainrow.ForeColor = System.Drawing.Color.Black;
                    mainrow.BackColor = System.Drawing.Color.SteelBlue;

                    TableCell cell0 = new TableCell();
                    cell0.Width = 100;
                    cell0.Text = "<b>SlNo</b>";
                    mainrow.Controls.Add(cell0);

                    TableCell cell1 = new TableCell();
                    cell1.Width = 100;
                    cell1.Text = "<b>Name</b>";
                    mainrow.Controls.Add(cell1);

                    //TableCell cell2 = new TableCell();
                    //cell2.Text = "<b>gender</b>";
                    //mainrow.Controls.Add(cell2);

                    //TableCell cell3 = new TableCell();
                    //cell3.Text = "<b>bp</b>";
                    //mainrow.Controls.Add(cell3);

                    //TableCell cell4 = new TableCell();
                    //cell4.Text = "<b>weight</b>";
                    //mainrow.Controls.Add(cell4);

                    //TableCell cell5 = new TableCell();
                    //cell5.Text = "<b>sugartested</b>";
                    //mainrow.Controls.Add(cell5);

                    //TableCell cell6 = new TableCell();
                    //cell6.Text = "<b>familyhistory</b>";
                    //mainrow.Controls.Add(cell6);

                    //TableCell cell7 = new TableCell();
                    //cell7.Text = "<b>smokes</b>";
                    //mainrow.Controls.Add(cell7);

                    //TableCell cell8 = new TableCell();
                    //cell8.Text = "<b>alcohol</b>";
                    //mainrow.Controls.Add(cell8);


                    TableCell cell25 = new TableCell();
                    cell25.Text = "<b>Result</b>";
                    mainrow.Controls.Add(cell25);

                    tablePrediction.Controls.Add(mainrow);

                    var watch = System.Diagnostics.Stopwatch.StartNew();

                    for (int i = 0; i < tabTestingDS.Rows.Count; i++)
                    {
                       

                        string _data = tabTestingDS.Rows[i]["gender"].ToString() + "," + tabTestingDS.Rows[i]["age"].ToString() + "," +
                            tabTestingDS.Rows[i]["hypertension"].ToString() + "," + tabTestingDS.Rows[i]["heartdisease"].ToString() + "," +
                            tabTestingDS.Rows[i]["evermarried"].ToString() + "," + tabTestingDS.Rows[i]["familyhistory"].ToString() + "," +
                            tabTestingDS.Rows[i]["worktype"].ToString() + "," + tabTestingDS.Rows[i]["Residencetype"].ToString() + "," +
                            tabTestingDS.Rows[i]["avgglucoselevel"].ToString() + "," + tabTestingDS.Rows[i]["bmi"].ToString() + "," +
                            tabTestingDS.Rows[i]["smokingstatus"].ToString() + "," + tabTestingDS.Rows[i]["alcohol"].ToString() + "," +
                                 tabTestingDS.Rows[i]["diabetes"].ToString() + "," + tabTestingDS.Rows[i]["bpsystolic"].ToString() + "," +
                                      tabTestingDS.Rows[i]["bpDiastolic"].ToString() + "," + tabTestingDS.Rows[i]["cholesterol"].ToString() + "," +
                                       tabTestingDS.Rows[i]["whitebloodcellcount"].ToString() + "," + tabTestingDS.Rows[i]["redbloodcellcount"].ToString();

                        string[] values = _data.Split(',');

                        string _output = NaiveBayes(values);

                        TableRow row = new TableRow();

                        TableCell _cell0 = new TableCell();
                        _cell0.Text = slNo + i + ".";
                        row.Controls.Add(_cell0);

                        TableCell _cell1 = new TableCell();
                        _cell1.Text = tabTestingDS.Rows[i]["Name"].ToString();
                        row.Controls.Add(_cell1);

                        //TableCell _cell1 = new TableCell();
                        //_cell1.Text = tabData.Rows[i]["age"].ToString();
                        //row.Controls.Add(_cell1);

                        //TableCell _cell2 = new TableCell();
                        //_cell2.Text = tabData.Rows[i]["gender"].ToString();
                        //row.Controls.Add(_cell2);

                        //TableCell _cell3 = new TableCell();
                        //_cell3.Text = tabData.Rows[i]["bp"].ToString();
                        //row.Controls.Add(_cell3);

                        //TableCell _cell4 = new TableCell();
                        //_cell4.Text = tabData.Rows[i]["weight"].ToString();
                        //row.Controls.Add(_cell4);

                        //TableCell _cell5 = new TableCell();
                        //_cell5.Text = tabData.Rows[i]["sugartested"].ToString();
                        //row.Controls.Add(_cell5);

                        //TableCell _cell6 = new TableCell();
                        //_cell6.Text = tabData.Rows[i]["familyhistory"].ToString();
                        //row.Controls.Add(_cell6);

                        //TableCell _cell7 = new TableCell();
                        //_cell7.Text = tabData.Rows[i]["smokes"].ToString();
                        //row.Controls.Add(_cell7);

                        //TableCell _cell8 = new TableCell();
                        //_cell8.Text = tabData.Rows[i]["alcohol"].ToString();
                        //row.Controls.Add(_cell8);



                        TableCell cellResult = new TableCell();
                        cellResult.Width = 250;
                        cellResult.Text = _output;
                        row.Controls.Add(cellResult);

                        tablePrediction.Controls.Add(row);

                        //if (_output.Equals("0"))
                        //{
                        //    ++_array0Res;
                        //}
                        //else if (_output.Equals("1"))
                        //{
                        //    ++_array1Res;
                        //}         

                        _Predictedoutput += _output + ",";
                    }

                    watch.Stop();
                    var elapsedMs = watch.ElapsedMilliseconds;
                    _timeNB = elapsedMs.ToString();

                    Session["NB_Time"] = _timeNB;

                    Session["Output"] = _timeNB + "," + _Predictedoutput.Substring(0, _Predictedoutput.Length - 1);
                }
            }
            catch
            {

            }
        }
        //function which contains binning coding
        private void binningMethod()
        {
            try
            {

                BLL obj = new BLL();
                DataTable tabDataset = new DataTable();
                ArrayList _mising = new ArrayList();

                tabDataset.Rows.Clear();
                //fetch the training dataset 
                tabDataset = obj.GetTrainingDataset();

                if (tabDataset.Rows.Count > 0)
                {
                    //code of binning method
                    for (int i = 0; i < tabDataset.Rows.Count; i++)
                    {
                        string _data = tabDataset.Rows[i]["gender"].ToString() + "," + tabDataset.Rows[i]["age"].ToString() + "," +
                             tabDataset.Rows[i]["hypertension"].ToString() + "," + tabDataset.Rows[i]["heartdisease"].ToString() + "," +
                             tabDataset.Rows[i]["evermarried"].ToString() + "," + tabDataset.Rows[i]["familyhistory"].ToString() + "," +
                             tabDataset.Rows[i]["worktype"].ToString() + "," + tabDataset.Rows[i]["Residencetype"].ToString() + "," +
                             tabDataset.Rows[i]["avgglucoselevel"].ToString() + "," + tabDataset.Rows[i]["bmi"].ToString() + "," +
                             tabDataset.Rows[i]["smokingstatus"].ToString() + "," + tabDataset.Rows[i]["alcohol"].ToString() + "," +
                                  tabDataset.Rows[i]["diabetes"].ToString() + "," + tabDataset.Rows[i]["bpsystolic"].ToString() + "," +
                                       tabDataset.Rows[i]["bpDiastolic"].ToString() + "," + tabDataset.Rows[i]["cholesterol"].ToString() + "," +
                                        tabDataset.Rows[i]["whitebloodcellcount"].ToString() + "," + tabDataset.Rows[i]["redbloodcellcount"].ToString();


                        string[] parameter = _data.Split(',');

                        for (int j = 0; j < parameter.Length; j++)
                        {
                            if (parameter[j].Equals("") || parameter.Equals("?"))
                            {
                                for (int k = 0; k < tabDataset.Rows.Count; k++)
                                {
                                    int id = 0;
                                    Random r = new Random();

                                    for (int x = 1; x <= 2; x++)
                                    {
                                        id = r.Next(9);
                                    }

                                    //setting value for ? and null value
                                    string _value = tabDataset.Rows[id][parameter[j]].ToString();
                                    _mising.Add(_value);
                                }
                            }

                        }
                    }
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "key", "<script>alert('Dataset Not Found!!!')</script>");
                }
            }
            catch
            {

            }
        }

        protected void btnResults_Click(object sender, EventArgs e)
        {
            btnPrediction_Click(sender, e);
            Response.Redirect("Results_NaiveBayes.aspx");
        }        

        double pi;
        int nc, n;
        double result;
        ArrayList output = new ArrayList();
        ArrayList mul = new ArrayList();    

        //function which contains the algorithm steps
        private string NaiveBayes(string[] values)
        {
            ArrayList s = new ArrayList();// we are creating object s arraylist because it support dynamic and easy to remove and add
            output.Clear();

            //try
            //{
            // we are storing possible out come in arraylist s
            s.Add("0");
            s.Add("1");
            s.Add("2");
            s.Add("3");

            BLL obj = new BLL();
            DataTable dt = new DataTable();
            dt = obj.GetTrainingDataset();// we are retriving training dataset and storing it into datatable dt

            int m = 18; // No of parameters we are considering to predict is 18 parameter(m represents no of parameters)
            double numer = 1.0;// numerator will be 1 because we will get 1 out of 4 output
            double dino = double.Parse(s.Count.ToString());// No of possible outcome that is 4
            double p = numer / dino;// 1/4 = 0.25 we got m and p(possible outcomes) value

            //storing parameters we have taken into features
            string[] features = { "gender", "age", "hypertension", "heart_disease", "ever_married", "family_history", "work_type", "Residence_type", "avg_glucose_level", "bmi", "smoking_status" , "alcohol",	"diabetes",	"BPsystolic",	"BPDiastolic",
                                    "cholesterol",	"whitebloodcellcount",	"redbloodcellcount"};



            // core of naive bayes means probability calculation part
            //s contains possible outcomes that is 4 so this for loop executes for 4 times
            for (int i = 0; i < s.Count; i++)
            {

                mul.Clear();

                 // features.Length contain no of parameter we are taking that is 18 where this for loop executes 18 times
                 // we need find the probability outcome for all the parameter we have considered 
                for (int j = 0; j < features.Length; j++)
                {
                    n = 0; // n calculate no of times input item is repaeted in the training dataset
                    nc = 0; // nc tells you no of records that is repeated and classified to result 0,1,2,3 

                    // this for loop will get executed how much the data training dataset contains approximately 5000
                    for (int d = 0; d < dt.Rows.Count; d++)
                    {
                        if (dt.Rows[d][j + 2].ToString().Equals(values[j]))
                        {
                            ++n;

                            if (dt.Rows[d][m + 2].ToString().Equals(s[i]))

                                ++nc;
                        }
                    }



                    // probability equation  p=nc+m*p/n+m
                    double x = m * p;
                    double y = n + m;
                    double z = nc + x;

                    pi = z / y;
                    mul.Add(Math.Abs(pi));
                }

                double mulres = 1.0;

                for (int z = 0; z < mul.Count; z++)
                {
                    mulres *= double.Parse(mul[z].ToString());// here we multiply all 18 probability values.
                }

                result = mulres * p;// multiplied values are multiplied with p(posibble outcomes)
                output.Add(Math.Abs(result));// we add to output arrayList
            }


            //Prediction

            ArrayList list1 = new ArrayList(); //here we are taking temporary list list1 to store the output value

            for (int x = 0; x < s.Count; x++)// iterates till x=4 because 4 possible outcome
            {
                list1.Add(output[x]);  //we add to list1 variable
            }

            list1.Sort(); // we sort in ascending order
            list1.Reverse(); // we reverse the order because higest possible outcome will be in first place

            string _output = null;

            for (int y = 0; y < s.Count; y++)
            {
                if (output[y].Equals(list1[0])) // we compare highest possible outcome to actual outpuy and compare.
                {
                    _output = s[y].ToString();

                    //if (_output.Equals("0"))
                    //{
                    //    _output = "No";
                    //}
                    //else
                    //{
                    //    _output = "Yes";
                    //}

                    return _output;
                }
            }
            //}
            //catch
            //{

            //}

            return _output;
        }

       

    }
}