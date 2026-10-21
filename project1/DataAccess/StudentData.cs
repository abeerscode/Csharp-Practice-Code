
using Entities;

namespace DataAccess
{
    public class StudentData
    {
        public List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();

            students.Add(new Student
            {
                Id = 1,
                Name = "Rahim",
                Age = 21
            });

            students.Add(new Student
            {
                Id = 2,
                Name = "Karim",
                Age = 22
            });

            students.Add(new Student
            {
                Id = 3,
                Name = "Ayesha",
                Age = 20
            });

            return students;
        }
    }
}
