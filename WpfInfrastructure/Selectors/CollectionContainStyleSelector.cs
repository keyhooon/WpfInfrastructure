using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace WpfInfrastructure.Selectors
{
    public class CollectionContainStyleSelector: StyleSelector
    {

        public Style ContainStyle { get; set; }
        public Style NotContainStyle { get; set; }
        public ICollectionView Collection { get; set; }
        public override Style SelectStyle(object item,
        DependencyObject container)
        {

            if (Collection.Contains(item))
                return ContainStyle;
            return NotContainStyle;
        }

    }
}
