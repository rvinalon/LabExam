using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHelper
{
    public class DataAccess
    {
        static string myConStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\LabExam\LabExam\App_Data\MasterFile.mdf;Integrated Security=True";
        SqlConnection myConn = new SqlConnection(myConStr);

        public void SaveRecords(string firstName, string lastName, string emailAdd, string passWord)
        {
            myConn.Open();
            SqlCommand saveCmd = new SqlCommand("SaveRecords", myConn);
            saveCmd.CommandType = CommandType.StoredProcedure;
            saveCmd.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = firstName;
            saveCmd.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = lastName;
            saveCmd.Parameters.Add("@EmailAdd", SqlDbType.NVarChar).Value = emailAdd;
            saveCmd.Parameters.Add("@PassWord", SqlDbType.NVarChar).Value = passWord;
            saveCmd.ExecuteNonQuery();
            myConn.Close();
        }

        public void SaveLoanApplication(LoanApplication application)
        {
            myConn.Open();
            SqlCommand saveCmd = new SqlCommand("AddLoanApplication", myConn);
            saveCmd.CommandType = CommandType.StoredProcedure;
            saveCmd.Parameters.Add("@EmailAdd", SqlDbType.NVarChar).Value = application.EmailAdd;
            saveCmd.Parameters.Add("@LoanAmount", SqlDbType.Decimal).Value = application.LoanAmount;
            saveCmd.Parameters.Add("@Interest", SqlDbType.Decimal).Value = application.Interest;
            saveCmd.Parameters.Add("@InterestRate", SqlDbType.Decimal).Value = application.InterestRate;
            saveCmd.Parameters.Add("@TakeHomeLoan", SqlDbType.Decimal).Value = application.TakeHomeLoan;
            saveCmd.Parameters.Add("@ServiceCharge", SqlDbType.Decimal).Value = application.ServiceCharge;
            saveCmd.Parameters.Add("@MonthlyAmortization", SqlDbType.Decimal).Value = application.MonthlyAmortization;

            saveCmd.ExecuteNonQuery();
            myConn.Close();
        }

        public DataSet DisplayRecords()
        {
            SqlDataAdapter da = new SqlDataAdapter("DisplayRecords", myConn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            da.Fill(ds, "myRecords");
            return ds;
        }

        public DataSet DisplayLoanApplications()
        {
            SqlDataAdapter da = new SqlDataAdapter("DisplayLoanApplications", myConn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            da.Fill(ds, "loanApplications");
            return ds;
        }

        public LoginRecord GetRecord(string email, string password)
        {
            LoginRecord record = new LoginRecord();
            myConn.Open();
            SqlCommand getCmd = new SqlCommand("GetRecord", myConn);
            getCmd.CommandType = CommandType.StoredProcedure;
            getCmd.Parameters.Add("@Username", SqlDbType.NVarChar).Value = email;
            getCmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = password;
            
            SqlDataReader reader = getCmd.ExecuteReader();
            while (reader.Read())
            {
                record.FirstName = reader["FirstName"].ToString();
                record.LastName = reader["LastName"].ToString();
                record.EmailAdd = reader["EmailAdd"].ToString();
                record.Password = reader["PassWord"].ToString();
            }

            return record;
        }
    }
}
