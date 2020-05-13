using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ELMAHDEMOAPPMVC.Models
{
    public class EmployeeDB
    {
        private SqlConnection con;
        public void createConnection()
        {
            string constring = ConfigurationManager.ConnectionStrings["elmah-sqlserver"].ToString();
            con = new SqlConnection(constring);
        }

        public bool addEmployees(tblEmployee objEmp)
        {
            

            createConnection();
            SqlCommand cmd = new SqlCommand("AddNewEmployee", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@EmpName", objEmp.EmpName);
            cmd.Parameters.AddWithValue("@DOB", objEmp.DOB);
            cmd.Parameters.AddWithValue("@Department", objEmp.Department);
            cmd.Parameters.AddWithValue("@Employeeid", objEmp.Employeeid);

            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i >= 1)
                return true;
            else
                return false;

            
        }

        public List<tblEmployee> getAllEmployees()
        {
            List<tblEmployee> allEmps = new List<tblEmployee>();

            createConnection();
            SqlCommand cmd = new SqlCommand("SelectallEmployee", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            con.Open();
            sd.Fill(dt);
            con.Close();

            foreach (DataRow dr in dt.Rows)
            {
                allEmps.Add(
                    new tblEmployee
                    {
                        Id = Convert.ToInt32(dr["Id"]),
                        Employeeid  = Convert.ToString(dr["Employeeid"]),
                        EmpName  = Convert.ToString(dr["EmpName"]),
                        Department  = Convert.ToString(dr["Department"]),
                        DOB= Convert.ToString(dr["DOB"]),

                    });
            }
            
            return allEmps; 
        }

    }
}