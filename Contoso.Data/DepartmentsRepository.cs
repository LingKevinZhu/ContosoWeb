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
    public class DepartmentsRepository : IRepository<Departments>
    {
        public void Add(Departments entity)
        {
            using (SqlConnection conn = new SqlConnection(DB_Helper.GetConnection()))
            {
                conn.Open();

                SqlCommand com = new SqlCommand();
                com.CommandText = "proc_Departments_Add";
                com.CommandType = CommandType.StoredProcedure;
                com.Connection = conn;

                com.Parameters.AddWithValue("@Name", entity.Name);
                com.Parameters.AddWithValue("@Budget", entity.Budget);
                com.Parameters.AddWithValue("@StartDate", entity.StartDate);
                com.Parameters.AddWithValue("@InstructorID", entity.InstructorID);
                com.Parameters.AddWithValue("@RowVersion", entity.RowVersion);
                com.Parameters.AddWithValue("@CreatedDate", entity.CreatedDate);
                com.Parameters.AddWithValue("@CreatedBy", entity.CreatedBy);
                com.Parameters.AddWithValue("@UpdatedDate", entity.UpdatedDate);
                com.Parameters.AddWithValue("@UpdatedBy", entity.UpdatedBy);

                com.ExecuteNonQuery();
            }
        }

        public Departments PrintOne(int id)
        {
            using (SqlConnection conn = new SqlConnection(DB_Helper.GetConnection()))
            {
                conn.Open();

                SqlCommand com = new SqlCommand();
                com.CommandText = "proc_Departments_PrintOne";
                com.CommandType = CommandType.StoredProcedure;
                com.Connection = conn;

                com.Parameters.AddWithValue("ID", id);
                SqlDataReader reader = com.ExecuteReader();
                Departments departments = new Departments();

                while (reader.Read())
                {
                    departments.ID = Convert.ToInt32(reader["ID"]);
                    departments.Name = reader["Name"].ToString();
                    departments.Budget = Convert.ToDouble(reader["Budget"]);
                    departments.StartDate = Convert.ToDateTime(reader["StartDate"]);
                    departments.InstructorID = Convert.ToInt32(reader["InstructorID"]);
                    departments.RowVersion = Convert.ToInt32(reader["RowVersion"]);
                    departments.CreatedDate = Convert.ToDateTime(reader["CreatedDate"]);
                    departments.CreatedBy = reader["CreatedBy"].ToString();
                    departments.UpdatedDate = Convert.ToDateTime(reader["UpdatedDate"]);
                    departments.UpdatedBy = reader["UpdatedBy"].ToString();
                }
                return departments;
            }
        }

        public List<Departments> PrintAll()
        {
            using (SqlConnection conn = new SqlConnection(DB_Helper.GetConnection()))
            {
                conn.Open();

                SqlCommand com = new SqlCommand();
                com.CommandText = "proc_Departments_PrintAll";
                com.CommandType = CommandType.StoredProcedure;
                com.Connection = conn;

                SqlDataReader reader = com.ExecuteReader();
                List<Departments> list = new List<Departments>();

                while (reader.Read())
                {
                    Departments departments = new Departments();
                    departments.ID = Convert.ToInt32(reader["ID"]);
                    departments.Name = reader["Name"].ToString();
                    departments.Budget = Convert.ToDouble(reader["Budget"]);
                    departments.StartDate = Convert.ToDateTime(reader["StartDate"]);
                    departments.InstructorID = Convert.ToInt32(reader["InstructorID"]);
                    departments.RowVersion = Convert.ToInt32(reader["RowVersion"]);
                    departments.CreatedDate = Convert.ToDateTime(reader["CreatedDate"]);
                    departments.CreatedBy = reader["CreatedBy"].ToString();
                    departments.UpdatedDate = Convert.ToDateTime(reader["UpdatedDate"]);
                    departments.UpdatedBy = reader["UpdatedBy"].ToString();
                    list.Add(departments);
                }
                return list;
            }
        }

        public void Delete(Departments entity)
        {
            using (SqlConnection conn = new SqlConnection(DB_Helper.GetConnection()))
            {
                conn.Open();

                SqlCommand com = new SqlCommand();
                com.CommandText = "proc_Departments_Delete";
                com.CommandType = CommandType.StoredProcedure;
                com.Connection = conn;
                com.Parameters.AddWithValue("@ID", entity.ID);

                com.ExecuteNonQuery();
                conn.Close();
                conn.Dispose();
            }
        }

        public void Update(Departments entity)
        {
            using (SqlConnection conn = new SqlConnection(DB_Helper.GetConnection()))
            {
                conn.Open();

                SqlCommand com = new SqlCommand();
                com.CommandText = "proc_Departments_Update";
                com.CommandType = CommandType.StoredProcedure;
                com.Connection = conn;

                com.Parameters.AddWithValue("@ID", entity.ID);
                com.Parameters.AddWithValue("@Name", entity.Name);
                com.Parameters.AddWithValue("@Budget", entity.Budget);
                com.Parameters.AddWithValue("@StartDate", entity.StartDate);
                com.Parameters.AddWithValue("@InstructorID", entity.InstructorID);
                com.Parameters.AddWithValue("@RowVersion", entity.RowVersion);
                com.Parameters.AddWithValue("@CreatedDate", entity.CreatedDate);
                com.Parameters.AddWithValue("@CreatedBy", entity.CreatedBy);
                com.Parameters.AddWithValue("@UpdatedDate", entity.UpdatedDate);
                com.Parameters.AddWithValue("@UpdatedBy", entity.UpdatedBy);

                com.ExecuteNonQuery();
            }
        }
    }
}
