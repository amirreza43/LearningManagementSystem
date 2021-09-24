using System;
using System.Collections.Generic;

namespace Library
{
    public class Class
    {
        public string Name;
        public string Subject;

        public Teacher ClassTeacher;

        public List<Student> StudentList= new List<Student>();

        public int ClassId;
        public int SeatCap;

        public bool IsRegActive = true;

        public Class(string name, string subject, Teacher teacher, int classId, int seatCap){
            Name = name;
            Subject = subject;
            ClassTeacher = teacher;
            ClassId = classId;
            SeatCap = seatCap;
        }

        public void RegisterStudent(Student student){
            if(IsRegActive){
                StudentList.Add(student);
            }else{
                Console.WriteLine("Registration for this class is closed.");
            }
        }

        public IEnumerable<Student> GetStudents(){
            return StudentList;
        }

        public void DropStudent(Student student){
            if(StudentList.Contains(student)){
                StudentList.Remove(student);
            }
        }

    }
}
