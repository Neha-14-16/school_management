namespace school_management
{
    internal class TeacherBusiness
    {
        private TeacherRepository repository = new TeacherRepository();


        // DISPLAY ALL TEACHERS
        public void DisplayTeachers()
        {
            repository.GetAllTeachers();
        }


        // INSERT TEACHER
        public void InsertTeacher(Teacher teacher)
        {
            repository.InsertTeacher(teacher);
        }


        // DELETE TEACHER
        public void DeleteTeacher(int teacher_id)
        {
            repository.DeleteTeacher(teacher_id);
        }


        // UPDATE TEACHER
        public void UpdateTeacher(Teacher teacher)
        {
            repository.UpdateTeacher(teacher);
        }
    }
}