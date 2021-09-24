using System;
using System.Collections.Generic;

namespace Library
{
    public class Student
    {
        public string Name;

        public List<int> Grades;

        public List<Class> RegClassList = new List<Class>();

        public Student(string name){
            Name = name;
        }

        public void RegisterForClass(Class klass){
            RegClassList.Add(klass);
            // klass.ClassTeacher.AddStudent(this);
        }

    }
}