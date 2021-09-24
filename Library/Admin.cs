using System;
using System.Collections.Generic;
using System.Linq;

namespace Library
{
    public class Admin
    {
        public string Name;

        public List<Teacher> TeacherList = new List<Teacher>();
        public List<Class> ClassList = new List<Class>();
        public Admin(string name){
            Name = name;
        }

        public void HireTeacher(Teacher teacher){
            TeacherList.Add(teacher);
        }

        public IEnumerable<Teacher> GetAllTeachers(){
            return TeacherList;
        }

        public void UpdateClassList(Class c){
            ClassList.Add(c);
        }

        public IEnumerable<Class> SearchClasses(string searchOption){

            var x = ClassList.Where( klass => klass switch
            {
                Class c when c.Name == searchOption => true,
                Class c when c.Subject == searchOption => true,
                Class c when c.ClassTeacher.Name == searchOption => true,
                _=> false
                
            }).ToList();

            return x;
        }
        


    }
}
