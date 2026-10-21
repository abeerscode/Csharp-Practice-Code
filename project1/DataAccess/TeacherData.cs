using Entities;

namespace DataAccess
{
    public class TeacherData
    {
        public List<Teacher> GetTeachers()
        {
            List<Teacher> teachers = new List<Teacher>();

            teachers.Add(new Teacher
            {
                Name = "Rahim",
                Id = 1,
                Age = 35
            });

            teachers.Add(new Teacher
            {
                Name = "Karim",
                Id = 2,
                Age = 42
            });

            teachers.Add(new Teacher
            {
                Name = "Ayesha",
                Id = 3,
                Age = 29
            });

            teachers.Add(new Teacher
            {
                Name = "Nusrat",
                Id = 4,
                Age = 38
            });

            teachers.Add(new Teacher
            {
                Name = "Hasan",
                Id = 5,
                Age = 45
            });

            return teachers;
        }
    }
}
