using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkshopAzure.Models;

namespace WorkshopAzure.Managers
{
	public class EmployeeManager
	{

        public List<Employee> GetEmployees()
        {
            return new List<Employee>
            {
                new Employee(1, "Rolando", "Lescano", "rola.png", SensualityLevel.Rola),
                new Employee(2, "Carlos", "Monzón", "carlitos.png", SensualityLevel.SuperHot),
                new Employee(3, "Maximiliano", "Rial", "maxi.png", SensualityLevel.SuperHot),
                new Employee(4, "Nicolás", "Izquierdo", "nico.png", SensualityLevel.SuperHot)
            };
        }
    }
}
