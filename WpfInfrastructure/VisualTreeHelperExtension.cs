using System.Windows;
using System.Windows.Media;

namespace WpfInfrastructure
{
    public static class VisualTreeHelperExtension
    {
        
            public static T FindAncestor<T>(this DependencyObject dependencyObject)
                where T : class
            {
                DependencyObject target = dependencyObject;
                do
                {
                    target = VisualTreeHelper.GetParent(target);
                }
                while (target != null && !(target is T));
                return target as T;
            }

    }
}
