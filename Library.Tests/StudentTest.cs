using System;
using System.Collections.Generic;
using Xunit;
using FluentAssertions;
using Library;

namespace UnitTest1
{

    public class StudentTest{
        private Admin _admin;
        private Teacher _teacher;

        private Student _student;
        public StudentTest(){
            _admin = new Admin("Test");
            _teacher = new Teacher("John");
            _admin.HireTeacher(_teacher);
            _student = new Student("Jane");
        }

        [Fact]
        public void StudentCanRegisterForAClass(){
            _teacher.CreateClass("Math","Math 1",_teacher, 1, 20, _admin);
            var x = _admin.SearchClasses("Math");
            _student.RegisterForClass(x as Class);
            _student.RegClassList.Should().HaveCount(1);
        }

    }

}