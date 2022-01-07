using System;
using System.Globalization;
using System.Collections.Generic;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Quantos funcionários serão registrados? ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Funcionário #" + i + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Salário: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Employee(id, name, salary));
                Console.WriteLine();
            }

            Console.Write(" Digite o id do funcionário que terá aumento de salário: ");
            int searchId = int.Parse(Console.ReadLine());

            Employee emp = list.Find(x => x.Id == searchId);
            if (emp != null)
            {
                Console.Write("Digite a porcentagem: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("Este id não existe!");
            }

            Console.WriteLine();
            Console.WriteLine("Lista atualizada de funcionários:");
            foreach (Employee obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}