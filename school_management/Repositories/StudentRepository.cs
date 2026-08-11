using Microsoft.Data.SqlClient;
using System.Configuration;

namespace school_management.Repositories
{
    internal class StudentRepository
    {
        private string connectionString =
            ConfigurationManager.ConnectionStrings["SchoolDB"].ConnectionString;

        public void GetAllStudents()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand("GetAllStudents", con))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        Console.WriteLine("ID\tNAME\tSURNAME\tROLL NO\tCLASS");
                        Console.WriteLine("--------------------------------------------");

                        while (reader.Read())
                        {
                            Console.WriteLine(
                                $"{reader["s_id"]}\t" +
                                $"{reader["s_name"]}\t" +
                                $"{reader["s_surname"]}\t" +
                                $"{reader["roll_number"]}\t" +
                                $"{reader["class"]}"
                            );
                        }
                    }
                }
            }
        }

        public void InsertStudent(Student student)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand("InsertStudent", con))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id", student.id);
                    cmd.Parameters.AddWithValue("@name", student.name);
                    cmd.Parameters.AddWithValue("@surname", student.surname);
                    cmd.Parameters.AddWithValue("@roll", student.roll);
                    cmd.Parameters.AddWithValue("@class", student.studentClass);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void DeleteStudent(int id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand("DeleteStudent", con))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void UpdateStudent(Student student)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand("UpdateStudent", con))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id", student.id);
                    cmd.Parameters.AddWithValue("@name", student.name);
                    cmd.Parameters.AddWithValue("@surname", student.surname);
                    cmd.Parameters.AddWithValue("@roll", student.roll);
                    cmd.Parameters.AddWithValue("@class", student.studentClass);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }

}