using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HumanResource_Lahiye_isi_.Models;
using HumanResource_Lahiye_isi_.Services;

namespace HumanResource_Lahiye_isi_
{
    class Program
    {
        

        static void Main(string[] args)
        {
            HumanResourceManager humanResourceManager = new HumanResourceManager();
            do
            {
                Console.WriteLine("Etmek Isdediyniz Emelliyyati Secin");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("1.1 Departamentlerin siyahisini gostermek");
                Console.WriteLine("1.2 Departamenet yaratmaq");
                Console.WriteLine("1.3 Departamentde deyisiklik etmek");
                Console.WriteLine("2.1 Iscilerin siyahisini gostermek");
                Console.WriteLine("2.2 Departamentdeki iscilerin siyahisini gostermek");
                Console.WriteLine("2.3 Isci elave etmek");
                Console.WriteLine("2.4 Isci uzerinde deyisiklik etmek");
                Console.WriteLine("2.5 Departamentden isci silinmesi ");
                string answer = Console.ReadLine();

                switch (answer)
                {
                    case "1.1":
                       ShowDepartment(humanResourceManager);
                        break;
                    case "1.2":
                        AddDepartment(humanResourceManager);
                        break;
                    case "1.3":
                        ShowDepartment(humanResourceManager);
                        break;
                    case "2.1":
                        ShowDepartment(humanResourceManager);
                        break;
                    case "2.3":
                        ShowDepartment(humanResourceManager);
                        break;
                    case "2.4":
                        ShowDepartment(humanResourceManager);
                        break;
                    case "2.5":
                        ShowDepartment(humanResourceManager);
                        break;
                    default:
                        break;
                }

            } while (true);


        }
        public static void ShowDepartment(HumanResourceManager humanResourceManager)
        {
            
            foreach (Department item in humanResourceManager.departments)
            {               
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Employees.Count);
                Console.WriteLine(item.CalcSalaryAvarege(item.Employees));
            }
        }
        public static void AddDepartment(HumanResourceManager humanResourceManager)
        {            
            bool nameloop = true;
            bool workerlimitloop = true;
            bool salarylimitloop = true;
            string departmentname = "";
            int departmentworkerlimit = 0;
            double departmentsalarylimit = 0;
            Console.WriteLine("Departmentin adin daxil edin");
            while (nameloop)
            {              
                try
                {
                    departmentname = Console.ReadLine();
                    if (string.IsNullOrEmpty(departmentname) ==false && departmentname.Length>=2)
                    {
                        nameloop = false;
                    }
                    else
                    {
                        throw new Exception();
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("Duzgun ad daxil et");
                }
            }
            Console.WriteLine("Departmentin Workerlimitin daxil edin");
            while (workerlimitloop)
            {
                try
                {
                    departmentworkerlimit = int.Parse(Console.ReadLine());
                    if (departmentworkerlimit >= 1)
                    {
                        workerlimitloop = false;
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("Duzgun WorkerLimit daxil edin");
                }
            }
            Console.WriteLine("Departmentin Salarylimitin daxil edin");
            while (salarylimitloop)
            {
                try
                {
                     departmentsalarylimit = double.Parse(Console.ReadLine());
                    if (departmentsalarylimit>=250)
                    {
                        salarylimitloop = false;
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("Duzgun SalaryLimit daxil edin");
                }
            }
            Department department = new Department(departmentname,departmentworkerlimit,departmentsalarylimit);

            humanResourceManager.departments.Add(department);

        }

    }
}
