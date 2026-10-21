using DataAccess;
using Entities;

namespace Facade
{
    public class TeacherFacade
    {
        public List<Teacher> GetTeachers()
        {
            TeacherData data = new TeacherData();

            return data.GetTeachers();
        }
    }
}