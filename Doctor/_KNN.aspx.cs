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
    public partial class _KNN : System.Web.UI.Page
    {       
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadTestingDataset();
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
                    mainrow.BackColor = System.Drawing.Color.Green;

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
                        //"age","bloodpressure","specificgravity","albumin","sugar","redbloodcells","puscell","puscellclumps",
                        //"bacteria","bloodglucoserandom","bloodurea","serumcreatinine","sodium","potassium","hemoglobin",
                        //"packedcellvolume","whitebloodcellcount","redbloodcellcount","hypertension","diabetesmellitus",
                        //"coronaryarterydisease","appetite","pedaledema","anemia"

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

                        string _output = KNN(values);

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

                    Session["KNN_Time"] = _timeNB;

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
            Response.Redirect("Results_KNN.aspx");
        }

        ArrayList output = new ArrayList();
        ArrayList mul = new ArrayList();





        //function which contains the KNN algorithm steps
        private string KNN(string[] values)
        {
            ArrayList _Distance = new ArrayList();
            ArrayList _PatientId = new ArrayList();

            ArrayList s = new ArrayList();// i am just creating a s array list to store possible outcomes 
            output.Clear();

            //try
            //{
            // possible outcomes
            s.Add("0");
            s.Add("1");
            s.Add("2");
            s.Add("3");

            //training Dataset
            BLL obj=new BLL ();
            DataTable dt = new DataTable();
            dt = obj.GetTrainingDataset();
                       
            int m = 25; //k value

            //finding the distance between the objects between test data and each row of training data
            // this for loop will get executed how much the data training dataset contains approximately 5000
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                double _val = 0.0;
                // total no of attributes ie 18 times
                for (int j = 0; j < values.Length; j++)
                {
                    string _valluee = dt.Rows[i][j + 2].ToString();

                    if (_valluee.Equals("?") || values[j].ToString().Equals("?") ||
                        _valluee.Equals("") || values[j].ToString().Equals(""))
                    {

                    }
                    else
                    {
                        _val += Math.Pow(double.Parse(dt.Rows[i][j + 2].ToString()) - double.Parse(values[j].ToString()), 2);
                    }
                }

                _val = Math.Sqrt(_val);

                _Distance.Add(Math.Round(_val, 1));
                _PatientId.Add(i);
            }

            ArrayList temp = new ArrayList();
            ArrayList arrayPatients = new ArrayList();

            ArrayList arrayExists = new ArrayList();
            int d = 0;

            for (int x = 0; x < _Distance.Count; x++)
            {
                temp.Add(_Distance[x]);
            }

            temp.Sort();

            for (int y = 0; y < m; y++)
            {
                d = 0;

                for (int z = 0; z < _Distance.Count; z++)
                {
                    if (_Distance[z].Equals(temp[y]))
                    {
                        if (d == 0 && !arrayExists.Contains(_PatientId[z]))
                        {
                            arrayPatients.Add(_PatientId[z]);

                            arrayExists.Add(_PatientId[z]);

                            ++d;

                        }
                    }
                }
            }

            string _output = null;

            if (arrayPatients.Count > 0)
            {
                int cnt;

                ArrayList arrayCnt = new ArrayList();
                ArrayList arrayOutcome = new ArrayList();

                for (int i = 0; i < s.Count; i++)
                {
                    cnt = 0;

                    for (int j = 0; j < arrayPatients.Count; j++)
                    {
                        if (dt.Rows[int.Parse(arrayPatients[j].ToString())]["Result"].ToString().Equals(s[i]))
                        {
                            ++cnt;
                        }
                    }

                    arrayCnt.Add(cnt);
                    arrayOutcome.Add(s[i]);
                }

                //prediction

                ArrayList temp1 = new ArrayList();

                for (int x = 0; x < arrayCnt.Count; x++)
                {
                    temp1.Add(arrayCnt[x]);
                }

                temp1.Sort();
                temp1.Reverse();



                for (int y = 0; y < arrayCnt.Count; y++)
                {
                    if (arrayCnt[y].Equals(temp1[0]))
                    {
                        _output = s[y].ToString();

                        return _output;

                    }
                }
            }

            return _output;
        }
             


    }
}