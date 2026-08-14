using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;
using school_management;

namespace school_management.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T>
    {
        private string connectionString =
            ConfigurationManager.ConnectionStrings["SchoolDB"].ConnectionString;

        public void GetAll()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string procedureName = "";

                if (typeof(T) == typeof(Student))
                {
                    procedureName = "GetAllStudents";
                }
                else if (typeof(T) == typeof(Teacher))
                {
                    procedureName = "GetAllTeachers";
                }

                using (SqlCommand cmd = new SqlCommand(procedureName, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (typeof(T) == typeof(Student))
                        {
                            Console.WriteLine();
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
                        else if (typeof(T) == typeof(Teacher))
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
        }

        public void Insert(T entity)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                if (typeof(T) == typeof(Student))
                {
                    Student student = (Student)(object)entity;

                    using (SqlCommand cmd = new SqlCommand("InsertStudent", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@id", student.id);
                        cmd.Parameters.AddWithValue("@name", student.name);
                        cmd.Parameters.AddWithValue("@surname", student.surname);
                        cmd.Parameters.AddWithValue("@roll", student.roll);
                        cmd.Parameters.AddWithValue("@class", student.studentClass);

                        cmd.ExecuteNonQuery();
                    }
                }
                else if (typeof(T) == typeof(Teacher))
                {
                    Teacher teacher = (Teacher)(object)entity;

                    using (SqlCommand cmd = new SqlCommand("InsertTeacher", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@teacher_id", teacher.teacher_id);
                        cmd.Parameters.AddWithValue("@teacher_name", teacher.teacher_name);
                        cmd.Parameters.AddWithValue("@teacher_surname", teacher.teacher_surname);
                        cmd.Parameters.AddWithValue("@subject", teacher.subject);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        public void Update(T entity)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                if (typeof(T) == typeof(Student))
                {
                    Student student = (Student)(object)entity;

                    using (SqlCommand cmd = new SqlCommand("UpdateStudent", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@id", student.id);
                        cmd.Parameters.AddWithValue("@name", student.name);
                        cmd.Parameters.AddWithValue("@surname", student.surname);
                        cmd.Parameters.AddWithValue("@roll", student.roll);
                        cmd.Parameters.AddWithValue("@class", student.studentClass);

                        cmd.ExecuteNonQuery();
                    }
                }
                else if (typeof(T) == typeof(Teacher))
                {
                    Teacher teacher = (Teacher)(object)entity;

                    using (SqlCommand cmd = new SqlCommand("UpdateTeacher", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@teacher_id", teacher.teacher_id);
                        cmd.Parameters.AddWithValue("@teacher_name", teacher.teacher_name);
                        cmd.Parameters.AddWithValue("@teacher_surname", teacher.teacher_surname);
                        cmd.Parameters.AddWithValue("@subject", teacher.subject);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        public void Delete(int id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                if (typeof(T) == typeof(Student))
                {
                    using (SqlCommand cmd = new SqlCommand("DeleteStudent", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@id", id);

                        cmd.ExecuteNonQuery();
                    }
                }
                else if (typeof(T) == typeof(Teacher))
                {
                    using (SqlCommand cmd = new SqlCommand("DeleteTeacher", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@teacher_id", id);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}

    