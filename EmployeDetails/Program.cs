using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeDetails
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Console.Write("Enter the employee details :");
             Console.Write("Enter the employee Id :");
             int EmployeeID = Convert.ToInt32(Console.ReadLine());
             Console.Write("Enter the employee Name :");
             string Name = Console.ReadLine();
             Console.Write("Enter  the employee Salary :");
             int Salary = Convert.ToInt32(Console.ReadLine());
             Console.Write("Enter the employee Address :");
             string Address = Console.ReadLine();
             Console.Write("Enter the  employee Department :");
             string Department = Console.ReadLine();
             Console.WriteLine("\n Employee details are :");
             Console.WriteLine($"Employee ID Is: {EmployeeID}");
             Console.WriteLine($"Employee Name Is: {Name}");
             Console.WriteLine($"Employee Salary Is: {Salary}");
             Console.WriteLine($"Employee Address Is: {Address}");
             Console.WriteLine($"Employee Department Is: {Department}");
             Console.ReadLine();
            
            /*-------Implicit type casting---------------*/
            
            int numInt = 2400;
            //Getting the type of numInt
            Type numIntType = numInt.GetType();
            // Implicit typecasting Conversion
            double numDouble = numInt;
            //Getting typecasting of numDouble
            Type numDoubleType = numDouble.GetType();
            //  Before value Conversion
            Console.WriteLine($"numInt value: {numInt}");
            Console.WriteLine($"numIntType value is : {numIntType}");
            Console.WriteLine($"Int Size: {sizeof(int)} ");
            //  After value Conversion
            Console.WriteLine($"numDouble value: {numDouble}");
            Console.WriteLine($"numDoubleType value is : {numDoubleType}");
            Console.WriteLine($"double Size: {sizeof(double)} ");
            Console.ReadLine();
            
            /*------------- Explicit type casting-----------------*/

            
            double numberDouble = 260.34;
            // Explicit Type Casting
            int num1Int = (int)numberDouble;
            //  Before value Conversion
            Console.WriteLine("Original double Value: " + numberDouble);
            //  After value Conversion
            Console.WriteLine("Converted int Value: " + num1Int);
            Console.ReadLine();
            
            /*-----------Operator AND ,OR,NOT---------*/
            
            bool a = true;
            bool b = false;
            bool c;
           c = a && b;
            Console.WriteLine("Logical AND Operator is : " + c);
            c = a || b;
            Console.WriteLine("Logical OR Operator is  : " + c);
            c = !a;
            Console.WriteLine("Logical NOT Operator is : " + c);
            Console.ReadLine();
            
            /*------------- using ternary operator-------------*/

              int a1 = 90;
              int b1 = 60;
              int value;
              value = ((a1> b1) ? a1 : b1);
              Console.WriteLine("Greater value is  :" + value);
              Console.ReadLine();
            
            /* ----------using ifelse condition--------*/
            
            Console.WriteLine("enter the given number");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine($"the given number is even");
            }
            else
            {
                Console.WriteLine($" the given number is odd");
            }
            Console.ReadLine();

            /*------------using switcg statement displaying result---------*/
            int marks;
            Console.WriteLine("enter your your Result choice ");
            marks = Convert.ToInt32(Console.ReadLine());

            switch (marks)
            {
                case 1:
                    Console.WriteLine("kazeem Result is: distingtion");
                    break;
                case 2:
                    Console.WriteLine("kazeem Result is : first class");
                    break;
                case 3:
                    Console.WriteLine("kazeem Result is : second class");
                    break;
                case 4:
                    Console.WriteLine("kazeem Result is : third  class");
                    break;
                case 5:
                    Console.WriteLine("kazeem result is :fail");
                    break;
                default:
                    Console.WriteLine("Try your luck next time ");
                    break;



            }
        }

        }
}
