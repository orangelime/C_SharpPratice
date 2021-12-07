using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpPratice
{
    class Student : Person
    {
        //public string name;
        //public int age;
        public string school;

        public Student(string name,int age,string school)
        {
            this.name = name;
            this.age = age;
            this.school = school;
        }

        //public void PrintAge()
        //{
        //    Console.WriteLine(this.age);
        //}
        //public void PrintName()
        //{
        //    Console.WriteLine(this.name);
        //}
        public void PrintSchool()
        {
            Console.WriteLine(this.school);
        }
    }
}
