using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Employee
    {
        private int EmpId;
        private string name;

        public void setname(string name)
        {
            if (string.IsNullOrEmpty(name)== true)
            {
                Console.WriteLine("Name is required!");
            }
            else
            {
                this.name = name;
            }
        }
        public void setId(int EmpId)
        {
            this.EmpId = EmpId;
        }

        public void getdata()
        {
            Console.WriteLine($"This is Employee name {name} and ID no is {EmpId}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.setname("Shivam");
            emp.setId(4568);
            emp.getdata();
            Console.ReadLine();
            
        }
    }
}
