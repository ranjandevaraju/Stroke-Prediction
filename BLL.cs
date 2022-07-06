using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using diseasePrediction.DataLayerTableAdapters;
using System.Data;

namespace diseasePrediction
{
    public class BLL
    {
        tblUsersTableAdapter userObj = new tblUsersTableAdapter();
        tblParametersTableAdapter parameterObj = new tblParametersTableAdapter();       
        tblTreatmentTableAdapter treatmentObj = new tblTreatmentTableAdapter();
        tblTrainingDatasetTableAdapter datasetObj = new tblTrainingDatasetTableAdapter();
        tblTestingDatasetTableAdapter testingObj = new tblTestingDatasetTableAdapter();
        tblActualDatasetTableAdapter actualObj = new tblActualDatasetTableAdapter();

        //login module

        //function to check the user login id and password(admin,doctor/rece)
        public DataTable CheckUserLogin(string userId, string password)
        {
            return userObj.CheckUserLogin(userId, password);
        }

        //User change Password
        public void UpdateUserPassword(string password, string userId)
        {
            userObj.UpdateUserPassword(password, userId);
        }

        //User management

        //function to insert new User
        public void InsertUser(string userId, string password, string userType, string emailId)
        {
            userObj.InsertUser(userId, password, userType, emailId);
        }

        //function to delete the user
        public void DeleteUser(string userId)
        {
            userObj.DeleteUser(userId);
        }

        //function to get other users(doc and rece)
        public DataTable GetOtherUsers()
        {
            return userObj.GetOtherUsers();
        }

        //function to retrive all users based on type
        public DataTable GetUsersByType(string userType)
        {
            return userObj.GetUsersByUserType(userType);
        }

        //function to check the userid
        public bool CheckUserId(string userId)
        {
            int cnt = int.Parse(userObj.CheckUserId(userId).ToString());

            if (cnt == 1)

                return false;

            return true;
        }


        //function to get the user by id
        public DataTable GetUserById(string userId)
        {
            return userObj.GetUserById(userId);
        }

        //function to update the user
        public void UpdateUser(string userId, string password, string type, string emailId, string UId)
        {
            userObj.UpdateUser(userId, password, type, emailId, UId);
        }

      
        //manage parameters

        //function to check the parameter
        public bool CheckParameter(string parameter)
        {
            int cnt = int.Parse(parameterObj.CheckParameter(parameter).ToString());

            if (cnt == 1)

                return false;

            return true;
        }

        //function to insert new parameter
        public void InsertParameter(string parameter)
        {
            parameterObj.InsertParameter(parameter);
        }

        //function to update parameter
        public void UpdateParameter(string parameter, int parameterId)
        {
            parameterObj.UpdateParameter(parameter, parameterId);
        }

        //function to delete parameter
        public void DeleteParameter(int parameterId)
        {
            parameterObj.DeleteParameter(parameterId);
        }

        //function to get the parameter based on id
        public DataTable GetParameterById(int parameterId)
        {
            return parameterObj.GetParameterById(parameterId);
        }

        //function to retrive all parameters
        public DataTable GetAllParameters()
        {
            return parameterObj.GetData();
        }

        
        //function to retirve all treatmentdetails
        public DataTable GetAllTreatments()
        {
            return treatmentObj.GetData();
        }

        //function to insert the treatment details
        public void InsertTreatment(int patientId, string treatment, DateTime date)
        {
            treatmentObj.InsertTreatment(patientId, treatment, date);
        }

        //function to delete the treatment details
        public void DeleteTreatment(int treatmentId)
        {
            treatmentObj.DeleteTreatment(treatmentId);
        }

        //function to get the treatment details by Ids
        public DataTable GetTreatmentByid(int treatmentId)
        {
            return treatmentObj.GetTreatmentById(treatmentId);
        }

        //function to get treatment by patientId
        public DataTable GetTreatmentByPatientId(int pId)
        {
            return treatmentObj.GetTreatmentByPatientId(pId);
        }

        //function to update the treatment details
        public void UpdateTreatment(int patientId, string treatment, DateTime date, int treatmentId)
        {
            treatmentObj.UpdateTreatment(patientId, treatment, date, treatmentId);
        }

        //manage dataset

        //function to get all training dataset
        public DataTable GetTrainingDataset()
        {
            return datasetObj.GetData();
        }

        //function to insert training data
        public void InsertTrainingData(string name, double gender, double age, double hypertension, double heartdisease, double evermarried, double familyhistory,
                                        double worktype, double residencetype, double avgglucoselevel, double bmi, double smokingstatus,
                                        double alcohol, double diabetes, double bpsystolic, double bpdiastolic,
                                        double cholesterol, double whitebloodcellcount, double redbloodcellcount, int Result)
        {
            datasetObj.InsertTrainingDataset(name,gender,age,hypertension,heartdisease,evermarried,familyhistory,worktype,residencetype,avgglucoselevel,bmi,smokingstatus,alcohol,diabetes,bpsystolic,bpdiastolic,
                cholesterol,whitebloodcellcount,redbloodcellcount, Result);
        }

