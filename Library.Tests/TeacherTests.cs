using System;
using Xunit;
using FluentAssertions;
using Library;

namespace UnitTest1
{
    public class TeacherTests{

        private Admin _admin;
        private Teacher _teacher;
        public TeacherTests(){
            _admin = new Admin("Test");
            _teacher = new Teacher("John");
            _admin.HireTeacher(_teacher);
        }

        [Fact]
        public void TeacherCreateClassShouldCreateAClass(){
            _teacher.CreateClass("Math","Math 1",_teacher, 1, 20, _admin);
            _teacher.TeacherClassList.Should().HaveCount(1);
        }

        [Fact]
        public void TeacherStartClassStartsAClass(){
            
            _teacher.CreateClass("Math","Math 1",_teacher, 1, 20, _admin);

            _teacher.StartClass(_teacher.TeacherClassList[0]);

            _teacher.TeacherClassList[0].IsRegActive.Should().BeFalse();
        }
       
        [Fact]
        public void TeacherGetClassListReturnsAllClasses(){
            
            _teacher.CreateClass("Math","Math 1",_teacher, 1, 20, _admin);

            var x = _teacher.GetTeacherClassList();

            x.Should().HaveCount(1);
        }

    }

}