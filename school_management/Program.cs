using System;
using school_management.Business;
using school_management.Repositories;


namespace school_management
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IGenericRepository<Student> repository = new GenericRepository<Student>();
            StudentBusiness studentBusiness = new StudentBusiness(repository);
            IGenericRepository<Teacher> teacherRepository =
     new GenericRepository<Teacher>();

            TeacherBusiness teacherBusiness =
                new TeacherBusiness(teacherRepository);
            while (true)
            {
                

                Console.WriteLine("======================================");
                Console.WriteLine("       SCHOOL MANAGEMENT SYSTEM");
                Console.WriteLine("======================================");
                Console.WriteLine("1. Student Operations");
                Console.WriteLine("2. Teacher Operations");
                Console.WriteLine("3. Exit");
                Console.WriteLine("======================================");

                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                   
                    // STUDENT OPERATIONS
                    

                    case "1":

                        while (true)
                        {
                            

                            Console.WriteLine("======================================");
                            Console.WriteLine("       STUDENT OPERATIONS");
                            Console.WriteLine("======================================");
                            Console.WriteLine("1. Display Students");
                            Console.WriteLine("2. Insert Student");
                            Console.WriteLine("3. Delete Student");
                            Console.WriteLine("4. Update Student");
                            Console.WriteLine("5. Back");
                            Console.WriteLine("======================================");

                            Console.Write("Enter your choice: ");

                            string studentChoice = Console.ReadLine();

                            switch (studentChoice)
                            {
                                case "1":

                                    studentBusiness.DisplayStudents();

                                    Console.WriteLine();
                                    Console.WriteLine("Press Enter to continue...");
                                    Console.ReadLine();

                                    break;


                                case "2":

                                    Student student = new Student();

                                    Console.Write("Enter Student ID : ");
                                    student.id = Convert.ToInt32(Console.ReadLine());

                                    Console.Write("Enter Name : ");
                                    student.name = Console.ReadLine();

                                    Console.Write("Enter Surname : ");
                                    student.surname = Console.ReadLine();

                                    Console.Write("Enter Roll Number : ");
                                    student.roll = Convert.ToInt32(Console.ReadLine());

                                    Console.Write("Enter Class : ");
                                    student.studentClass = Console.ReadLine();

                                    studentBusiness.InsertStudent(student);

                                    Console.WriteLine();
                                    Console.WriteLine("Press Enter to continue...");
                                    Console.ReadLine();

                                    break;


                                case "3":

                                    Console.Write("Enter Student ID to delete : ");
                                    int deleteId = Convert.ToInt32(Console.ReadLine());

                                    studentBusiness.DeleteStudent(deleteId);

                                    Console.WriteLine();
                                    Console.WriteLine("Press Enter to continue...");
                                    Console.ReadLine();

                                    break;


                                case "4":

                                    Student updateStudent = new Student();

                                    Console.Write("Enter Student ID to update : ");
                                    updateStudent.id = Convert.ToInt32(Console.ReadLine());

                                    Console.Write("Enter New Name : ");
                                    updateStudent.name = Console.ReadLine();

                                    Console.Write("Enter New Surname : ");
                                    updateStudent.surname = Console.ReadLine();

                                    Console.Write("Enter New Roll Number : ");
                                    updateStudent.roll = Convert.ToInt32(Console.ReadLine());

                                    Console.Write("Enter New Class : ");
                                    updateStudent.studentClass = Console.ReadLine();

                                    studentBusiness.UpdateStudent(updateStudent);

                                    Console.WriteLine();
                                    Console.WriteLine("Press Enter to continue...");
                                    Console.ReadLine();

                                    break;


                                case "5":

                                    // Go back to main menu
                                    break;


                                default:

                                    Console.WriteLine();
                                    Console.WriteLine("Invalid choice. Please enter 1 to 5.");
                                    Console.WriteLine("Press Enter to continue...");
                                    Console.ReadLine();

                                    break;
                            }

                            if (studentChoice == "5")
                            {
                                break;
                            }
                        }

                        break;


                    
                    // TEACHER OPERATIONS
                  

                    case "2":

                        while (true)
                        {
                            

                            Console.WriteLine("======================================");
                            Console.WriteLine("       TEACHER OPERATIONS");
                            Console.WriteLine("======================================");
                            Console.WriteLine("1. Display Teachers");
                            Console.WriteLine("2. Insert Teacher");
                            Console.WriteLine("3. Delete Teacher");
                            Console.WriteLine("4. Update Teacher");
                            Console.WriteLine("5. Back");
                            Console.WriteLine("======================================");

                            Console.Write("Enter your choice: ");

                            string teacherChoice = Console.ReadLine();

                            switch (teacherChoice)
                            {
                                
                                case "1":

                                    teacherBusiness.DisplayTeachers();

                                    Console.WriteLine();
                                    Console.WriteLine("Press Enter to continue...");
                                    Console.ReadLine();

                                    break;


                              
                                case "2":

                                    Teacher teacher = new Teacher();

                                    Console.Write("Enter Teacher ID : ");
                                    teacher.teacher_id = Convert.ToInt32(Console.ReadLine());

                                    Console.Write("Enter Teacher Name : ");
                                    teacher.teacher_name = Console.ReadLine();

                                    Console.Write("Enter Teacher Surname : ");
                                    teacher.teacher_surname = Console.ReadLine();

                                    Console.Write("Enter Subject : ");
                                    teacher.subject = Console.ReadLine();

                                    teacherBusiness.InsertTeacher(teacher);

                                    Console.WriteLine();
                                    Console.WriteLine("Press Enter to continue...");
                                    Console.ReadLine();

                                    break;


                                case "3":

                                    Console.Write("Enter Teacher ID to delete : ");

                                    int deleteTeacherId =
                                        Convert.ToInt32(Console.ReadLine());

                                    teacherBusiness.DeleteTeacher(deleteTeacherId);

                                    Console.WriteLine();
                                    Console.WriteLine("Press Enter to continue...");
                                    Console.ReadLine();

                                    break;


                                case "4":

                                    Teacher updateTeacher = new Teacher();

                                    Console.Write("Enter Teacher ID to update : ");
                                    updateTeacher.teacher_id =
                                        Convert.ToInt32(Console.ReadLine());

                                    Console.Write("Enter New Teacher Name : ");
                                    updateTeacher.teacher_name =
                                        Console.ReadLine();

                                    Console.Write("Enter New Teacher Surname : ");
                                    updateTeacher.teacher_surname =
                                        Console.ReadLine();

                                    Console.Write("Enter New Subject : ");
                                    updateTeacher.subject =
                                        Console.ReadLine();

                                    teacherBusiness.UpdateTeacher(updateTeacher);

                                    Console.WriteLine();
                                    Console.WriteLine("Press Enter to continue...");
                                    Console.ReadLine();

                                    break;


                                // ------------------------------
                                // BACK
                                // ------------------------------

                                case "5":

                                    break;


                                default:

                                    Console.WriteLine();
                                    Console.WriteLine("Invalid choice. Please enter 1 to 5.");
                                    Console.WriteLine("Press Enter to continue...");
                                    Console.ReadLine();

                                    break;
                            }

                            if (teacherChoice == "5")
                            {
                                break;
                            }
                        }

                        break;


                    

                    case "3":

                        Console.WriteLine();
                        Console.WriteLine("Exiting the program...");
                        return;


                    default:

                        Console.WriteLine();
                        Console.WriteLine("Invalid choice. Please enter 1 to 3.");
                        Console.WriteLine("Press Enter to continue...");
                        Console.ReadLine();

                        break;
                }
            }
        }
    }
}