using System;
using System.Collections.Generic;
namespace Library
{
    public class Teacher
    {
        public string Name;

        public List<Class> TeacherClassList = new List<Class>();

        public List<Student> StudentList = new List<Student>();

        public Teacher(string name){

            Name = name;

        }

        public void CreateClass(string name, string subject, Teacher teacher, int classId,int seatCap , Admin admin){
            Class klass = new Class(name, subject, teacher, classId, seatCap);
            TeacherClassList.Add(klass);
            admin.UpdateClassList(klass);
        }

        public void StartClass(Class klass){
            klass.IsRegActive = false;
        }

        public IEnumerable<Class> GetTeacherClassList(){
            return TeacherClassList;
        }

        public void AddStudent(Student student){
            StudentList.Add(student);
        }

    }
}
