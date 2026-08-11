using System;
using System.Collections.Generic;
using school_management.Repositories;

namespace school_management.Business
{
    internal class StudentBusiness
    {
        private StudentRepository repository = new StudentRepository();

        public void DisplayStudents()
        {
            repository.GetAllStudents();
        }

        public void InsertStudent(Student student)
        {
            repository.InsertStudent(student);
        }

        public void DeleteStudent(int id)
        {
            repository.DeleteStudent(id);
        }

        public void UpdateStudent(Student student)
        {
            repository.UpdateStudent(student);
        }
    }
}