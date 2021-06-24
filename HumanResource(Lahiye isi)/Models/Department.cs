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
        public Department(string name ,int workerlimit,double salarylimit)
        {
            Name = name;
            WorkerLimit = workerlimit;
            SalaryLimit = salarylimit;
        }

        public Department()
        {
        }

        public double CalcSalaryAvarege(List<Employee> employees)
        {
            double avarage=0;
            double sum=0;
            //Bura geri don Pervin Muellim problem boslug
            foreach (Employee item in employees)
            {
                sum += item.Salary;               
            }
            avarage = sum / employees.Count;
            return avarage;
            //Departmentdeki Iscilerin maas ortalamasinin hesablanmasi

        }

        
    }
}
