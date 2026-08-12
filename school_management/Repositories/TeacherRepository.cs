using Microsoft.Data.SqlClient;
using System.Configuration;

namespace school_management
{
    internal class TeacherRepository
    {
        private string connectionString =
            ConfigurationManager.ConnectionStrings["SchoolDB"].ConnectionString;


        // GET ALL TEACHERS
        public void GetAllTeachers()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand("GetAllTeachers", con))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        Console.WriteLine();
                        Console.WriteLine("ID\tNAME\tSURNAME\tSUBJECT");
                        Console.WriteLine("---------------------------------------------");

                        while (reader.Read())
                        {
                            Console.WriteLine(
                                $"{reader["teacher_id"]}\t" +
                                $"{reader["teacher_name"]}\t" +
                                $"{reader["teacher_surname"]}\t" +
                                $"{reader["subject"]}"
                            );
                        }
                    }
                }
            }
        }


        // INSERT TEACHER
        public void InsertTeacher(Teacher teacher)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand("InsertTeacher", con))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@teacher_id", teacher.teacher_id);
                    cmd.Parameters.AddWithValue("@teacher_name", teacher.teacher_name);
                    cmd.Parameters.AddWithValue("@teacher_surname", teacher.teacher_surname);
                    cmd.Parameters.AddWithValue("@subject", teacher.subject);

                    cmd.ExecuteNonQuery();
                }
            }
        }


        // DELETE TEACHER
        public void DeleteTeacher(int teacher_id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand("DeleteTeacher", con))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@teacher_id", teacher_id);

                    cmd.ExecuteNonQuery();
                }
            }
        }


        // UPDATE TEACHER
        public void UpdateTeacher(Teacher teacher)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand("UpdateTeacher", con))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@teacher_id", teacher.teacher_id);
                    cmd.Parameters.AddWithValue("@teacher_name", teacher.teacher_name);
                    cmd.Parameters.AddWithValue("@teacher_surname", teacher.teacher_surname);
                    cmd.Parameters.AddWithValue("@subject", teacher.subject);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}