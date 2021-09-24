using System;
using System.Collections.Generic;
using Library;
using System.Linq;
namespace Application
{
    public class TeacherTerminal
    {

        public static void terminal(){
            Console.WriteLine("Please enter the name of your admin: ");
                    var adminName = Console.ReadLine();
                    var x = Program.AdminList.Where( admin => admin switch
                    {
                       Admin a when a.Name == adminName => true,
                       _=> false
                    }).ToList();
                    if(x.Count > 0){
                        Program.admin = x[0];
                    }else{
                        Console.WriteLine("This admin does not exist.");
                    }
                    Console.WriteLine("Please enter your name: ");
                    var teacherName = Console.ReadLine();
                    var y = Program.admin.TeacherList.Where( teacher => teacher switch
                    {
                       Teacher t when t.Name == teacherName => true,
                       _=> false  
                    }).ToList();
                    if(y.Count > 0){
                        Program.teacher = y[0];
                        Console.WriteLine("Type 1 to create a class\nType 2 to start a class and stop registration\nType 3 to get all your assigned classes");
                        var teacherOpt = Int32.Parse(Console.ReadLine());

                        if(teacherOpt == 1){

                            Console.WriteLine("Class name: ");
                            var className = Console.ReadLine();

                            Console.WriteLine("Subject: ");
                            var classSubject = Console.ReadLine();

                            Console.WriteLine("Seat Capacity: ");
                            var seatCap = Int32.Parse(Console.ReadLine());
                            
                            Console.WriteLine("Class Id: ");
                            var classId = Int32.Parse(Console.ReadLine());

                            Program.teacher.CreateClass(className, classSubject, Program.teacher, classId, seatCap, Program.admin);

                        }else if(teacherOpt == 2){
                            Console.WriteLine("Class name: ");
                            var className = Console.ReadLine();
                            var teacherClassList = Program.teacher.GetTeacherClassList();
                            var z = teacherClassList.Where( klass => klass switch
                            {
                                Class c when c.Name == className => true,
                                _=> false
                                
                            }).ToList();
                            if(z.Count > 0){
                                Class klass = z[0];
                                Program.teacher.StartClass(klass);
                                Console.WriteLine("Class has now been started and Registration is closed.");
                            }else {
                                Console.WriteLine("Class was not found");
                            }
                        }else if(teacherOpt == 3){

                            var teacherClassList = Program.teacher.GetTeacherClassList();
                            foreach (var item in teacherClassList)
                            {
                                Console.WriteLine($"Name of the class: {item.Name} , Subject of the class: {item.Subject}");
                            }
                        } else{
                        Console.WriteLine("This teacher is not on the list.");
                        }
                    }
        }

    }
    
}