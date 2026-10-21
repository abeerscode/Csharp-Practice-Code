using DataAccess;
using Entities;

namespace Facade
{
    public class StudentFacade
    {
        public List<Student> GetStudents()
        {
            StudentData data = new StudentData();

            return data.GetStudents();
        }
    }
}
