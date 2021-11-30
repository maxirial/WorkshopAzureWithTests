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
		public void Rola_Should_Be_Rola_Sexy_Test()
		{
			var rola = EmployeeManager.GetEmployees().FirstOrDefault(e => e.FirstName == "Rolando");
			Assert.NotNull(rola);
			Assert.Equal(SensualityLevel.Medium, rola.SensualityLevel);
		}
	}
}
