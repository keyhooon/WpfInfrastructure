using System.ComponentModel;
using System.Windows;
using System.Windows.Data;

namespace WpfInfrastructure.Selectors
{
    public class CollectionContain : DependencyObject
    {
        public static ICollectionView GetCollectionContain(DependencyObject obj)
        {
            return (ICollectionView)obj.GetValue(CollectionContainProperty);
        }

        public static void SetCollectionContain(DependencyObject obj, ICollectionView value)
        {
            obj.SetValue(CollectionContainProperty, value);
        }

        public static readonly DependencyProperty CollectionContainProperty =
            DependencyProperty.RegisterAttached("CollectionContain", typeof(ICollectionView),
                                                  typeof(CollectionContain), new PropertyMetadata(null, (d, e) =>
                                                    {
                                                        ((FrameworkElement)d).UpdateLayout();
                                                    }, (d, value) =>
                                                    {
                                                        return CollectionViewSource.GetDefaultView(value);
                                                    }));
    }
}
