using System.IO;
using System;

namespace Program
{
    class Person
    {
    public void Greet()
     {
        Console.WriteLine("Hello");
     }
    public void SetAge(int age)
     {
        Console.WriteLine("My age is "+age);
     }
    }
    
    class Student:Person
    {
        public void Study()
        {
            Console.WriteLine("I'm studying on the Screen");
        }
    }
    class Professor:Person
    {
        public void Explain()
        {
            Console.WriteLine("I am explaining on the screen");
        }
        public class StudentProfessorTest
        {
          public static void Main()
              {
                  Person person = new Person();
                  person.Greet();
                  Student student = new Student();
                  student.SetAge(22);
                  Professor professor = new Professor();
                  professor.SetAge(40);
                  professor.Greet();
                  professor.Explain();
              }
        }
    }
}