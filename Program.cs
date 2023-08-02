using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Section5._4
{
    public struct Student
    {
        public string name;
        public string address;
        public int rollNumber;
        public string className;
        public DateTime dateOfBirth;


        public Student(string name, string address, int rollNumber, string className, DateTime dateOfBirth)
        {
            this.name = name;
            this.address = address;
            this.rollNumber = rollNumber;
            this.className = className;
            this.dateOfBirth = dateOfBirth;
        }

        public static void printStr(Student[] stu)
        {
           
            for (int i = 0; i < stu.Length; i++)
            {
                Console.WriteLine($"Students details are:{i}");
                Console.Write(stu[i].name + ",");
                Console.Write(stu[i].address + ",");
                Console.Write(stu[i].rollNumber + ",");
                Console.Write(stu[i].className + ",");
                Console.Write(stu[i].dateOfBirth);
                Console.WriteLine("------------------------");
            }



        }





        internal class Program
        {
            static void Main(string[] args)
            {
                Student[] students = new Student[3];
                for (int i = 0; i < students.Length; i++)
                {
                    Console.WriteLine("Enter student Name");
                    students[i].name = Console.ReadLine();
                    Console.WriteLine("Enter address of student");
                    students[i].address = Console.ReadLine();
                    Console.WriteLine("Enter roll number for student");
                    students[i].rollNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter class name");
                    students[i].className = Console.ReadLine();
                    Console.WriteLine("Enter student DOB");
                    students[i].dateOfBirth = DateTime.Parse(Console.ReadLine());
                }
                    Student.printStr(students);

                   
                }

            }


        }
    }
   


   