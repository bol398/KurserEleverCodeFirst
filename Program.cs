using System;
using Microsoft.EntityFrameworkCore;
using System.Threading;



namespace SQL
{
    class Program
    {

        static void Main(string[] args)
        {
            using (var schoolContext = new SchoolContext())
            {
                var student = new Student();
                student.Name = "AAA";
                schoolContext.Students.Add(student);
                schoolContext.SaveChanges();
            } 
        }
       
    }
}
