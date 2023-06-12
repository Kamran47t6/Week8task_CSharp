using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t2_week8lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Kamran", "Lahore", "Computer Science", 2, 20.0);
            Student s2 = new Student("Abdullah ", "LAhore", "Mathematics", 3, 25.0);

            Staff staff1 = new Staff("xyz", "DHA", "Economics", 5000.0);
            Staff staff2 = new Staff("Abdullah", "Science", "Business", 6000.0);

            Console.WriteLine("Student 1: " + s1.ToString());
            Console.WriteLine("Student 2: " + s2.ToString());
            Console.WriteLine("Staff 1: " + staff1.ToString());
            Console.WriteLine("Staff 2: " + staff2.ToString());
            Console.ReadKey();
        }
    }
    public class Person
    {
        protected string name;
        protected string address;
        public Person(string name,string address)
        {

        }
        public string getname()
        {
            return name;
        }
        public string getaddress()
        {
            return address;
        }
        public void setaddress(string address)
        {
            this.address = address;
        }
        public override string ToString()
        {
            return "Name: " + name + ", Address: " + address;
        }
    }
    public class Student : Person
    {
        private string program;
        private int year;
        private double fee;
        public Student(string name,string address,string program,int year,double fee) : base(name, address)
        {
            this.name = name;
            this.address = address;
            this.program = program;
            this.year = year;
            this.fee = fee;
        }
        public string Program
        {
            get
            {
                return program;
            }
            set
            {
                program = value;
            }
        }
        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                year = value;
            }
        }
       
        public double Fee
        {
            get
            {
                return fee;
            }
            set
            {
                fee = value;
            }
        }
    }
    public class Staff : Person
    {
        private string school;
        private double pay;
        public Staff(string name,string address,string school,double pay) : base(name, address)
        {

        }
        public string School
        {
            get
            {
                return school;
            }
            set
            {
                school = value;
            }

        }
        public double Pay
        {
            get
            {
                return pay;
            }
            set
            {
                pay = value;
            }
        }
            
    }
}
