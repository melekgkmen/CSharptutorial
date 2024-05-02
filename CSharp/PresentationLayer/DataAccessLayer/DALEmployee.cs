using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using EntityLayer;
using System.Data;
using System.Reflection;
using System.Runtime.Remoting.Messaging;

namespace DataAccessLayer
{
    public class DALEmployee
    {
        public static List<EntityEmployee> ListOfStaff()
        {
            List<EntityEmployee> values = new List<EntityEmployee>();
            SqlCommand command1 = new SqlCommand("SELECT * FROM TBLINFPORMATION", Connection.cn);
            if(command1.Connection.State!=ConnectionState.Open)
            {
                command1.Connection.Open();
            } 
            SqlDataReader dr = command1.ExecuteReader();
            while(dr.Read())
            {
                EntityEmployee emp = new EntityEmployee();
                emp.Id = int.Parse(dr["ID"].ToString());
                emp.Name = dr["NAME"].ToString();
                emp.Surname = dr["SURNAME"].ToString();
                emp.City = dr["CITY"].ToString();
                emp.Duty = dr["DUTY"].ToString();
                values.Add(emp);

            }
            dr.Close();
            return values;
        }

        public static int AddStaff (EntityEmployee e)
        {
            SqlCommand command2 = new SqlCommand("insert into TBLINFORMATION(NAME,SURNAME,CITY,DUTY) VALUES (@P1,@P2,@P3,@P4)",Connection.cn);
            if(command2.Connection.State!=ConnectionState.Open)
            {
                command2.Connection.Open();
            }
            command2.Parameters.AddWithValue("@P1", e.Name);
            command2.Parameters.AddWithValue("@P2", e.Surname);
            command2.Parameters.AddWithValue("@P3", e.City);
            command2.Parameters.AddWithValue("@P4", e.Duty);

            return command2.ExecuteNonQuery();
        }

        public static bool LLDeleteStaff(int e)
        {
            SqlCommand command3 = new SqlCommand("Delete from TBLINFORMATION where ID=@P1", Connection.cn);
            if(command3.Connection.State!=ConnectionState.Open)
            {
                command3.Connection.Open();
            }

            command3.Parameters.AddWithValue("@P1", e);
            return command3.ExecuteNonQuery()>0;
        }

        public static bool UpdateStaff(EntityEmployee emp)
        {
            SqlCommand command4 = new SqlCommand("Update TBLINFORMATION SET AD=@P1,SOYAD=P2 WHERE ID=@P6", Connection.cn);
            if(command4.Connection.State!=ConnectionState.Open)
            {
                command4.Connection.Open();
            }
            command4.Parameters.AddWithValue("@P1",emp.Name);
            return command4.ExecuteNonQuery() > 0;
        }





    }
}
