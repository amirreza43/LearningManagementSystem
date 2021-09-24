using System;
using System.Collections.Generic;
using Library;
using System.Linq;
namespace Application
{
    class Program
    {
        public static List<Admin> AdminList = new List<Admin>();
        public static Admin admin;
        public static Teacher teacher;
        static void Main(string[] args)
        {
        bool loopOption = true;

            while (loopOption)
            {

                Console.WriteLine("Type 1 for Admin Options \nType 2 for Teacher Options \nType 3 for Student options");
                var selectOpt = Int32.Parse(Console.ReadLine());
                if(selectOpt == 1){

                    AdminTerminal.Terminal();

                    continue;
                    

                }else if(selectOpt == 2){

                  TeacherTerminal.terminal();

                  continue;

                }else if(selectOpt == 3){

                    

                }else
                {
                    Console.WriteLine("Please selecet a correct option");
                    continue;
                }
            }


            

            // admin.HireTeacher(teacher);

            // var x = admin.GetAllTeachers();
            // foreach (var item in x)
            // {
            //     Console.WriteLine($"Teacher list: {item.Name}");
            // }

            // teacher.CreateClass("Math 1", "Math", teacher, 1, 20, admin);

            // var y = teacher.GetTeacherClassList();
            // foreach (var item in y)
            // {
            //     Console.WriteLine($"Teacher Class list: {item.Name}");
            // }

            
            // var z = admin.SearchClasses("Math 1");
            // foreach (var item in z)
            // {
            //     Console.WriteLine($"Search Res: {item.Name}");
            // }
        
        }
    }
}
