using school_management.Repositories;

namespace school_management.Business
{
    internal class StudentBusiness
    {
        private IGenericRepository<Student> repository;

        public StudentBusiness(IGenericRepository<Student> repository)
        {
            this.repository = repository;
        }

        public void DisplayStudents()
        {
            repository.GetAll();
        }

        public void InsertStudent(Student student)
        {
            repository.Insert(student);
        }

        public void DeleteStudent(int id)
        {
            repository.Delete(id);
        }

        public void UpdateStudent(Student student)
        {
            repository.Update(student);
        }
    }
}