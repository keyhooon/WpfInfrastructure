using Microsoft.Xaml.Behaviors;
using System.Collections.Specialized;
using System.Windows.Controls;

namespace WpfInfrastructure.Behaviors
{
    class AutoScrollEndBehavior : Behavior<ListBox>
    {


        protected override void OnAttached()
        {

            ((INotifyCollectionChanged)AssociatedObject.Items).CollectionChanged += (sender, e) =>
            {
                AssociatedObject.SelectedIndex = AssociatedObject.Items.Count - 1;
                AssociatedObject.ScrollIntoView(AssociatedObject.SelectedItem);
            };
        }


    }
}
