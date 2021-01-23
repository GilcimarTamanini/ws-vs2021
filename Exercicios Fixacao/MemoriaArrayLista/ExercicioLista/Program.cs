using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioLista
{
    class Program
    {
        static void Main(string[] args)
        {
            int id;


            Console.Write("How many employees will be registered? ");
            int numEmployee = int.Parse(Console.ReadLine());

            List<Employee> listEmployee = new List<Employee>();

            for (int i = 1; i <= numEmployee; i++) 
            {
                Console.WriteLine("Employee #" + i + ":");
                Console.Write("Id: ");
                id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                listEmployee.Add(new Employee(id, name, salary));

                Console.WriteLine();
            }

            Console.WriteLine("Enter the employee id will have salary increase: ");
            id = int.Parse(Console.ReadLine());

            Employee employee = listEmployee.Find(x => x.Id == id);
            if (employee != null)
            {
                Console.WriteLine("Enter the percentage: ");
                double percent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                employee.RiseSalary(percent);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine("Update list of employees:");
            foreach (Employee objEmployee in listEmployee)
            {
                Console.WriteLine(objEmployee);
            }
        }
    }
}