        //function to update training data
        public void UpdateTrainingData(string name, double gender, double age, double hypertension, double heartdisease, double evermarried, double familyhistory,
                                        double worktype, double residencetype, double avgglucoselevel, double bmi, double smokingstatus,
                                        double alcohol, double diabetes, double bpsystolic, double bpdiastolic,
                                        double cholesterol, double whitebloodcellcount, double redbloodcellcount, int Result, int datasetId)
        {
            datasetObj.UpdateTrainingDataset(name, gender, age, hypertension, heartdisease, evermarried, familyhistory, worktype, residencetype, avgglucoselevel, bmi, smokingstatus, alcohol, diabetes, bpsystolic, bpdiastolic,
                cholesterol, whitebloodcellcount, redbloodcellcount, Result, datasetId);
        }

        //function to delete training data
        public void DeleteTrainingData(int datasetId)
        {
            datasetObj.DeleteTrainingDataset(datasetId);
        }

        //function to fetch training data by id
        public DataTable GetTrainingDataById(int Id)
        {
            return datasetObj.GetTrainingDatasetById(Id);
        }

        //manage testing dataset

        //function to get all testing dataset
        public DataTable GetTestingDataset()
        {
            return testingObj.GetData();
        }

        //function to insert testing data
        public void InsertTestingData(string name, double gender, double age, double hypertension, double heartdisease, double evermarried, double familyhistory,
                                        double worktype, double residencetype, double avgglucoselevel, double bmi, double smokingstatus,
                                        double alcohol, double diabetes, double bpsystolic, double bpdiastolic,
                                        double cholesterol, double whitebloodcellcount, double redbloodcellcount)
        {
            testingObj.InsertTestingDataset(name, gender, age, hypertension, heartdisease, evermarried, familyhistory, worktype, residencetype, avgglucoselevel, bmi, smokingstatus, alcohol, diabetes, bpsystolic, bpdiastolic,
                cholesterol, whitebloodcellcount, redbloodcellcount);
        }

        //function to update testing data
        public void UpdateTestingData(string name, double gender, double age, double hypertension, double heartdisease, double evermarried, double familyhistory,
                                        double worktype, double residencetype, double avgglucoselevel, double bmi, double smokingstatus,
                                        double alcohol, double diabetes, double bpsystolic, double bpdiastolic,
                                        double cholesterol, double whitebloodcellcount, double redbloodcellcount,
                                        int datasetId)
        {
            testingObj.UpdateTestingDataset(name, gender, age, hypertension, heartdisease, evermarried, familyhistory, worktype, residencetype, avgglucoselevel, bmi, smokingstatus, alcohol, diabetes, bpsystolic, bpdiastolic,
                cholesterol, whitebloodcellcount, redbloodcellcount, datasetId);
        }

        //function to delete the testing data
        public void DeleteTestingData(int testingDataId)
        {
            testingObj.DeleteTestingDataset(testingDataId);
        }

        //function to fetch testing data by id
        public DataTable GetTestingDataById(int Id)
        {
            return testingObj.GetTestingDatasetById(Id);
        }


        //function to fetch GetActualPatientDataById
        public DataTable GetActualPatientDataById(int patId)
        {
            return actualObj.GetActualdataByPatientId(patId);
        }

        //function to get actual cnt
        public int GetActualCnt()
        {
            return (int)actualObj.GetActualCnt();
        }

       //function to load all actual dataset
        public DataTable GetActualDataset()
        {
            return actualObj.GetData();
        }

        //function to insert actual data
        public void InsertActualData(string name, double gender, double age, double hypertension, double heartdisease, double evermarried, double familyhistory,
                                        double worktype, double residencetype, double avgglucoselevel, double bmi, double smokingstatus,
                                        double alcohol, double diabetes, double bpsystolic, double bpdiastolic,
                                        double cholesterol, double whitebloodcellcount, double redbloodcellcount, int Result)
        {
            actualObj.InsertActualDataset(name, gender, age, hypertension, heartdisease, evermarried, familyhistory, worktype, residencetype, avgglucoselevel, bmi, smokingstatus, alcohol, diabetes, bpsystolic, bpdiastolic,
                cholesterol, whitebloodcellcount, redbloodcellcount, Result);
        }

        //function to update actual data
        public void UpdateActualData(string name, double gender, double age, double hypertension, double heartdisease, double evermarried, double familyhistory,
                                        double worktype, double residencetype, double avgglucoselevel, double bmi, double smokingstatus,
                                        double alcohol, double diabetes, double bpsystolic, double bpdiastolic,
                                        double cholesterol, double whitebloodcellcount, double redbloodcellcount, int Result, int datasetId)
        {
            actualObj.UpdateActualDataset(name, gender, age, hypertension, heartdisease, evermarried, familyhistory, worktype, residencetype, avgglucoselevel, bmi, smokingstatus, alcohol, diabetes, bpsystolic, bpdiastolic,
                cholesterol, whitebloodcellcount, redbloodcellcount, Result, datasetId);
        }

        //function to delete actual data
        public void DeleteActualData(int datasetId)
        {
            actualObj.DeleteActualDataset(datasetId);
        }

        //function to fetch actual data by id
        public DataTable GetActualDataById(int Id)
        {
            return actualObj.GetActualDatasetById(Id);
        }

        public bool CheckPatientLoginn(int userId, float pwd)
        {
            int cnt = int.Parse(testingObj.CheckPatientLogin(userId, pwd).ToString());

            if (cnt == 1)

                return true;

            return false;
        }
       
    }
}