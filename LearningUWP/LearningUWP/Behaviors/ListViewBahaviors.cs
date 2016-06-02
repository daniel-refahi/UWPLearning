using Microsoft.Xaml.Interactivity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace LearningUWP.Behaviors
{
    [TypeConstraint(typeof(ListViewBase))]
    public class AutoScrolToSelectedItem_B : DependencyObject, IBehavior
    {
        public DependencyObject AssociatedObject { get; private set; }
        private ListViewBase AssociatedListView => AssociatedObject as ListView;

        public void Attach(DependencyObject associatedObject)
        {
            AssociatedObject = associatedObject;
            if(AssociatedListView != null)
                AssociatedListView.SelectionChanged += AssociatedListView_SelectionChanged;
        }

        public void Detach()
        {
            if (AssociatedListView != null)
                AssociatedListView.SelectionChanged -= AssociatedListView_SelectionChanged;
        }

        private void AssociatedListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (AssociatedListView.SelectedItem == null)
                return;
            AssociatedListView.ScrollIntoView(AssociatedListView.SelectedItem);
        }

        
    }
}
