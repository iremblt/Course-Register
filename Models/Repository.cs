using System.Collections.Generic;
namespace CourseRegister.Models
{
    public static class Repository
    {
        private static List<Students>_students=new List<Students>();
        public static List<Students> Students{
            get{
                return _students;
            }
        }
        public static void AddStudent(Students students){
            _students.Add(students);
        }
    }
}