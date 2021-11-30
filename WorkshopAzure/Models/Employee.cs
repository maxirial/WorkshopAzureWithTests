using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkshopAzure.Models
{
    public class Employee
    {
        public Employee(int id, string firstName, string lastName, string pathToProfilePic, SensualityLevel sensualityLevel)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            PathToProfilePic = pathToProfilePic;
            SensualityLevel = sensualityLevel;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PathToProfilePic { get; set; }
        public SensualityLevel SensualityLevel { get; set; }

        public string SensualityLevelDescription
		{
            get
			{
                switch(SensualityLevel)
				{
                    case SensualityLevel.Low:
                        return "Bajo";
                    case SensualityLevel.Medium:
                        return "Not bad";
                    case SensualityLevel.High:
                        return "Alto";
                    case SensualityLevel.SuperHot:
                        return "Super hot";
                    case SensualityLevel.Rola:
                        return "Rola";
                    default:
                        throw new NotImplementedException();
				}
			}
		}
    }
}
