using school_management.Repositories;

namespace school_management.Business
{
    internal class TeacherBusiness
    {
        private IGenericRepository<Teacher> repository;

        public TeacherBusiness(IGenericRepository<Teacher> repository)
        {
            this.repository = repository;
        }

        // DISPLAY ALL TEACHERS
        public void DisplayTeachers()
        {
            repository.GetAll();
        }

        // INSERT TEACHER
        public void InsertTeacher(Teacher teacher)
        {
            repository.Insert(teacher);
        }

        // DELETE TEACHER
        public void DeleteTeacher(int teacher_id)
        {
            repository.Delete(teacher_id);
        }

        // UPDATE TEACHER
        public void UpdateTeacher(Teacher teacher)
        {
            repository.Update(teacher);
        }
    }
}