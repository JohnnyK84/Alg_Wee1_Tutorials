using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_14___Classes
{
    //new class
    class Employee  
    {
        public static int count = 0;

        public int employeeid;
        public string name;
        public string address;

        //Class constructor with parameters
        public Employee ()
        {
            name = "Johnny";
            employeeid = 123456;
            address = "12 Cameron Road, Tauranga, NZ";

            count++;
        }
        
        // Class constructor without parameters
        public Employee (string _name, int _employeeid, string _address )
        {
            name = _name;
            employeeid = _employeeid;
            address = _address;

            count++;
        }

        //get, set method for name
        public string changeName
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }

        }

        //get, set method for employeeid
        public int changeEmployeeid
        {
            get
            {
                return employeeid;
            }
            set
            {
                employeeid = value;
            }

        }

        //get, set method for address
        public string changeAddress
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }

        }

        public void Print ()
        {
            Console.WriteLine("Name:  " + name);
            Console.WriteLine("Employee ID:  " + employeeid);
            Console.WriteLine("Address:  " + address);
            Console.WriteLine();
            Console.WriteLine("Total Employees:  "+count);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //object 1 of class Employee
            Employee Sam = new Employee("Sam G", 789101, "15 Maunganui Road, Mt Maunganui, Tauranga, NZ");
            Sam.Print();

            //object 2 of class Employee
            Employee Default = new Employee();
            Default.Print();

            Sam.changeName = "Bob Jones";
            
            Sam.changeEmployeeid = 056789;
            
            Sam.changeAddress = "56 Bathurst Cresen, the lakes, Tauranga, NZ";
            Sam.Print();

            Console.ReadLine();
        }

    }
}
