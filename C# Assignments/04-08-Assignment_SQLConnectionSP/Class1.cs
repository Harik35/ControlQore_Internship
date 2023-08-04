using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlConnection_1
{
    public class Class1
    {
        public int StudentDataUsingSP(string name, int age, float Mark, string dept)
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
            paramName.Value = name;
            paramName.SqlDbType = System.Data.SqlDbType.VarChar;
            paramName.Size = 10;

            SqlParameter paramAge = new SqlParameter();
            paramAge.ParameterName = "age";
            paramAge.Value = age;
            paramAge.SqlDbType = System.Data.SqlDbType.Int;

            SqlParameter paramMark = new SqlParameter();
            paramMark.ParameterName = "mar";
            paramMark.Value = Mark;
            paramMark.SqlDbType = System.Data.SqlDbType.Float;

            SqlParameter paramDept = new SqlParameter();
            paramDept.ParameterName = "Dep";
            paramDept.Value = dept;
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

        public int AddElementManually(string name,int age, float mark, string dept)
        {
            string connectionString = "server=localhost, 1401;database=StudentTableC#;user id=sa;password=Pass@word;" +
        "TrustServerCertificate=true";

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "insert into StudentTable(Name, Age,Mark, Department) values(@name, @age, @mark, @Depart)";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;

            SqlParameter paramName = new SqlParameter();
            paramName.ParameterName = "Name";
            paramName.Value = name;
            paramName.SqlDbType = System.Data.SqlDbType.VarChar;
            paramName.Size = 30;

            SqlParameter paramAge = new SqlParameter();
            paramAge.ParameterName = "age";
            paramAge.Value = age;
            paramAge.SqlDbType = System.Data.SqlDbType.Int;

            SqlParameter paramSalary2 = new SqlParameter();
            paramSalary2.ParameterName = "mark";
            paramSalary2.Value = mark;
            paramSalary2.SqlDbType = System.Data.SqlDbType.Decimal;

            SqlParameter department2 = new SqlParameter();
            department2.ParameterName = "Depart";
            department2.Value = dept;
            department2.SqlDbType = System.Data.SqlDbType.VarChar;
            department2.Size = 30;

            cmd.Parameters.Add(paramName);
            cmd.Parameters.Add(paramAge);
            cmd.Parameters.Add(paramSalary2);
            cmd.Parameters.Add(department2);

            int num = cmd.ExecuteNonQuery();

            return num;
        }

    }
}
