using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningUWP.Models
{
    public class MainPageModel
    {
        public string SelectedName { get; set; } = "Daniel";
        public List<Company> Companies { get; set; } 

        public MainPageModel()
        {
            Companies = Repository.GetCompanies();         
        }
    }
}
