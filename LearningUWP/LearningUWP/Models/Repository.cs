using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningUWP.Models
{
    public static class Repository
    {
        static string[] FirstNames = { "Daniel", "Rose", "Marc", "Leila", "Saha", "Mike", "Jo", "Albert", "Chaz", "Alex" };
        static string[] LastNames = { "Johnsen", "Marksen", "Uldrige", "Statun", "Rocky", "Tribiani", "Ross", "Alexsen", "Johansen", "Jazz" };
        static string[] Positions = { "Junior Software Engineer", "CIO", "CEO", "Software Engineer", "Senior Software Engineer", "Lead Software Engineer" };
        static string[] Locations = {"Brisbane", "London", "NewYork", "Sydney", "Melbourne", "Washangton", "Bon", "Rom" };
        static string[] Companies = {"Ikea", "Redback", "Microsoft", "BMW", "Facebook", "Shell", "Ventyx", "ABB" };
        public static List<Company> GetCompanies()
        {
            List<Company> companies = new List<Company>();
            foreach (var company in Companies)
            {
                Random er = new Random();
                int employeeCount = er.Next(1,10);
                Company c = new Company();
                c.Employees = new List<Employee>();
                for (int j = 0; j < employeeCount; j++)
                {
                    Employee e = new Employee();
                    er = new Random();
                    e.Age = er.Next(20, 40);
                    e.Name = string.Format("{0} {1}", FirstNames[er.Next(0, 9)], LastNames[er.Next(0, 9)]);
                    e.Position = Positions[er.Next(1,Positions.Length -1)];
                    c.Employees.Add(e);
                }
                c.Location = Locations[companies.Count];
                c.Name = company;
                companies.Add(c);

            }

            return companies;
        }
    }
}
