using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_And_Objects
{
    class Student
    {
        int Roll_NO;
        string Name;
        int Age;
        int Std;

        public void SetStudent()
        {
            Console.WriteLine("Enter Roll No = ");
            this.Roll_NO = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Name = ");
            this.Name = Console.ReadLine();

            Console.WriteLine("Enter Age = ");
            this.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Standard =");
            this.Std = int.Parse(Console.ReadLine());
        }

        public void GetStudent()
        {
            Console.WriteLine("\n Your Roll Is : {0}", this.Roll_NO);
            Console.WriteLine("\n Your Name Is : {0}",this.Name);
            Console.WriteLine("\n Your Age Is  : {0}",this.Age);
            Console.WriteLine("\n Your Standard Is : {0}",this.Std);
            
        }
        static void Main(string[] args)
        {

            Student Stu1 = new Student();
            Stu1.SetStudent();
            Stu1.GetStudent();
            Console.ReadLine();

            Student Stu2 = new Student();
            Stu2.SetStudent();
            Stu2.GetStudent();
        }
    }
}
