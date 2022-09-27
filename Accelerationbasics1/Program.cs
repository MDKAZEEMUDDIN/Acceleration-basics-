using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accelerationbasics1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*-----------Function with return type---------------*/
            /*
            int value = Sum();
            Console.WriteLine($" the Sum of value is : {value}");
            Console.ReadKey();
        }
        static int Sum()
        {
            int a = 10;
            int b = 20;
            int sum = a+ b;
            return sum;
            */
            /*override Tostring method*/
            /*
            Student emp = new Student();
            emp.Name1 = "vireesh";
            emp.Name2 = "Ameet";
            Console.WriteLine(emp.ToString());
            Console.ReadLine();
        }
    }
    public class Student
    {
        public string Name1;
        public string Name2;

    
    */
            /*-----------override equals method--------------*/
            Student s1 = new Student();
            s1.Name1 = "suresh";
            s1.Name2 = "Ramesh";
            Student s2 = new Student();
            s2.Name1= "Kumar";
            s2.Name2 = "Suresh";
            Console.WriteLine($"C1 == C2: {s1 == s2}");
            Console.WriteLine($"C1.Equals(C2): {s1.Equals(s2)}");
            Console.ReadLine();
        }
    }
    public class Student
    {
        public string Name1 { get; set; }
        public string Name2 { get; set; }
        public override bool Equals(object obj)
        {
            // If the passed object is null, return False
            if (obj == null)
            {
                return false;
            }
            // If the passed object is not Student Type, return False
            if (!(obj is Student))
            {
                return false;
            }
            return (this.Name1== ((Student)obj).Name1) && (this.Name1 == ((Student)obj).Name2);

        }
    }
}
