
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace WpfInfrastructure.Selectors
{
    public class CollectionContainTemplateSelector: DataTemplateSelector
    {
        public DataTemplate ContainTemplate { get; set; }
        public DataTemplate NotContainTemplate { get; set; }
        public ICollectionView Collection { get; set; }
        public override DataTemplate
            SelectTemplate(object item, DependencyObject container)
        {
            var itemsControl = container.FindAncestor<ItemsControl>();
            var collectionContain = CollectionContain.GetCollectionContain(itemsControl);
            if (collectionContain?.Contains(item)??false)
                return ContainTemplate;
            return NotContainTemplate;
        }

    }
}
