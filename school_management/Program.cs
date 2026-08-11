using System;
using school_management.Business;

namespace school_management
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentBusiness business = new StudentBusiness();

            while (true)
            {
                
                Console.WriteLine("======================================");
                Console.WriteLine("       SCHOOL MANAGEMENT SYSTEM");
                Console.WriteLine("======================================");
                Console.WriteLine("1. Display Students");
                Console.WriteLine("2. Insert Student");
                Console.WriteLine("3. Delete Student");
                Console.WriteLine("4. Update Student");
                Console.WriteLine("5. Exit");
                Console.WriteLine("======================================");

                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":

                        business.DisplayStudents();

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

                        business.InsertStudent(student);

                        Console.WriteLine();
                        Console.WriteLine("Press Enter to continue...");
                        Console.ReadLine();

                        break;


                    case "3":

                        Console.Write("Enter Student ID to delete : ");
                        int deleteId = Convert.ToInt32(Console.ReadLine());

                        business.DeleteStudent(deleteId);

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

                        business.UpdateStudent(updateStudent);

                        Console.WriteLine();
                        Console.WriteLine("Press Enter to continue...");
                        Console.ReadLine();

                        break;


                    case "5":

                        Console.WriteLine("Exiting the program...");
                        return;


                    default:

                        Console.WriteLine("Invalid choice. Please enter 1 to 5.");

                        Console.WriteLine();
                        Console.WriteLine("Press Enter to continue...");
                        Console.ReadLine();

                        break;
                }
            }
        }
    }
}