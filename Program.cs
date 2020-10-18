using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var student1 = new Student();
            student1.LastName = "Smith";
            student1.FirstName = "John";
            student1.Identifier = new Identifier(1);

            var student2 = new Student();
            student2.LastName = "Smith";
            student2.FirstName = "John";
            student2.Identifier = new Identifier(1);
            
            student1.showName();
            student2.showName();

            Console.WriteLine((student1 == student2).ToString());
            Console.WriteLine((student1.Identifier.Id == student2.Identifier.Id).ToString());
            var myobject = new Object();
            myobject.ToString();
        }
    }

    public class Student
    {
        public string FirstName {get; set;}

        public string LastName {get; set;}

        public string Address {get; set;}

        public Identifier Identifier {get; set;}
        public void showName()
        {
            Console.WriteLine(FirstName + " " + LastName +  " " + Identifier.Id.ToString());
        }
    }

    public struct Identifier
    {
        public Identifier(int id)
        {
            Id = id;
        }
        public int Id {get; set;}
    }

    public enum myEnum
    {
        enum1
    }
}
