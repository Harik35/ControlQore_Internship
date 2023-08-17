using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication_Enity_Framework_10_08_2023.Controllers;

namespace WebApplication_Enity_Framework_10_08_2023.Models
{
    public class DbFile
    {
        public int StudentDataUsingSP(Student dbStudent)
        {
            string connectionString = "server=localhost, 1401;database=StudentTableC#;user id=sa;password=Pass@word;" +
        "TrustServerCertificate=true";

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            string query = "AddIteM";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;


            SqlParameter paramName = new SqlParameter();
            paramName.ParameterName = "Name";
            paramName.Value = dbStudent.Name;
            paramName.SqlDbType = System.Data.SqlDbType.VarChar;
            paramName.Size = 10;

            SqlParameter paramAge = new SqlParameter();
            paramAge.ParameterName = "age";
            paramAge.Value = dbStudent.Age;
            paramAge.SqlDbType = System.Data.SqlDbType.Int;

            SqlParameter paramMark = new SqlParameter();
            paramMark.ParameterName = "mar";
            paramMark.Value = dbStudent.Mark;
            paramMark.SqlDbType = System.Data.SqlDbType.Float;

            SqlParameter paramDept = new SqlParameter();
            paramDept.ParameterName = "Dep";
            paramDept.Value = dbStudent.Dep;
            paramDept.SqlDbType = System.Data.SqlDbType.VarChar;
            paramDept.Size = 10;

            SqlParameter paramReturn = new SqlParameter();
            paramReturn.SqlDbType = System.Data.SqlDbType.Int;
            paramReturn.Direction = System.Data.ParameterDirection.ReturnValue;

            SqlParameter returnValueParam = new SqlParameter();
            returnValueParam.SqlDbType = System.Data.SqlDbType.Int;
            returnValueParam.Direction = System.Data.ParameterDirection.ReturnValue;
            cmd.Parameters.Add(returnValueParam);


            cmd.Parameters.Add(paramName);
            cmd.Parameters.Add(paramMark);
            cmd.Parameters.Add(paramAge);
            cmd.Parameters.Add(paramDept);
            cmd.Parameters.Add(paramReturn);

            cmd.ExecuteNonQuery();

            int ret = (int)returnValueParam.Value;
            return ret;
        }



    }
}
