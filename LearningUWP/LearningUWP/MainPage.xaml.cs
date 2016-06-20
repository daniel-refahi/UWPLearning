using LearningUWP.Models;
using Repository;
using System;
using System.Diagnostics;
using Windows.UI.Core;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace LearningUWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private MainPageModel Logic => DataContext as MainPageModel;
        public MainPage()
        {
            this.InitializeComponent();
            Logic.PropertyChanged += Logic_PropertyChanged;
            VisualStateManager.GoToState(this, Logic.LoadingState.ToString(), true);
        }
        
        private void Logic_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(MainPageModel.LoadingState))
            {
                VisualStateManager.GoToState(this, Logic.LoadingState.ToString(), true);
                Debug.WriteLine($"Time: {DateTime.Now} - State: {Logic.LoadingState}");
            }  
        }

        private async void DetailBt_Click(object sender, RoutedEventArgs e)
        {
            Employee employee = ((FrameworkElement)sender).DataContext as Employee;
            await new MessageDialog(string.Format("Your name is {0}", employee.Name)).ShowAsync();
        }

        private void aboutPageBt_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(About));
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Collapsed;
            base.OnNavigatedTo(e);
        }
    }
}
