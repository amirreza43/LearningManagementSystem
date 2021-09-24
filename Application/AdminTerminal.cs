using System;
using System.Collections.Generic;
using Library;
using System.Linq;
namespace Application
{
    public class AdminTerminal
    {

        public static void Terminal(){
            
            Console.WriteLine("Write your name:");
                    var adminName = Console.ReadLine();
                    var x = Program.AdminList.Where( admin => admin switch
                    {
                       Admin a when a.Name == adminName => true,
                       _=> false
                    }).ToList();
                    if(x.Count > 0){
                        Program.admin = x[0];
                    }else{
                        Program.admin = new Admin(adminName);
                        Program.AdminList.Add(Program.admin);
                    }
                    
                    Console.WriteLine("Type 1 to hire a teacher\nType 2 to get a list of all teachers");
                    var adminOpt = Int32.Parse(Console.ReadLine());
                    if(adminOpt == 1){
                        Console.WriteLine("Enter the name of the new teacher:");
                        var newTeacherName = Console.ReadLine();
                        Program.teacher = new Teacher(newTeacherName);
                        Program.admin.HireTeacher(Program.teacher);
                    } else if(adminOpt == 2){
                        var allTeachers = Program.admin.GetAllTeachers();
                        foreach (var item in allTeachers)
                        {
                            Console.WriteLine($"Teacher Name is: {item.Name}");
                        }
                    }
        }

    }
}