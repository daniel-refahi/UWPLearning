using LearningUWP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;

namespace LearningUWP.AppBarCommands
{
    public class SendEmailCommand : System.Windows.Input.ICommand
    {
        private MainPageModel _mpm;
        public SendEmailCommand(MainPageModel mpm)
        {
            _mpm = mpm;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter) => _mpm.SelectedCompany != null;        

        public async void Execute(object parameter)
        {
            await new MessageDialog(string.Format("An email has been sent to {0}", _mpm.SelectedCompany.Name)).ShowAsync();
        }

        public void FireCanExcuteChanged() => CanExecuteChanged?.Invoke(this, EventArgs.Empty);
    }
}
