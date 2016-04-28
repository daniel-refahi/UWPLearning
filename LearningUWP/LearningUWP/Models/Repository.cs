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

        private static List<Company> _allCompanies;
        public static async  Task<List<Company>> GetCompaniesAsync()
        {
            if (_allCompanies != null)
                return _allCompanies;

            await Task.Delay(1000);
            _allCompanies = new List<Company>();
            foreach (var company in Companies)
            {                
                int employeeCount = RandomNumber(1,10);
                Company c = new Company();
                c.Employees = new List<Employee>();
                for (int j = 0; j < employeeCount; j++)
                {
                    Employee e = new Employee();                    
                    int age = RandomNumber(20, 40);
                    e.Age = age;
                    int nameNo = RandomNumber(0, 9);
                    int lastNameNo = RandomNumber(0, 9);
                    e.Name = string.Format("{0} {1}", FirstNames[nameNo], LastNames[lastNameNo]);
                    e.Position = Positions[RandomNumber(1,Positions.Length -1)];
                    c.Employees.Add(e);
                }
                c.Location = Locations[_allCompanies.Count];
                c.Name = company;
                _allCompanies.Add(c);

            }

            return _allCompanies;
        }

        private static readonly Random random = new Random();
        private static readonly object syncLock = new object();
        public static int RandomNumber(int min, int max)
        {
            lock (syncLock)
            { // synchronize
                return random.Next(min, max);
            }
        }
    }

    
}
