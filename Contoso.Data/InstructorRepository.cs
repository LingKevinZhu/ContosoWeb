using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Models;
using System.Data;
using System.Data.SqlClient;

namespace Contoso.Data
{
    public class InstructorRepository:IRepository<Instructor>
    {

        public void Add(Instructor entity)
        {
            using (SqlConnection conn = new SqlConnection(DB_Helper.GetConnection()))
            {
                conn.Open();

                SqlCommand com = new SqlCommand();
                com.CommandText = "proc_Instructor_Add";
                com.CommandType = CommandType.StoredProcedure;
                com.Connection = conn;
                com.Parameters.AddWithValue("@ID", entity.ID);
                com.Parameters.AddWithValue("@HireDate", entity.HireDate);

                com.ExecuteNonQuery();
            }
        }

        public Instructor PrintOne(int id)
        {
            using (SqlConnection conn = new SqlConnection(DB_Helper.GetConnection()))
            {
                conn.Open();

                SqlCommand com = new SqlCommand();
                com.CommandText = "proc_Instructor_PrintOne";
                com.CommandType = CommandType.StoredProcedure;
                com.Connection = conn;

                com.Parameters.AddWithValue("ID", id);
                SqlDataReader reader = com.ExecuteReader();
                Instructor instructor = new Instructor();

                while (reader.Read())
                {
                    instructor.ID = Convert.ToInt32(reader["ID"]);
                    instructor.HireDate = Convert.ToDateTime(reader["HireDate"]);
                }
                return instructor;
            }
        }

        public List<Instructor> PrintAll()
        {
            using (SqlConnection conn = new SqlConnection(DB_Helper.GetConnection()))
            {
                conn.Open();

                SqlCommand com = new SqlCommand();
                com.CommandText = "proc_Instructor_PrintAll";
                com.CommandType = CommandType.StoredProcedure;
                com.Connection = conn;

                SqlDataReader reader = com.ExecuteReader();
                List<Instructor> list = new List<Instructor>();

                while (reader.Read())
                {
                    Instructor instructor = new Instructor();
                    instructor.ID = Convert.ToInt32(reader["ID"]);
                    instructor.HireDate = Convert.ToDateTime(reader["HireDate"]);
                    list.Add(instructor);
                }
                return list;
            }
        }

        public void Delete(Instructor entity)
        {
            using (SqlConnection conn = new SqlConnection(DB_Helper.GetConnection()))
            {
                conn.Open();

                SqlCommand com = new SqlCommand();
                com.CommandText = "proc_Instructor_Delete";
                com.CommandType = CommandType.StoredProcedure;
                com.Connection = conn;
                com.Parameters.AddWithValue("@ID", entity.ID);

                com.ExecuteNonQuery();
            }
        }

        public void Update(Instructor entity)
        {
            using (SqlConnection conn = new SqlConnection(DB_Helper.GetConnection()))
            {
                conn.Open();

                SqlCommand com = new SqlCommand();
                com.CommandText = "proc_Instructor_Update";
                com.CommandType = CommandType.StoredProcedure;
                com.Connection = conn;

                com.Parameters.AddWithValue("@ID", entity.ID);
                com.Parameters.AddWithValue("@HireDate", entity.HireDate);

                com.ExecuteNonQuery();
            }
        }
    }
}
