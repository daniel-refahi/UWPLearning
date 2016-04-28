using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningUWP.Models
{
    public class MainPageModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public List<Company> Companies { get; set; }
        public ObservableCollection<Employee> Employees { get; set; } = new ObservableCollection<Employee>();

        public MainPageModel()
        {
            GetAllData();
        }

        private async void GetAllData()
        {
            Companies = await Repository.GetCompaniesAsync();
            PerformCompanyFiltering();
        }

        public ObservableCollection<Company> FilteredCompanies { get; set; } = new ObservableCollection<Company>();      

        private void PerformCompanyFiltering()
        {
            FilteredCompanies.Clear();
            if (_FilterCriteria == null || _FilterCriteria == string.Empty)
            {
                foreach (var company in Companies)
                {
                    FilteredCompanies.Add(company);
                }
            }
            else
            {
                foreach (var company in Companies)
                {
                    if (company.Location.Contains(_FilterCriteria)) FilteredCompanies.Add(company);
                    if (company.Name.Contains(_FilterCriteria)) FilteredCompanies.Add(company);
                }
            }
        }

        private string _FilterCriteria;
        public string FilterCriteria
        {
            get { return _FilterCriteria; }
            set
            {
                _FilterCriteria = value;
                PerformCompanyFiltering();
            }
        }

        private string _EmployeeListTitle;
        public string EmployeeListTitle
        {
            get
            {
                return (SelectedCompany == null) ? string.Empty : string.Format("You've selected {0}", SelectedCompany.Name);
            }
            set { _EmployeeListTitle = value; }
        }


        private Company _SelectedCompany;
        public Company SelectedCompany
        {
            get
            {
                return _SelectedCompany;
            }
            set
            {
                _SelectedCompany = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(EmployeeListTitle)));
                Employees.Clear();
                foreach (var e in _SelectedCompany.Employees)
                {
                    Employees.Add(e);
                }
            }
        }

    }
}
