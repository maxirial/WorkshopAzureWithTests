using System;
using System.Linq;
using WorkshopAzure.Managers;
using WorkshopAzure.Models;
using Xunit;

namespace WorkshopAzureTests
{
	public class EmployeeTests
	{
		private EmployeeManager EmployeeManager { get; set; } = new EmployeeManager();
		public EmployeeTests()
		{

		}
		[Fact]
		public void Should_Retrieve_Employees_Correctly_Test()
		{
			Assert.Equal(4, EmployeeManager.GetEmployees().Count);
		}

		[Fact]
		public void Nico_Should_Be_SuperHot_Test()
		{
			var nico = EmployeeManager.GetEmployees().FirstOrDefault(e => e.FirstName == "Nicolás");
			Assert.NotNull(nico);
			Assert.Equal(SensualityLevel.SuperHot, nico.SensualityLevel);
		}
	}
}
