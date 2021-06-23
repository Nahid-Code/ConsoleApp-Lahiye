using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HumanResource_Lahiye_isi_.Models;

namespace HumanResource_Lahiye_isi_
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee ("Item","Nahid" ,"Hacker",100000, "AyYildizTeam");
            Employee employee2 = new Employee("Item", "Nahid", "Hacker", 10000, "AyYildizTeam");
            Console.WriteLine(employee1.ToString());
            Console.WriteLine(employee2.ToString());

            Department d1 = new Department();
            
        }
    }
}
