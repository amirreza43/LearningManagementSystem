using System;
using Xunit;
using FluentAssertions;
using Library;

namespace UnitTest1
{
    public class AdminTests{

        private Admin _admin;
        private Teacher _teacher;
        public AdminTests(){
            _admin = new Admin("test");
            _teacher = new Teacher("John Doe");
        }

        [Fact]
        public void AdminShouldHaveAccessToAllTheTeachers(){
            _admin.TeacherList.Should().HaveCount(0);
        }

        [Fact]
        public void AdminCanHireTeachers(){
            _admin.HireTeacher(_teacher);
            _admin.TeacherList.Should().HaveCount(1);
        }

        [Fact]
        public void AdminGetAllTeachersReturnsAllTeachers(){
            _admin.HireTeacher(_teacher);
            var x = _admin.GetAllTeachers();
            x.Should().HaveCount(1);
        }

        [Fact]
        public void AdminUpdateClassListWorkProperly(){
            _admin.HireTeacher(_teacher);
            Class klass= new Class("Math","Math 1",_teacher, 1, 20);
            _admin.UpdateClassList(klass);
            _admin.ClassList.Should().HaveCount(1);
        }

        [Fact]
        public void AdminCanSearchInClassList(){
            _admin.HireTeacher(_teacher);
            Class klass= new Class("Math","Math 1",_teacher, 1, 20);
            _admin.UpdateClassList(klass);
            var x = _admin.SearchClasses("Math");
            x.Should().HaveCount(1);
        }

    }
}