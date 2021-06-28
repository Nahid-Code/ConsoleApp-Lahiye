using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource_Lahiye_isi_.Models
{
     class Department
    {
        

        public string  Name { get; set; }
        public int  WorkerLimit { get; set; }
        public double SalaryLimit { get; set; }
        public List<Employee> Employees { get; set; }
        //departmentdeki iscilerin siyahisi.
        public Department(string name ,int workerlimit,double salarylimit)
        {
            Name = name;
            WorkerLimit = workerlimit;
            SalaryLimit = salarylimit;
            Employees = new List<Employee>();

        }

        

        public double CalcSalaryAvarege()
            //Departmendeki Iscilerin orta maasini hesablayan method.
        {
            double avarage = 0;
            double sum = 0;
            foreach (Employee item in Employees)
            {
                sum += item.Salary;
            }
            if (Employees.Count != 0)
            {
                avarage = sum / Employees.Count;
                return avarage;
            }
            else
            {
                return 0;
                //Department-de isci elave olunmadiqda console-da 0 gorsetsin.
            }

        }

        
    }
}
